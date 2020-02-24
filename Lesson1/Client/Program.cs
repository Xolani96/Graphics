using System;

namespace Graphics.Client
{
    internal class Program: 
        System.Windows.Application , IDisposable
       
    {
        #region Constructor
        public Program()
        {
            Startup += (sender, args) => Ctor(); // event provided by the windows app class
            Exit += (sender, args) => Dispose();
        }
        private void Ctor()
        {
            
        } 
        public void Dispose()
        {

        }
        #endregion
    }
}
