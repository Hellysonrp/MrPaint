using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrPaint.Editor
{
    internal interface ITool
    {
        string Name { get; }

        void MouseDown(Bitmap bmp, MouseEventArgs e);
        void MouseMove(Bitmap bmp, MouseEventArgs e);
        void MouseUp(Bitmap bmp, MouseEventArgs e);
    }
}
