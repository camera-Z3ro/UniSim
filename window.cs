// v0.1.0
// This file is part of UniSim, a (future) cross-platform simulation framework.

using System;
using System.Runtime.InteropServices;

namespace UniSim
{
    public class Window
    {
        public Window()
        {
            var app = new Eto.Forms.Application(Eto.Platforms.Mac64);
            var form = new Eto.Forms.Form
            {
                Title = "UniSim",
                ClientSize = new Eto.Drawing.Size(400, 300)
            };
            app.Run(form);
        }
    }
}