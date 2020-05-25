using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Graphics.Win
{
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int X, Y;
        public POINT(int x, int y)
        {
            X = x;
            Y = y;
        }

        public POINT(Point pt):this(pt.X, pt.Y)
        {

        }

        public static implicit operator Point(POINT p) => new Point(p.X,p.Y);

        public static implicit operator POINT(Point p) => new POINT(p.X, p.Y);
    }
}
