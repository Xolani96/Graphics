﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Graphics.Utilities
{
    public static class U
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
        public static IntPtr Handle(this System.Windows.Forms.Control window)
        {
            return window.IsDisposed ? default : Handle((System.Windows.Forms.IWin32Window)window);
        }

        public static IntPtr Handle(this System.Windows.Forms.IWin32Window window)
        {
            return window?.Handle ?? default;
        }
        public static IntPtr Handle(this System.Windows.Media.Visual window)
        {
            return window.HandleSource()?.Handle ?? default;
        }

        public static  System.Windows.Interop.HwndSource HandleSource(this System.Windows.Media.Visual window)
        {
            return System.Windows.PresentationSource.FromVisual(window) as System.Windows.Interop.HwndSource;
        }
    }
}
