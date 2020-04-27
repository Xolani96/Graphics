using System;
using System.Windows;

namespace Graphics.Client
{
    internal class Program: Application, IDisposable
    {
        #region ctor
        public Program()
        {
            Startup += (sender, args) => Ctor();
            Exit += (sender, args) => Dispose();
        }

        private void Ctor()
        {
            var readOnlyList = WindowFactory.SeedWindows();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
