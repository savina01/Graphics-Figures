using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using CourseProject.Figures;


namespace CourseProject
{
    public partial class FormScene : Form , IGraphics
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();

        private List<Triangle> _triangles = new List<Triangle>();

        private List<Circle> _circle = new List<Circle>();

        private bool _captureMouse;
        private Point _captureLocation;
        private Rectangle _frameRec;
        private Triangle _frameTr;
        private Circle _frameCir;

        private Graphics _onPaintGraphics;
        public FormScene()
        {
            InitializeComponent();
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            //KeyPreview се използва за реализирането на изтриването, без този метод няма да работи програмата
            KeyPreview = true;
        }
        public void DrawRectangle(Color colorBorder, Color? colorFill, int x , int y , int width, int height)
        {
            if(_onPaintGraphics!=null)
            {
                if (colorFill.HasValue)
                {
                    using (var brush = new SolidBrush(colorFill.Value))
                        _onPaintGraphics.FillRectangle(brush, x, y, width, height);
                }
                using (var pen = new Pen(colorBorder, 3))
                    _onPaintGraphics.DrawRectangle(pen, x, y, width, height);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            _onPaintGraphics = e.Graphics;
            
            for (int i = _rectangles.Count - 1; i >= 0; i--)
            {
                _rectangles[i].Paint((Figures.IGraphics)this);
            }
            if (_captureMouse && _frameRec != null)
            {
                _frameRec.Paint((Figures.IGraphics)this);
            }
            _onPaintGraphics = null;

            for (int i = _triangles.Count - 1; i >= 0; i--)
            {
                _triangles[i].Paint(e.Graphics);
            }
            if (_captureMouse && _frameTr != null)
            {
                _frameTr.Paint(e.Graphics);
            }
            for (int i = _circle.Count - 1; i >= 0; i--)
            {
                _circle[i].Paint(e.Graphics);
            }
            if (_captureMouse && _frameCir != null)
                _frameCir.Paint(e.Graphics);
        }
        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            _captureMouse = true;
            _captureLocation = e.Location;

            if (radioButtonRectangle.Checked)
            {
                foreach (var rectangle in _rectangles)
                {
                    rectangle.Selected = false;
                }

                var selectedRectangle = _rectangles
                    .FirstOrDefault(r => r.Contains(e.Location));

                if (selectedRectangle != null)
                    selectedRectangle.Selected = true;

            }

            if (radioButtonTriangle.Checked)
            {
                foreach (var triangle in _triangles)
                {
                    triangle.Selected = false;
                }

                var selectedTriangle = _triangles
                    .FirstOrDefault(r => r.Contains(e.Location));

                if (selectedTriangle != null)
                    selectedTriangle.Selected = true;
            }

            if (radioButtonCircle.Checked)
            {
                foreach (var circle in _circle)
                {
                    circle.Selected = false;
                }

                var selectedCircle = _circle
                    .FirstOrDefault(r => r.Contains(e.Location));

                if (selectedCircle != null)
                    selectedCircle.Selected = true;
            }
            Invalidate();
        }
        private void DeleteSelectedRectangle()
        {
            for (int i = _rectangles.Count - 1; i >= 0; i--)
            {
                if (_rectangles[i].Selected)
                    _rectangles.RemoveAt(i);
            }
            RefreshAreaRectangle();
            RefreshPerimeterRectangle();
        }
        private void DeleteSelectedTriangle()
        {
            for (int i = _triangles.Count - 1; i >= 0; i--)
            {
                if (_triangles[i].Selected)
                    _triangles.RemoveAt(i);
            }
            RefreshAreaTriangle();
            RefreshPerimeterTriangle();
        }
        private void DeleteSelectedCircle()
        {
            for (int i = _circle.Count - 1; i >= 0; i--)
            {
                if (_circle[i].Selected)
                    _circle.RemoveAt(i);
            }
            RefreshAreaCircle();
            RefreshPerimeterCicle();
        }
        private void FormScene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                return;
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedRectangle();
                DeleteSelectedTriangle();
                DeleteSelectedCircle();
            }
        }
        private Rectangle CreateFrameRectangle(Point location)
        {
            var frameRec = new Rectangle
            {
                Location = new Point(
                   Math.Min(_captureLocation.X, location.X),
                   Math.Min(_captureLocation.Y, location.Y)),
                Width = Math.Abs(_captureLocation.X - location.X),
                Height = Math.Abs(_captureLocation.Y - location.Y)
            };
            return frameRec;
        }
        private Triangle CreateFrameTriangle(Point location, int height)
        {
            Point PointB = new Point(_captureLocation.X - (height / 2), location.Y);
            Point PointC = new Point(_captureLocation.X + (height / 2), location.Y);

            var frameTr = new Triangle
            {
                Location = _captureLocation,
                PointB_x = PointB.X,
                PointC_x = PointC.X,
                Height = height
            };
            return frameTr;
        }
        private Circle CreateFrameCircle(Point location)
        {
            var frameCir = new Circle
            {
                Location = _captureLocation,
                Radius = Math.Abs((_captureLocation.X - location.X) +
                    (_captureLocation.Y - location.Y))
            };

            return frameCir;
        }
        private void FormScene_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_captureMouse)
                return;

            if (radioButtonRectangle.Checked)
            {
                _frameRec = CreateFrameRectangle(e.Location);
                _frameRec.Fill = false;
                _frameRec.Color = Color.LightBlue;

                foreach (var rectangle in _rectangles
                    .Where(r => r.Intersects(_frameRec)))
                {
                    rectangle.Selected = true;
                }
            }
            else if (radioButtonTriangle.Checked)
            {
                var height = Math.Sqrt(
                   Math.Pow(_captureLocation.X - e.Location.X, 2)
                   + Math.Pow(_captureLocation.Y - e.Location.Y, 2));

                _frameTr = CreateFrameTriangle(e.Location, (int)height);
                _frameTr.Fill = false;
                _frameTr.Color = Color.LightBlue;

                foreach (var triangle in _triangles
                    .Where(r => r.Intersects(_frameTr)))
                {
                    triangle.Selected = true;
                }
            }
            else if (radioButtonCircle.Checked)
            {

                _frameCir = CreateFrameCircle(e.Location);
                _frameCir.Fill = false;
                _frameCir.Color = Color.LightBlue;

                foreach (var circle in _circle
                    .Where(r => r.Intersects(_frameCir)))
                {
                    circle.Selected = true;
                }
            }

            RefreshAreaTriangle();
            RefreshAreaRectangle();
            RefreshAreaCircle();
            RefreshPerimeterTriangle();
            RefreshPerimeterRectangle();
            RefreshPerimeterCicle();

            Invalidate();
        }
        private void RefreshAreaRectangle()
        {
            var area = 0;

            foreach (var rectangle in _rectangles)
                area += rectangle.GetArea();

            textBoxArea.Text = area.ToString();
        }
        private void RefreshAreaTriangle()
        {
            var area = 0;

            foreach (var triangle in _triangles)
            {
                area += triangle.GetArea();
            }
            textBoxArea.Text = area.ToString();
        }
        private void RefreshPerimeterRectangle()
        {
            var p = 0;

            foreach (var rectangle in _rectangles)
            {
                p += rectangle.Perimeter();
            }
            textBoxPerimeter.Text = p.ToString();
        }
        private void RefreshPerimeterTriangle()
        {
            var p = 0;
            foreach (var triangle in _triangles)
            {
                p += triangle.Perimeter();
            }
            textBoxPerimeter.Text = p.ToString();
        }
        private void RefreshAreaCircle()
        {
            var area = 0;
            foreach (var circle in _circle)
            {
                area += circle.GetArea();
            }
            textBoxArea.Text = area.ToString();
        }
        private void RefreshPerimeterCicle()
        {
            var p = 0;
            foreach (var circle in _circle)
            {
                p += circle.Perimeter();
            }
            textBoxPerimeter.Text = p.ToString();
        }
        private void RefreshAllShapesPerimeterAndArea()
        {
            var areaR = 0;

            foreach (var rectangle in _rectangles)
                areaR += rectangle.GetArea();

            var areaT = 0;

            foreach (var triangle in _triangles)
                areaT += triangle.GetArea();

            var areaC = 0;
            foreach (var circle in _circle)
                areaC += circle.GetArea();

            var areaShapes = areaC + areaR + areaT;

            var perimeterR = 0;

            foreach (var rectangle in _rectangles)
                perimeterR += rectangle.Perimeter();

            var perimeterT = 0;
            foreach (var triangle in _triangles)
                perimeterT += triangle.Perimeter();

            var perimeterC = 0;
            foreach (var circle in _circle)
                perimeterC += circle.Perimeter();

            var perimeterShapes = perimeterR + perimeterT + perimeterC;

            textBoxPerimeter.Text = perimeterShapes.ToString();
            textBoxArea.Text = areaShapes.ToString();
        }
        private void FormScene_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_captureMouse)
                return;

            else
            if (e.Button == MouseButtons.Right) 
            {
                if (radioButtonTriangle.Checked)
                {
                    _frameTr.Fill = true;
                    _frameTr.Selected = true;
                    _frameTr.Color = Color.Yellow;

                    _triangles.Insert(0, _frameTr);

                }
                else if (radioButtonRectangle.Checked)
                {
                    _frameRec.Fill = true;
                    _frameRec.Selected = true;
                    _frameRec.Color = Color.Pink;

                    _rectangles.Insert(0, _frameRec);

                }
                else if (radioButtonCircle.Checked)
                {
                    _frameCir.Fill = true;
                    _frameCir.Selected = true;
                    _frameCir.Color = Color.Blue;

                    _circle.Insert(0, _frameCir);
                }
            }

            _frameRec = null;
            _frameTr = null;
            _frameCir = null;

            _captureMouse = false;

            RefreshAreaTriangle();

            RefreshAreaRectangle();

            RefreshAreaCircle();

            RefreshPerimeterTriangle();

            RefreshPerimeterRectangle();

            RefreshPerimeterCicle();

            Invalidate();
        }
        private void FormScene_DoubleClick(object sender, EventArgs e)
        {
            var rectangle = _rectangles
                .FirstOrDefault(r => r.Selected);

            if (rectangle != null)
            {
                if (radioButtonRectangle.Checked)
                {
                    var fc = new FormChange();         //FormChangeRectangle
                    fc.MyWidth = rectangle.Width;
                    fc.MyHeight = rectangle.Height;
                    fc.MyColor = rectangle.Color;

                    if (fc.ShowDialog() == DialogResult.OK)
                    {
                        rectangle.Width = fc.MyWidth;
                        rectangle.Height = fc.MyHeight;
                        rectangle.Color = (Color)fc.MyColor;
                    }
                    RefreshAreaRectangle();
                    RefreshPerimeterRectangle();

                    Invalidate();
                }
            }

            var triangle = _triangles
                .FirstOrDefault(r => r.Selected);

            if (triangle != null)
            {
                if (radioButtonTriangle.Checked)
                {
                    var fc = new FormChangeTriangle();
                    fc.MyColor = triangle.Color;
                    fc.MySide = triangle.Side;
                    fc.MyHeight = triangle.Height;

                    if (fc.ShowDialog() == DialogResult.OK)
                    {
                        triangle.Color = (Color)fc.MyColor;
                        triangle.Side = fc.MySide;
                        triangle.Height = fc.MyHeight;
                    }
                    RefreshAreaTriangle();
                    RefreshPerimeterTriangle();

                    Invalidate();
                }
            }

            var circle = _circle
                .FirstOrDefault(r => r.Selected);

            if (circle != null)
            {
                var fc = new FormChangeCircle();
                fc.MyColor = circle.Color;

                if (fc.ShowDialog() == DialogResult.OK)
                {
                    circle.Color = (Color)fc.MyColor;
                }
                RefreshAreaCircle();
                RefreshPerimeterCicle();
                Invalidate();
            }

        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (radioButtonCircle.Checked)
            {
                var circle = new Circle();
                _circle.Add(circle);
                RefreshAreaCircle();
                RefreshPerimeterCicle();
            }
            else if (radioButtonRectangle.Checked)
            {
                var rect = new Rectangle();
                _rectangles.Add(rect);
                RefreshAreaRectangle();
                RefreshPerimeterRectangle();
            }
            else if (radioButtonTriangle.Checked)
            {
                var triangle = new Triangle();
                _triangles.Add(triangle);
                RefreshAreaTriangle();
                RefreshPerimeterTriangle();
            }
            Invalidate();
        }
        private void buttonCalculateAllShapes_Click(object sender, EventArgs e)
        {
            RefreshAllShapesPerimeterAndArea();
        }
        private void FormScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formatter = new BinaryFormatter();

            using (var stream = new FileStream("data", FileMode.OpenOrCreate))
            {       
                formatter.Serialize(stream, _rectangles);
                formatter.Serialize(stream, _triangles); 
                formatter.Serialize(stream, _circle);
            }
        }
        private void FormScene_Load(object sender, EventArgs e)
        {
            if (!File.Exists("data"))
                return;

            var formatter = new BinaryFormatter();
            using (var stream = new FileStream("data", FileMode.Open))
            {
                _rectangles = (List<Rectangle>)formatter.Deserialize(stream);
                _triangles = (List<Triangle>)formatter.Deserialize(stream);
                _circle = (List<Circle>)formatter.Deserialize(stream);
            }
        }
    }
}
