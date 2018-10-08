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
            LLint, TTint, WWint, HHint = 0; //define the bounding rectangle for all of the geometric shapes 
        int intToolselected = 1;
        int intBrushSize = 6;
        int intPenWidth = 2;
        Bitmap bmpPic;
        Color clrSelected = Color.Black;
        int intFontSize = 35;
        string strText;
        string strFont = "Arial";
        FontStyle styFontstyle = new FontStyle();
        //string[] strFontStyleArray = new[] { "Regular", "Bold", "Italic", "Bold Italic", "Unknown", "Unknown", "Unknown", "Unknown", "Regular Strikeout", "Bold Strikeout", "Italic Strikeout", "Bold Italic Strikeout", "Regular Underline Strikeout", "Bold Underline Strikeout", "Italic Underline Strikeout", "Bold Italic Underline Strikeout" };

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
            if (intToolselected == 1 && drawFlag == true)                   
            {
                xDown = e.X;
                yDown = e.Y;
                g.FillEllipse(new SolidBrush(clrSelected), xDown, yDown, intBrushSize, intBrushSize);
                g.Save();
                picCanvas.Image = bmpPic;
                picCanvas.Refresh();
            }
        }

        #region figuurtjes

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

        #endregion

        private void mnuFileSave_Click(object sender, EventArgs e)              
        {
            sfdSavePic.Filter = "bitmap |*.bmp";                    
            if(sfdSavePic.ShowDialog() == DialogResult.OK)
            {                                                                                     
                picCanvas.Image.Save(sfdSavePic.FileName, System.Drawing.Imaging.ImageFormat.Bmp); 
                MessageBox.Show("file saved.");
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdFont_Click(object sender, EventArgs e)
        {
            dlgFont.ShowDialog();
            strFont = dlgFont.Font.Name;
            intFontSize = Convert.ToInt32(dlgFont.Font.Size);
            //lblFontDetails.Text = "(" + strFont + " " + intFontSize + "pt, " + strFontStyleArray(styFontStyle) + ")";
        }

        private void cmbBrushSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            SolidBrush brushFill = new SolidBrush(clrSelected);
            Pen penLine = new Pen(clrSelected, intPenWidth);

            drawFlag = false;
            xUp = e.X;
            yUp = e.Y;

            lblTextOverlay.Location = new Point(picCanvas.Width / 2 - lblTextOverlay.Width / 2, picCanvas.Height / 2 - lblTextOverlay.Height / 2);

            switch (intToolselected)
            {

                case 2:
                    g.DrawLine(penLine, xDown, yDown, xUp, yUp);
                    break;
                case 3:
                    lblTextOverlay.Text = txtInsertText.Text;
                    lblTextOverlay.Location = new Point(picCanvas.Width / 2 - lblTextOverlay.Width / 2, picCanvas.Height / 2 - lblTextOverlay.Height / 2);
                    lblTextOverlay.Visible = true;
                    break;
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
            g.Clear(Color.White);
            picCanvas.Image = bmpPic;
        }
        #region Toolselection

        private void lblPalette_Click(object sender, EventArgs e)
        {

            Label lbl = (Label)sender;
            clrSelected.Equals(lbl.BackColor);
            lblColor.BackColor = lbl.BackColor;
            switch (lbl.BackColor.Name)
            {
                case "Black":
                    lblColorSelected.Text = "Colour: Black";
                    clrSelected = Color.Black;
                    break;
                case "Red":
                    lblColorSelected.Text = "Colour: Red";
                    clrSelected = Color.Red;
                    break;
                case "Navy":
                    lblColorSelected.Text = "Colour: Navy";
                    clrSelected = Color.Navy;
                    break;
                default:
                    lblColorSelected.Text = "Colour:  Black";
                    clrSelected = Color.Black;
                    break;
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
                case "Text":
                    intToolselected = 3;
                    lblBrush.BorderStyle = BorderStyle.FixedSingle;
                    lblToolSelected.Text = "Tool: Text";
                    break;
                    
                default:
                    intToolselected = 1;
                    lblBrush.BorderStyle = BorderStyle.FixedSingle;
                    lblToolSelected.Text = "Tool: Brush";
                    break;
            }
        }
        #endregion

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
