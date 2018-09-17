using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPaint
{
    public partial class form1 : Form
    {
        Graphics g; //defines an incredible number of methods for drawing and manipulating gaphic objects.
        bool drawFlag = false; //check mouse down
        int xDown, yDown, xUp, yUp, //track the screen positions
            LLint, TTint, BBint, WWint, HHint = 0; //define the bounding rectangle for all of the geometric shapes 


        Color clrSelected;
        int intToolselected = 0;
        int intBrushSize = 6;
        int intPenWidth;
        Bitmap bmpPic;

        public form1()
        {
            InitializeComponent();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = true;
            picCanvas.BackColor = Color.White;
            bmpPic = new Bitmap(picCanvas.Width,picCanvas.Height);
            g = Graphics.FromImage(bmpPic);
            picCanvas.DrawToBitmap(bmpPic, picCanvas.ClientRectangle);
        }

        private void lblPalette_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            switch(lbl.BackColor.Name)
            {
                
                case "Black":
                    lblColorSelected.Text = "Colour: Black"; break;
                case "Red":
                    lblColorSelected.Text = "Colour: Red"; break;
                case "Navy":
                    lblColorSelected.Text = "Colour: Navy"; break;
                default:
                    lblColorSelected.Text = "Colour:  Black"; break;
            }

            //if(lbl.BackColor == Color.Black)
            //{
            //    lblColorSelected.Text = "Colour: Black";
            //}
            //else if(lbl.BackColor == Color.Navy)
            //{
            //    lblColorSelected.Text = "Colour: Navy";
            //}
            //else if(lbl.BackColor == Color.Red)
            //{
            //    lblColorSelected.Text = "Colour: Red";
            //}
        }
    }
}
