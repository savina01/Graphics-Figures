using System.Drawing;

namespace CourseProject.Figures
{
    public interface IGraphics
    {
        void DrawRectangle(Color colorBorder, Color? colorFill, int x, int y, int width, int height);
    }
}
