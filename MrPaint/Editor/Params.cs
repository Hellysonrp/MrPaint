using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrPaint.Editor
{
    internal class Params
    {
        public static Params Instance { get; } = new Params();

        public Color PrimaryColor { get; set; } = Color.Black;
        public Color SecondaryColor { get; set; } = Color.White;
        public bool ShouldUseSecondaryColor { get; set; } = false;
        public State? CurrentState { get; set; }

        public Brush Brush
        {
            get
            {
                return new SolidBrush(ShouldUseSecondaryColor ? SecondaryColor : PrimaryColor);
            }
        }
        public Pen Pen
        {
            get
            {
                return new Pen(Brush);
            }
        }
    }
}
