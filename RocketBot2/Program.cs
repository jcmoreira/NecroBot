﻿#region using directives

using System;
using System.Windows.Forms;
using RocketBot2.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

#endregion

namespace RocketBot2
{
    internal class Program
    {
        [STAThread]
  

        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm(args));
        }
    }
}