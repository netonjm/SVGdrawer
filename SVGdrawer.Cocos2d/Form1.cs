using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// System.Drawing and the XNA Framework both define Color types.
// To avoid conflicts, we define shortcut names for them both.
using GdiColor = System.Drawing.Color;
using XnaColor = Microsoft.Xna.Framework.Color;

namespace LvLEditor.Windows
{
    public partial class Form1 : Form
    {

        // Game1 game;

        public Form1()
        {
            InitializeComponent();

            //GraphicsDeviceManager rrr = new GraphicsDeviceManager();

            //game = new Game1(spinningTriangleControl1);

            vertexColor1b.SelectedIndex = 7;
            vertexColor2b.SelectedIndex = 5;
            vertexColor3b.SelectedIndex = 6;

            // game.Run();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (game != null)
            //    game.Dispose();
        }


        
        /// <summary>
        /// Event handler updates the spinning triangle control when
        /// one of the three vertex color combo boxes is altered.
        /// </summary>
        void vertexColor_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Which vertex was changed?
            int vertexIndex;

            if (sender == vertexColor1b)
                vertexIndex = 0;
            else if ( sender == vertexColor2b)
                vertexIndex = 1;
            else if ( sender == vertexColor3b)
                vertexIndex = 2;
            else
                return;

            // Which color was selected?
            ComboBox combo = (ComboBox)sender;

            string colorName = combo.SelectedItem.ToString();

            GdiColor gdiColor = GdiColor.FromName(colorName);

            XnaColor xnaColor = new XnaColor(gdiColor.R, gdiColor.G, gdiColor.B);

         
                spinningTriangleControl1.Vertices[vertexIndex].Color = xnaColor;
        }

        private void clearColor1_SelectedIndexChanged (object sender, System.EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string colorName = combo.SelectedItem.ToString();
            GdiColor gdiColor = GdiColor.FromName(colorName);
            XnaColor xnaColor = new XnaColor(gdiColor.R, gdiColor.G, gdiColor.B);

            spinningTriangleControl1.ClearColor = xnaColor;
        }

        private void clearColor2_SelectedIndexChanged (object sender, System.EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string colorName = combo.SelectedItem.ToString();
            GdiColor gdiColor = GdiColor.FromName(colorName);
            XnaColor xnaColor = new XnaColor(gdiColor.R, gdiColor.G, gdiColor.B);

            spinningTriangleControl1.ClearColor = xnaColor;
        }
    


    }
}
