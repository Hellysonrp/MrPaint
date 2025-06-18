using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrPaint.Editor
{
    internal class Bucket : ITool
    {
        public static Bucket Instance { get; } = new Bucket();

        public string Name => "Balde de Tinta";

        public void MouseDown(Bitmap bmp, MouseEventArgs e)
        {
            FloodFill(bmp, e.Location, Params.Instance.ShouldUseSecondaryColor ? Params.Instance.SecondaryColor : Params.Instance.PrimaryColor);
        }
        public void MouseMove(Bitmap bmp, MouseEventArgs e)
        {

        }
        public void MouseUp(Bitmap bmp, MouseEventArgs e)
        {

        }

        private void FloodFill(Bitmap bmp, Point pt, Color replacementColor)
        {
            // https://simpledevcode.wordpress.com/2015/12/29/flood-fill-algorithm-using-c-net/

            Color targetColor = bmp.GetPixel(pt.X, pt.Y);
            if (targetColor.ToArgb().Equals(replacementColor.ToArgb()))
            {
                return;
            }

            Stack<Point> pixels = new Stack<Point>();

            pixels.Push(pt);
            while (pixels.Count != 0)
            {
                Point temp = pixels.Pop();
                int y1 = temp.Y;
                while (y1 >= 0 && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    y1--;
                }
                y1++;
                bool spanLeft = false;
                bool spanRight = false;
                while (y1 < bmp.Height && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    bmp.SetPixel(temp.X, y1, replacementColor);

                    if (!spanLeft && temp.X > 0 && bmp.GetPixel(temp.X - 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X - 1, y1));
                        spanLeft = true;
                    }
                    else if (spanLeft && temp.X - 1 == 0 && bmp.GetPixel(temp.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }
                    if (!spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X + 1, y1));
                        spanRight = true;
                    }
                    else if (spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }
                    y1++;
                }

            }
        }
    }
}
