using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrPaint.Editor
{
    internal class Rectangle : ITool
    {
        public static Rectangle Instance { get; } = new Rectangle();

        public string Name => "Retângulo";

        private bool IsToolBeingUsed { get; set; } = false;
        private Point? StartPoint { get; set; } = null;

        public void MouseDown(Bitmap bmp, MouseEventArgs e)
        {
            StartPoint = e.Location;
            IsToolBeingUsed = true;
        }

        public void MouseMove(Bitmap bmp, MouseEventArgs e)
        {
            if (!IsToolBeingUsed) return;

            using Graphics g = Graphics.FromImage(bmp);
            var rect = new RectangleF(
                Math.Min(StartPoint!.Value.X, e.X),
                Math.Min(StartPoint.Value.Y, e.Y),
                Math.Abs(e.X - StartPoint.Value.X),
                Math.Abs(e.Y - StartPoint.Value.Y)
            );
            g.DrawRectangle(Params.Instance.Pen, rect);
        }

        public void MouseUp(Bitmap bmp, MouseEventArgs e)
        {
            IsToolBeingUsed = false;
            StartPoint = null;
        }
    }
}
