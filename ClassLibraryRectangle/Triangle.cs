using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CourseProject.Figures;

namespace CourseProject
{
    [Serializable]
    public class Triangle : Shape
    {
        protected int _side { get; set; }
        public Point Location { get; set; }
        public int PointB_x { get; set; }
        public int PointC_x { get; set; }   
        public bool Selected { get; set; }
        public int Side 
        {
            get => _side;
            set
            {
                _side = value;
            }
        }
        protected int _height { get; set; }
        public int Height
        {
            get => _height;
            set
            {
                _height = value;
            }
        }
        public Color Color { get; set; }
        public bool Fill { get; set; } = true;
        public override int GetArea()
        {
            Point pA = new Point(this.Location.X, this.Location.Y);
            Point pB = new Point(this.PointB_x, this.Location.Y + this.Height);
            Point pC = new Point(this.PointC_x, this.Location.Y + this.Height);

            Side = Math.Abs(pB.X - pC.X);
            Height = Math.Abs(pB.Y - pA.Y);

            return (Side*Height)/2;
        }
        public override int Perimeter()
        {
            Point pB = new Point(this.PointB_x, this.Location.Y + this.Height);
            Point pC = new Point(this.PointC_x, this.Location.Y + this.Height);

            Side = Math.Abs(pB.X - pC.X);         
            return 3 * Side;
        }
        public void Paint (Graphics g)
        {
            var borderColor = Selected
              ? Color.Red
              : Color;

            if (Fill)
            {
                using (var brush = new SolidBrush(Color))
                {
                    Point[] p = 
                    { 
                        Location,
                        new Point(
                            PointB_x,
                            Location.Y + Height),
                         
                        new Point(
                            PointC_x,
                            Location.Y + Height)
                    };
                    g.FillPolygon(brush, p);
                }
            }
            using (var pen = new Pen(borderColor, 3))
            {
                Point[] p =
                {
                    Location,
                    new Point(
                            PointB_x,
                            Location.Y + Height),

                    new Point(
                            PointC_x,
                            Location.Y + Height)
                };
                g.DrawPolygon(pen, p);
            }
        }
        public bool Contains(Point p)
        {
            Point pA = new Point(this.Location.X, this.Location.Y);
            Point pB = new Point(this.PointB_x, this.Location.Y + this.Height);
            Point pC = new Point(this.PointC_x, this.Location.Y + this.Height);

            var areaPAB = Math.Abs((p.X * (pA.Y - pB.Y) +
                pA.X * (pB.Y - p.Y) +
                pB.X * (p.Y - pA.Y)) / 2.0);

            var areaPAC = Math.Abs((p.X * (pA.Y - pC.Y) +
                pA.X * (pC.Y - p.Y) +
                pC.X * (p.Y - pA.Y)) / 2.0);

            var areaPBC = Math.Abs(p.X * (pB.Y - pC.Y) +
                pB.X * (pC.Y - p.Y) +
                pC.X * (p.Y - pB.Y) / 2.0);

            return areaPAB + areaPAC + areaPBC == this.GetArea();
        }
        public bool Intersects(Triangle triangle)
        {
            Point PointA = this.Location;
            Point PointB = new Point(this.PointB_x, this.Location.Y + this.Location.Y);
            Point PointC = new Point(this.PointC_x, this.Location.Y + this.Location.Y);

            Point PointFrameA = triangle.Location;
            Point PointFrameB = new Point(triangle.PointB_x, triangle.Location.Y + triangle.Location.Y);
            Point PointFrameC = new Point(triangle.PointC_x, triangle.Location.Y + triangle.Location.Y);

            return OnLine(PointA, Orientation(PointA, PointB, PointFrameA, PointFrameC), PointB) &&
                OnLine(PointFrameA, Orientation(PointA, PointB, PointFrameA, PointFrameC), PointFrameC) ||
                OnLine(PointA, Orientation(PointA, PointB, PointFrameB, PointFrameC), PointB) &&
                OnLine(PointFrameB, Orientation(PointA, PointB, PointFrameB, PointFrameC), PointFrameC) ||
                OnLine(PointA, Orientation(PointA, PointC, PointFrameA, PointFrameB), PointC) &&
                OnLine(PointFrameA, Orientation(PointA, PointC, PointFrameA, PointFrameB), PointFrameB) ||
                OnLine(PointA, Orientation(PointA, PointC, PointFrameB, PointFrameC), PointC) &&
                OnLine(PointFrameB, Orientation(PointA, PointC, PointFrameB, PointFrameC), PointFrameC) ||
                OnLine(PointB, Orientation(PointB, PointC, PointFrameA, PointFrameB), PointC) &&
                OnLine(PointFrameA, Orientation(PointB, PointC, PointFrameA, PointFrameB), PointFrameB) ||
                OnLine(PointB, Orientation(PointB, PointC, PointFrameA, PointFrameC), PointC) &&
                OnLine(PointFrameA, Orientation(PointB, PointC, PointFrameA, PointFrameC), PointFrameC);

        }
        public static Boolean OnLine(Point pointA, Point OnLine, Point pointB)
        {
            if (OnLine.X <= Math.Max(pointA.X, pointB.X) && OnLine.X >= Math.Min(pointA.X, pointB.X) &&
                OnLine.Y <= Math.Max(pointA.Y, pointB.Y) && OnLine.Y >= Math.Min(pointA.Y, pointB.Y))
                return true;

            return false;
        }
        public Point Orientation(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            int val = (pointB.Y - pointA.Y) * (pointC.X - pointD.X) -
                    (pointD.Y - pointC.Y) * (pointA.X - pointB.X);

            int c1 = (pointB.Y - pointA.Y) * (pointA.X) + (pointA.X - pointB.X) * (pointA.Y);
            int c2 = (pointD.Y - pointC.Y) * (pointC.X) + (pointC.X - pointD.X) * (pointC.Y);
        
            if (val == 0)
                return new Point(int.MaxValue,int.MaxValue); 
            else
            {
                int x = (((pointC.X - pointD.X) * c1) - (pointA.X - pointB.X) * c2) / val;
                int y = ((pointB.Y - pointA.Y) * c2 - (pointD.Y - pointC.Y) * c1) / val;
                return new Point(x, y);
            }
        }
        public static implicit operator int(Triangle triangle)
        {
            return triangle.GetArea();
        }
    }
}