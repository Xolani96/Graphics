using System;
using System.Collections.Generic;
using System.Windows;
using Graphics.Engine.Render;
using Graphics.Utilities;

namespace Graphics.Client
{
    internal class Program: Application, IDisposable
    {
        #region storage

        private IReadOnlyList<IRenderHost> Renderhosts { get; set; }

        #endregion

        #region ctor
        public Program()
        {
            Startup += (sender, args) => Ctor();
            Exit += (sender, args) => Dispose();
        }

        private void Ctor()
        {
            Renderhosts = WindowFactory.SeedWindows();
        }
        public void Dispose()
        {

            
            Renderhosts.ForEach(host => host.Dispose()); 
            //or
            //foreach (var renderhost in Renderhosts)
            //{
            //    renderhost.Dispose();
            //}
            Renderhosts = default;
        }
        #endregion
    }
}
