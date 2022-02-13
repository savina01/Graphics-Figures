using System;
using System.Drawing;

namespace CourseProject
{
    [Serializable]
    public class Circle : Shape
    {
        public Point Location { get; set; }
        public Point MouseClick { get; set; }
        protected float _radius { get; set; }
        public bool Selected { get; set; }
        public Color Color { get; set; }
        public bool Fill { get; set; } = true;
        public float Radius
        {
            get => _radius;
            set
            {
                _radius = value;
            }
        }
        public override int GetArea()
        {
            return (int)(Math.PI*Radius*Radius);
        }
        public override int Perimeter()
        {
            return (int)(Math.PI*2*Radius);
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
                    g.FillEllipse(brush, MouseClick.X+Location.X,MouseClick.Y+Location.Y,Radius,Radius);
                }
            }
            using (var pen = new Pen(borderColor,3))
            {
                g.DrawEllipse(pen, MouseClick.X+Location.X, MouseClick.Y+Location.Y,Radius,Radius);
            }
        }
        public bool Contains(Point p)
        {
            var circle_x = MouseClick.X;
            var circle_y = MouseClick.Y;

            if ((Location.X - circle_x) * (Location.X - circle_x) +
                (Location.Y - circle_y) * (Location.Y - circle_y) >=
                Radius * Radius)
                return true;
            else
                return false;
        }
        public bool Intersects(Circle circle)
        {
            var _frameCenter = new Point(
                circle.MouseClick.X + (int)circle.Radius,
                circle.MouseClick.Y + (int)circle.Radius
                );

            var _centerCircle = new Point(
                MouseClick.X + (int)Radius,
                MouseClick.Y + (int)Radius
                );

            var distanceCenter = Math.Sqrt(Math.Pow(_centerCircle.X - _frameCenter.X, 2) + 
                Math.Pow(_centerCircle.Y - _frameCenter.Y, 2));

            return distanceCenter < circle.Radius + this.Radius;
        }
        public static implicit operator int(Circle circle)
        {
            return circle.GetArea();
        }

    }
}
