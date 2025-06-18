using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrPaint.Editor
{
    internal class Pencil : ITool
    {
        private bool IsToolBeingUsed { get; set; } = false;
        public static Pencil Instance { get; } = new Pencil();
        public Point? LastMouseLocation { get; set; } = null;

        public string Name => "Lápis";

        public void MouseDown(Bitmap bmp, MouseEventArgs e)
        {
            IsToolBeingUsed = true;
            LastMouseLocation = e.Location;
            using Graphics g = Graphics.FromImage(bmp);

            // https://stackoverflow.com/a/761070
            // ineficiente, mas serve pra demonstrar o funcionamento
            g.FillRectangle(Params.Instance.Brush, e.X, e.Y, 1, 1);
        }

        public void MouseMove(Bitmap bmp, MouseEventArgs e)
        {
            if (!IsToolBeingUsed) return;

            using Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Params.Instance.Brush, e.X, e.Y, 1, 1);
            if (LastMouseLocation.HasValue)
                g.DrawLine(Params.Instance.Pen, LastMouseLocation.Value, e.Location);

            LastMouseLocation = e.Location;
        }

        public void MouseUp(Bitmap bmp, MouseEventArgs e)
        {
            IsToolBeingUsed = false;
            LastMouseLocation = null;
        }
    }
}
