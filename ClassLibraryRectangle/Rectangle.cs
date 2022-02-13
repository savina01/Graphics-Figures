using System;
using System.Drawing;
using CourseProject.Figures;

namespace CourseProject
{ 
    [Serializable]
    public class Rectangle : Shape
    {
        public Point Location { get; set; }
        protected int _width { get; set; }
        protected int _height { get; set; }
        public Color Color { get; set; }
        public bool Fill { get; set; } = true;
        public bool Selected { get; set; }
        public int Width
        {
            get => _width;
            
            set
            {
                _width = value;
            }
        }
        public int Height
        {
            get => _height;
            set
            {
                _height = value;
            }
        }
        public override int GetArea()
        {   
            return Width * Height;
        }
        public override int Perimeter()
        {
            return (2 * Width) + (2 * Height);
        }
        public void Paint(IGraphics g)
        {
            var borderColor = Selected
                ? Color.Red
                : Color;

            g.DrawRectangle(
                borderColor,
                Fill
                ? Color
                : (Color?) null,
                Location.X, 
                Location.Y,
                Width,
                Height);
        }
        public bool Contains(Point p)
        {
            return
                Location.X < p.X && p.X < Location.X + Width &&
                Location.Y < p.Y && p.Y < Location.Y + Height;
        }
        public bool Intersects(Rectangle rectangle)
        {
            return
                this.Location.X < rectangle.Location.X + rectangle.Width &&
                rectangle.Location.X < this.Location.X + this.Width &&
                this.Location.Y < rectangle.Location.Y + rectangle.Height &&
                rectangle.Location.Y < this.Location.Y + this.Width;
        }
        public static implicit operator int (Rectangle rectangle)
        {
            return rectangle.GetArea();
        }

    }
}
