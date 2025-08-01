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
            // On macOS, you can use Avalonia or Eto.Forms for cross-platform UI.
            // Here is a minimal example using Eto.Forms:

            // Make sure to add the Eto.Forms NuGet package:
            // dotnet add package Eto.Forms

            var app = new Eto.Forms.Application(Eto.Platforms.Mac64);
            var form = new Eto.Forms.Form
            {
                Title = "UniSim Window",
                ClientSize = new Eto.Drawing.Size(400, 300)
            };
            app.Run(form);
        }
    }
}