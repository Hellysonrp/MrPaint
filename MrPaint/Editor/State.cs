using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrPaint.Editor
{
    public class State(string name, Bitmap bmp): IDisposable
    {
        public string Name { get; } = name;
        public Bitmap Value { get; } = new Bitmap(bmp);

        public void Dispose()
        {
            Value.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
