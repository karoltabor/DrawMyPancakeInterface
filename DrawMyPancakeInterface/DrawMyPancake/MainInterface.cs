using EV3WifiLib;
using PanelTesting.Properties;
using System;
using System.Collections;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace DrawMyPancake {
    public partial class mainForm : Form
    {
        Graphics g;                                     //defines methods for drawing
        bool drawFlag = false;                          
        int xDown, yDown, xUp, yUp,                     
            LLint, TTint, WWint, HHint = 0;             
        int intBrushSize = 20;
        int selectedPreset = 7;
        Bitmap bmpPic;
        Color clrSelected = Color.FromArgb(218, 134, 73);
        private Instruction ev3Instuction;                      
        private ArrayList ev3InstuctionList = new ArrayList();
        SettingsForm inputBox;

        private string ipEV3 = "192.168.43.153";
        private EV3Wifi myEV3;
        private Timer messageReceiveTimer;

        public mainForm()
        {
            bmpPic = Resources.DMP_Bitmap;
            InitializeComponent();

            messageReceiveTimer = new Timer();
            messageReceiveTimer.Interval = 100;
            messageReceiveTimer.Tick += new System.EventHandler(messageReadTimer_Tick);
            myEV3 = new EV3Wifi();
            Connect();

            //Make Canvas on opening
            g = Graphics.FromImage(bmpPic);
            picCanvas.Image = bmpPic;
            picCanvas.Width = bmpPic.Width;
            picCanvas.Height = bmpPic.Height;

            picCanvas.Location = new Point((pnlBitmap.Width / 2 - bmpPic.Width / 2), pbLogo.Height + ((pnlBitmap.Height - pbLogo.Height) / 2 - bmpPic.Height / 2));
            pnlAddTextBg.Location = new Point((pnlAddText.Width / 2 - pnlAddTextBg.Width / 2), ((pnlAddText.Height - pbLogo.Height) / 2 - pnlAddTextBg.Height / 2));
            pbPresetPreview.Location = new Point((pnlBitmap.Width / 2 - bmpPic.Width / 2), pbLogo.Height + ((pnlBitmap.Height - pbLogo.Height) / 2 - bmpPic.Height / 2));

        }

        private void mainForm_Resize(object sender, EventArgs e) {
            picCanvas.Location = new Point((pnlBitmap.Width / 2 - bmpPic.Width / 2), pbLogo.Height + ((pnlBitmap.Height - pbLogo.Height) / 2 - bmpPic.Height / 2));
            pbPresetPreview.Location = new Point((pnlBitmap.Width / 2 - bmpPic.Width / 2), pbLogo.Height + ((pnlBitmap.Height - pbLogo.Height) / 2 - bmpPic.Height / 2));

        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected || true)
            {
                switch (selectedPreset)
                {
                    case 2:
                        myEV3.SendMessage("Square", "0");
                        break;
                    case 3:
                        myEV3.SendMessage("Smiley", "0");
                        break;
                    case 4:
                        myEV3.SendMessage("Triangle", "0");
                        break;
                    case 5:
                        myEV3.SendMessage("Heart", "0");
                        break;
                    case 6:
                        myEV3.SendMessage("Spiral", "0");
                        break;
                    case 7:
                        myEV3.SendMessage("Text", "0");
                        Console.WriteLine(tbText.Text.ToLower());
                        myEV3.SendMessage(textPayload(tbText.Text), "1");
                        break;
                    default:
                        if(ev3InstuctionList.Count > 0) {
                            myEV3.SendMessage("FreeDraw", "0");

                            foreach(String instruction in ev3InstuctionList) {
                                myEV3.SendMessage(instruction, "0");
                            }
                        } else {
                            MessageBox.Show("No drawing found!");
                        }
                        break;
                }

            }
        }

        #region Main buttons
        /// <summary>
        /// Main Buttons eventhandlers
        /// </summary>

        private void SelectPreset(object sender,EventArgs e)
        {
            pbPresetPreview.Visible = true;
            picCanvas.Visible = true;
            pnlBitmap.Visible = true;
            pbPresetPreview.BackColor = Color.Transparent;          /// todo: plaatjes
            switch (((Button)sender).Name)
            {
                case "btnSquare":
                    clearDrawing();
                    pbPresetPreview.Image = Resources.square_icon;
                    selectedPreset = 2;
                    break;
                case "btnSmiley":
                    clearDrawing();
                    pbPresetPreview.Image = Resources.smiley_icon3;
                    selectedPreset = 3;
                    break;
                case "btnTriangle":
                    clearDrawing();
                    pbPresetPreview.Image = Resources.triangle_icon3;
                    selectedPreset = 4;
                    break;
                case "btnHeart":
                    clearDrawing();
                    pbPresetPreview.Image = Resources.preset_icon4;
                    selectedPreset = 5;
                    break;
                case "btnSpiral":
                    clearDrawing();
                    pbPresetPreview.Image = Resources.spiral_icon;
                    selectedPreset = 6;
                    break;
            }
        }

        private void SelectTool(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnMenu":
                    // to do: Make menu buttons smaller
                    break;

                case "btnPreset":
                    pnlAddText.Visible = false;
                    pnlPresetsButtons.Visible = true;
                    //pnlBitmap.Visible = false;
                    break;

                case "btnPen":
                    pnlAddText.Visible = false;
                    pnlPresetsButtons.Visible = false;
                    pbPresetPreview.Visible = false;
                    pnlBitmap.Visible = true;
                    g = Graphics.FromImage(Resources.DMP_Bitmap);
                    selectedPreset = 1;
                    break;

                case "btnText":
                    pnlAddText.Visible = true;
                    pnlPresetsButtons.Visible = false;
                    pnlBitmap.Visible = false;
                    pnlAddTextBg.Location = new Point((pnlAddText.Width / 2 - pnlAddTextBg.Width / 2), ((pnlAddText.Height - pbLogo.Height) / 2 - pnlAddTextBg.Height / 2));
                    selectedPreset = 7;
                    break;

                case "btnClear":
                    clearDrawing();
                    break;

                case "btnOpen":
                    ofdLoadPic.Filter = "bitmap |*.bmp";
                    if (ofdLoadPic.ShowDialog() == DialogResult.OK)
                    {
                        picCanvas.Image = new Bitmap(ofdLoadPic.FileName);
                        picCanvas.Refresh();
                    }
                    break;

                case "btnSave":
                    sfdSavePic.Filter = "bitmap |*.bmp";
                    if (sfdSavePic.ShowDialog() == DialogResult.OK)
                    {
                        picCanvas.Image.Save(sfdSavePic.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        MessageBox.Show("file saved.");
                    }
                    break;
                case "btnSettings":
                    if (inputBox != null) break;
                    inputBox = new SettingsForm();
                    inputBox.TopMost = true;
                    inputBox.Show();
                    inputBox.lblBrushColor.BackColor = clrSelected;
                    inputBox.btnConnect.Click += new EventHandler(changeIP);
                    inputBox.btnSendCommand.Click += new EventHandler(sendCommand);
                    inputBox.btnDisconnect.Click += new EventHandler(Disconnection);
                    inputBox.btnConfirm.Click += new EventHandler(changeBrushSize);
                    inputBox.rbtnDark.CheckedChanged += new EventHandler(setTheme);
                    inputBox.FormClosed += new FormClosedEventHandler(disposeInputbox);
                    break;
            }
        }

        private void menuButton_MouseHover(object sender, EventArgs e)
        {
            pnlPresetsButtons.Visible = ((Button)sender).Name == "btnPreset" ? true : false;
        }

        private void disposeInputbox(object sender, EventArgs e)
        {
            inputBox.Dispose();
            inputBox = null;
        }

        private void setTheme(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.BackColor = Color.FromArgb(68, 67, 67);
                //sidepanel todo
            }
            else
            {
                this.BackColor = Color.FromArgb(247,247,247);
                //sidepanel todo
            }
        }
        #endregion

        #region SettingsForm
        /// <summary>
        /// Settingsform Functions
        /// </summary>

        private void changeBrushSize(object sender, EventArgs e)
        {
            intBrushSize = Convert.ToInt32(inputBox.cmbSize.Text);
            clrSelected = inputBox.clrBrushColor.Color;
            inputBox.lblBrushColor.BackColor = clrSelected;
        }

        private void clearDrawing()
        {
            bmpPic = Resources.DMP_Bitmap;
            g = Graphics.FromImage(bmpPic);
            ev3InstuctionList.Clear();
            picCanvas.Image = bmpPic;
            picCanvas.Refresh();
            tbText.Text = "";
        }
        
        private void changeIP(object sender, EventArgs e)
        {
            ipEV3 = inputBox.tbIp.Text;
            Connect();
        }

        private void Connect()
        {
            if (!IPAddress.TryParse(ipEV3, out IPAddress address))
            {
                MessageBox.Show("Fill in valid IP address of EV3");
            }
            else if (myEV3.Connect("1234", ipEV3) == true)
            {
                messageReceiveTimer.Start();
                MessageBox.Show("Connected to EV3");
            }
            else
            {
                myEV3.Disconnect();
                MessageBox.Show("Failed to connect to EV3 with IP address " + ipEV3);
            }
        }

        private void Disconnection(object sender, EventArgs e)
        {
            myEV3.Disconnect();
            MessageBox.Show("Disconnect");
        }
        
        private void messageReadTimer_Tick(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                string strMessage = myEV3.ReceiveMessage("EV3_OUTBOX0");
            }
        }

        private void sendCommand(object sender, EventArgs e)
        {
            myEV3.SendMessage(inputBox.tbCommand.Text, "0");
        }

        #endregion

        #region figuurtjes

        /// <summary>
        /// Backup draw figures in case of drawing functionalities are increased
        /// </summary>

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

        #region Freedraw
        /// <summary>
        /// Freedraw function
        /// Send Instructions to robot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawFlag = true;
            xDown = e.X;
            yDown = e.Y;
            ev3Instuction = new Instruction();
            ev3Instuction.AddCoordinate(e.X, e.Y, picCanvas.Width);
            g = Graphics.FromImage(picCanvas.Image);
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawFlag == true && selectedPreset == 1)
            {
                xDown = e.X;
                yDown = e.Y;
                ev3Instuction.AddCoordinate(xDown, yDown, picCanvas.Width);
                g.FillEllipse(new SolidBrush(clrSelected), xDown, yDown, intBrushSize, intBrushSize);
                g.Save();
                picCanvas.Image = bmpPic;
                picCanvas.Refresh();
            }
        }
        
        private void picCanvas_MouseUp(object sender, MouseEventArgs e) {
            ev3Instuction.AddCoordinate(e.X, e.Y, picCanvas.Width);
            ArrayList instructionStrings = ev3Instuction.InstructionStrings();
            foreach(String instruction in instructionStrings) {
                ev3InstuctionList.Add(instruction);
            }
            drawFlag = false;
            g.Dispose();
            picCanvas.Refresh();
        }
        #endregion

        /// <summary>
        /// Send central text to robot (align center)
        /// </summary>
        private string textPayload(string text)
        {
            text = text.ToLower();
            int len = text.Length;
            if (len % 2 == 0)
            {
                text = text.PadLeft((6 - len) / 2);
                text = text.PadRight((6 - len) / 2);
            }
            else
            {
                text = text.PadLeft((6 - len + 1) / 2);
                text = text.PadRight(((6 - len + 1) / 2) + 1);
            }
            return text;
        }

    }
}
