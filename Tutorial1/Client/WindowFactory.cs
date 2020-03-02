using Graphics.Engine.Render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics.Client
{
    public static class WindowFactory
    {
        public static IReadOnlyList<IRenderHost> SeedWindows()
        {

        }
        private static IRenderHost CreateWindowForm(System.Drawing.Size size , string title)
        {
            var windows = new System.Windows.Forms();
        }
    }
}
