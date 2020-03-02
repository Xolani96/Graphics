using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics.Engine.Render
{
    public class RenderHost 
        : IRenderHost
    {
        #region Storage
        public IntPtr HostHandle { get; private set; }
        #endregion

        #region ctor
        public RenderHost( IntPtr hostHandle)
        {
            this.HostHandle = hostHandle;
        }
        public void Dispose()
        {
            HostHandle = default; //it sets the default value and the default value for all the reference types is null
        }
        #endregion
    }
}
