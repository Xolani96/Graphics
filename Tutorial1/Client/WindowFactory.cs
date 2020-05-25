using Graphics.Engine.Render;
using Graphics.Utilities;
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
            var size = new System.Drawing.Size(720, 480);

            var renderhost = new[]
            {
                CreateWindowForm(size, "Forms GDI", h => new RenderHost(h)),
                CreateWindowWpf(size, "WPF GDI", h => new RenderHost(h))
            };
            return renderhost;
        }
        private static IRenderHost CreateWindowForm(System.Drawing.Size size , string title, Func<IntPtr, IRenderHost> ctorrenderHost)
        {
            var window = new System.Windows.Forms.Form
            {
                Size = size,
                Text = title
            };

            var hostcontrol = new System.Windows.Forms.Panel()
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                BackColor = System.Drawing.Color.Transparent,
                ForeColor = System.Drawing.Color.Transparent,
            };
            window.Controls.Add(hostcontrol);

            hostcontrol.MouseEnter += (sender, args) =>
            {
                //It will activate the window when I move the ouse over it. 
                if (System.Windows.Forms.Form.ActiveForm != window) window.Activate();
                if (!hostcontrol.Focused) hostcontrol.Focus();
            };

            window.FormClosed += (sender, args) => System.Windows.Application.Current.Shutdown();

            window.Show();

            return ctorrenderHost(hostcontrol.Handle()); 
        }
        
        public static IRenderHost CreateWindowWpf(System.Drawing.Size size, string title, Func<IntPtr, IRenderHost> ctorrenderHost)
        {
            var window = new System.Windows.Window
            {
                Width = size.Width,
                Height = size.Height,
                Title = title
            };

            var hostControl = new System.Windows.Controls.Grid()
            {
                Background = System.Windows.Media.Brushes.Transparent,
                Focusable = true,

            };
            window.Content = hostControl;

            hostControl.MouseEnter += (sender, args) =>
            {
                if (!window.IsActive) window.Activate();
                if (!hostControl.IsFocused) hostControl.Focus();
            };

            window.Closed += (sender, args) => System.Windows.Application.Current.Shutdown(); // when you close the window, it shutsdown the current application

            window.Show();

            return ctorrenderHost(hostControl.Handle());
        }
        
        private static void SortWindows(IEnumerable<RenderHost> renderhost)
        {

        }
    }
}
