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
        int intToolselected = 0;
        int intBrushSize = 6;
        int intPenWidth = 2;
        Bitmap bmpPic;
        Color clrSelected;

        public form1()
        {
            InitializeComponent();
        }


        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawFlag = true;
            xDown = e.X;
            yDown = e.Y;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (intToolselected == 1 && drawFlag == true)                   //naar kijken volgende keer (doesn't seem to work)
            {
                xDown = e.X;
                yDown = e.Y;
                g.FillEllipse(new SolidBrush(clrSelected), xDown, yDown, intBrushSize, intBrushSize);
                picCanvas.Refresh();
            }
        }

        private void dimSquare()
        {
            if (xUp < 0)
            {
                xUp = 0;
            }
            if (xUp > 400)
            {
                xUp = 400;
            }
            if (yUp < 0)
            {
                yUp = 0;
            }
            if (yUp > 480)
            {
                yUp = 480;
            }
            WWint = Math.Abs(xUp - xDown);
            HHint = Math.Abs(yUp - yDown);
            if (WWint > HHint)
            {
                WWint = HHint;
            }
            if (xUp < xDown)
            {
                LLint = xDown - WWint;
            }
            else
            {
                LLint = xDown;
            }
            if (yUp < yDown)
            {
                TTint = yDown - WWint;
            }
            else
            {
                TTint = yDown;
            }
        }

        private void dimRectangle()
        {
            if (xUp < 0)
            {
                xUp = 0;
            }
            if (xUp > 480)
            {
                xUp = 480;
            }
            if (yUp < 0)
            {
                yUp = 0;
            }
            if (yUp > 480)
            {
                yUp = 480;
            }
            WWint = Math.Abs(xUp - xDown);
            HHint = Math.Abs(yUp - yDown);
            if (xUp < xDown)
            {
                LLint = xDown - WWint;
            }
            else
            {
                LLint = xDown;
            }
            if (yUp < yDown)
            {
                TTint = yDown - HHint;
            }
            else
            {
                TTint = yDown;
            }
        }

        private void dimCircle()
        {
            if (xUp < 0)
            {
                xUp = 0;
            }
            if (xUp > 480)
            {
                xUp = 480;
            }
            if (yUp < 0)
            {
                yUp = 0;
            }
            if (yUp > 480)
            {
                yUp = 480;
            }
            WWint = Math.Abs(xUp - xDown);
            HHint = Math.Abs(yUp - yDown);
            if (WWint < HHint)
            {
                WWint = HHint;
            }
            LLint = xDown - WWint;
            TTint = yDown - WWint;
            WWint *= 2;
        }

        private void mnuFileSave_Click(object sender, EventArgs e)              
        {
            sfdSavePic.Filter = "bitmap |*.bmp";                    
            if(sfdSavePic.ShowDialog() == DialogResult.OK)
            {                                                                                       //naar kijken volgende keer (doesn't seem to work)
                picCanvas.Image.Save(sfdSavePic.FileName, System.Drawing.Imaging.ImageFormat.Bmp); //error handling 
                MessageBox.Show("file saved.");
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dimEllipse()
        {
            if (xUp < 0)
            {
                xUp = 0;
            }
            if (xUp > 480)
            {
                xUp = 480;
            }
            if (yUp < 0)
            {
                yUp = 0;
            }
            if (yUp > 480)
            {
                yUp = 480;
            }
            WWint = Math.Abs(xUp - xDown);
            HHint = Math.Abs(yUp - yDown);
            LLint = xDown - WWint;
            TTint = yDown - HHint;
            WWint *= 2;
            HHint *= 2;
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            SolidBrush brushFill = new SolidBrush(clrSelected);
            Pen penLine = new Pen(clrSelected, intPenWidth);

            drawFlag = false;
            xUp = e.X;
            yUp = e.Y;

            switch (intToolselected)
            {

                case 2:
                    g.DrawLine(penLine, xDown, yDown, xUp, yUp);
                    break;
                //case 3: break;
                case 4:
                    dimSquare();
                    g.DrawRectangle(penLine, LLint, TTint, WWint, WWint);
                    break;
                case 5:
                    dimSquare();
                    g.FillRectangle(brushFill, LLint, TTint, WWint, WWint);
                    break;
                case 6:
                    dimRectangle();
                    g.DrawRectangle(penLine, LLint, TTint, WWint, HHint);
                    break;
                case 7:
                    dimRectangle();
                    g.FillRectangle(brushFill, LLint, TTint, WWint, HHint);
                    break;
                case 8:
                    dimCircle();
                    g.DrawEllipse(penLine, LLint, TTint, WWint, WWint);
                    break;
                case 9:
                    dimCircle();
                    g.FillEllipse(brushFill, LLint, TTint, WWint, WWint);
                    break;
                case 10:
                    dimEllipse();
                    g.DrawEllipse(penLine, LLint, TTint, WWint, HHint);
                    break;
                case 11:
                    dimEllipse();
                    g.FillEllipse(brushFill, LLint, TTint, WWint, HHint);
                    break;
            }
            picCanvas.Refresh();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = true;
            picCanvas.BackColor = Color.White;
            bmpPic = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(bmpPic);
            picCanvas.DrawToBitmap(bmpPic, picCanvas.ClientRectangle);
        }

        private void lblPalette_Click(object sender, EventArgs e)
        {

            Label lbl = (Label)sender;
            clrSelected.Equals(lbl.BackColor);
            lblColor.BackColor = lbl.BackColor;
            switch (lbl.BackColor.Name)
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
        }
        private void lblTool_Click(object sender, EventArgs e)
        {
            ResetTools();
            Label lbl = (Label)sender;
            switch (lbl.Tag)
            {
                case "Brush":
                    intToolselected = 1;
                    lblBrush.BorderStyle = BorderStyle.FixedSingle;
                    lblToolSelected.Text = "Tool: Brush";
                    break;
                case "Line":
                    intToolselected = 2;
                    lblLine.BorderStyle = BorderStyle.FixedSingle;
                    lblToolSelected.Text = "Tool: Line";
                    break;
                default:
                    intToolselected = 1;
                    lblBrush.BorderStyle = BorderStyle.FixedSingle;
                    lblToolSelected.Text = "Tool: Brush";
                    break;
            }
        }

        private void ResetTools()
        {
            lblBrush.BorderStyle = BorderStyle.Fixed3D;
            lblLine.BorderStyle = BorderStyle.Fixed3D;
        }

        private void cmbBrushSize_SelectedValueChanged(object sender, EventArgs e)
        {
            intBrushSize = Convert.ToInt32(cmbBrushSize.Text);
        }

        private void cmbPenWidth_SelectedValueChanged(object sender, EventArgs e)
        {
            intPenWidth = Convert.ToInt32(cmbPenWidth.Text);
        }
    }
}
