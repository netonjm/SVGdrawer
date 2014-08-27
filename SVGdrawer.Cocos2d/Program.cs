using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using System.Windows.Forms;

namespace LvLEditor.Windows
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
          
        }
    }


}

