using System;

namespace CourseProject
{
    [Serializable]

    public abstract class Shape
    {
        public abstract int GetArea();
        public abstract int Perimeter();
    }
}
