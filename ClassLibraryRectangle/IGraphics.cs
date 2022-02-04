using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CourseProject.Figures
{
    public interface IGraphics
    {
        void DrawRectangle(Color colorBorder, Color? colorFill, int x, int y, int width, int height);
    }
}
