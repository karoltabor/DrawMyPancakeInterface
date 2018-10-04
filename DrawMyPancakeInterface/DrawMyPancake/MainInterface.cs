﻿using EV3WifiLib;
using PanelTesting.Properties;
using System;
using System.Collections;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace DrawMyPancake {
    public partial class mainForm : Form
    {
        Graphics g;                                     //defines methods for drawing
        bool drawFlag = false;                          //check mouse down
        int xDown, yDown, xUp, yUp,                     //track the screen positions
            LLint, TTint, WWint, HHint = 0;             //define the bounding rectangle for all of the geometric shapes 
        int intBrushSize = 20;
        int selectedPreset = 1;
        Bitmap bmpPic;
        Color clrSelected = Color.Black;
        private Instruction ev3Instuction;                      
        private ArrayList ev3InstuctionList = new ArrayList();
        TextInputDialog inputBox;

        private string ipEV3 = "192.168.43.153";
        // myEV3 is used to communicate with the LEGO EV3.
        private EV3Wifi myEV3;

        // You need a timer to receive messages from the EV3
        // at specified time intervals.
        private Timer messageReceiveTimer;

        public mainForm()
        {
            InitializeComponent();
           
            // Create the Timer object and set it to generate a timer tick event 
            // every 100 milliseconds. The timer tick can be used to execute code at fixed intervals.
            messageReceiveTimer = new Timer();
            messageReceiveTimer.Interval = 100;

            // Set the "messageReadTimer_Tick" method as method that is executed when
            // a timer tick event occurs.
            // The "messageReadTimer_Tick" method is defined later in this code (search!).
            messageReceiveTimer.Tick += new System.EventHandler(messageReadTimer_Tick);

            // EV3: Create an EV3Wifi object which you can use to talk to the EV3.
            myEV3 = new EV3Wifi();
            Connect();
            

            
            bmpPic = Resources.DMP_Bitmap;
            g = Graphics.FromImage(bmpPic);
            picCanvas.Image = bmpPic;
            picCanvas.Width = bmpPic.Width;
            picCanvas.Height = bmpPic.Height;
            picCanvas.Location = new Point((pnlBitmap.Width / 2 - bmpPic.Width / 2), pbLogo.Height + ((pnlBitmap.Height - pbLogo.Height) / 2 - bmpPic.Height / 2));
            pnlAddTextBg.Location = new Point((pnlAddText.Width / 2 - pnlAddTextBg.Width / 2), ((pnlAddText.Height - pbLogo.Height) / 2 - pnlAddTextBg.Height / 2));
        }

        private void mainForm_Resize(object sender, EventArgs e) {
            picCanvas.Location = new Point((pnlBitmap.Width / 2 - bmpPic.Width / 2), pbLogo.Height + ((pnlBitmap.Height - pbLogo.Height) / 2 - bmpPic.Height / 2));
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected || true)
            {
                switch (selectedPreset)
                {
                    case 2:
                        myEV3.SendMessage("Square", "0");  // "0" means EV3_INBOX0
                        break;
                    case 3:
                        myEV3.SendMessage("Circle", "0");  // "0" means EV3_INBOX0
                        break;
                    case 4:
                        myEV3.SendMessage("Triangle", "0");  // "0" means EV3_INBOX0
                        break;
                    case 5:
                        myEV3.SendMessage("Heart", "0");  // "0" means EV3_INBOX0
                        break;
                    case 6:
                        myEV3.SendMessage("Spiral", "0");  // "0" means EV3_INBOX0
                        break;
                    case 7:
                        //myEV3.SendMessage("Text" + lblTextOverlay.Text, "0");
                        break;
                    default:
                        string ev3String = "";
                        foreach (Instruction instruction in ev3InstuctionList)
                        {
                            ev3String += instruction.instructionString;
                        }
                        Console.WriteLine(ev3String);
                        //methode voor analyse();
                        myEV3.SendMessage("FreeDraw", ev3String);  // "0" means EV3_INBOX0 
                        break;
                }

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void menuButton_MouseHover(object sender, EventArgs e) {
            pnlPresetsButtons.Visible = ((Button) sender).Name == "btnPreset" ? true : false;
        }

        private void btnPreset_Click(object sender, EventArgs e) {
            pnlAddText.Visible = false;
            pnlPresetsButtons.Visible = true;
            pnlBitmap.Visible = true;
        }
        private void btnPresetFreeDraw_Click(object sender, EventArgs e) {
            pnlAddText.Visible = false;
            pnlPresetsButtons.Visible = false;
            pnlBitmap.Visible = true;
            g = Graphics.FromImage(Resources.DMP_Bitmap);
            selectedPreset = 1;
        }

        private void btnPresetText_Click(object sender, EventArgs e) {
            pnlAddText.Visible = true;
            pnlPresetsButtons.Visible = false;
            pnlBitmap.Visible = false;
            pnlAddTextBg.Location = new Point((pnlAddText.Width / 2 - pnlAddTextBg.Width / 2), ((pnlAddText.Height - pbLogo.Height) / 2 - pnlAddTextBg.Height / 2));
            selectedPreset = 7;
            //inputBox = new TextInputDialog();
            //inputBox.Text = "Vul tekst in";
            //inputBox.Show();
            //inputBox.btnSubmit.Click += new EventHandler(writeText);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clearDrawing();
        }

        private void clearDrawing()
        {
            bmpPic = Resources.DMP_Bitmap;
            g = Graphics.FromImage(bmpPic);
            ev3InstuctionList.Clear();
            picCanvas.Image = bmpPic;
            picCanvas.Refresh();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            ofdLoadPic.Filter = "bitmap |*.bmp";
            ofdLoadPic.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            sfdSavePic.Filter = "bitmap |*.bmp";
            if(sfdSavePic.ShowDialog() == DialogResult.OK) {
                picCanvas.Image.Save(sfdSavePic.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                MessageBox.Show("file saved.");
            }
        }


        private void btnPresetSquare_Click(object sender, EventArgs e) {
            clearDrawing();
            selectedPreset = 2;
        }

        private void btnPresetCircle_Click(object sender, EventArgs e) {
            clearDrawing();
            selectedPreset = 3;
        }

        private void btnPresetTriangle_Click(object sender, EventArgs e) {
            clearDrawing();
            selectedPreset = 4;
        }

        private void btnPresetHeart_Click(object sender, EventArgs e) {
            clearDrawing();
            selectedPreset = 5;
        }

        private void btnPresetSpiral_Click(object sender, EventArgs e) {
            clearDrawing();
            selectedPreset = 6;
        }

        private void mnuSettingsConnectionConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void mnuSettingsConnectionChange_Click(object sender, EventArgs e)
        {
            inputBox = new TextInputDialog();
            inputBox.Text = "Vul IP in";
            inputBox.Show();
            inputBox.btnSubmit.Click += new EventHandler(changeIP);
        }

        private void changeIP(object sender, EventArgs e)
        {
            ipEV3 = inputBox.tbInput.Text;
            Connect();
            inputBox.Close();
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
        
        private void mnuSettingsSend_Click(object sender, EventArgs e)
        {
            inputBox = new TextInputDialog();
            inputBox.Text = "Vul IP in";
            inputBox.Show();
            inputBox.btnSubmit.Click += new EventHandler(sendCommand);
        }

        private void mnuSettingsConnectionDisconnect_Click(object sender, EventArgs e)
        {
            myEV3.Disconnect();
            MessageBox.Show("Disconnect");
        }

        // EV3: This method is the event handler for the messageReadTimer.
        //      The method is called when the timer has reached its 'interval' value.
        //      It receives a message from the EV3.
        //      Make sure that in the code below you comply with the message format sent by the EV3.
        //      The message itself is always one string.
        //      In the code below it is assumed that the message sent by the EV3 string consists of three substrings separated by a space:
        //      substring 0: message count
        //      substring 1: distance in cm
        //      substring 2: angle in degrees
        private void messageReadTimer_Tick(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                // EV3: ReceiveMessage is asynchronous so it actually gets the message read at the previous call to ReceiveMessage
                //      and it triggers reading the next message from the specified mailbox.
                //      Due to the simple implementation the message read does not contain information of the mailbox it came from.
                //      Therefore the advise is to only use one mailbox to read from: EV3_OUTBOX0.
                string strMessage = myEV3.ReceiveMessage("EV3_OUTBOX0");
            }
        }

        private void sendCommand(object sender, EventArgs e)
        {
            myEV3.SendMessage(inputBox.tbInput.Text, "0");
            inputBox.Close();
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
        
        
        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawFlag = true;
            xDown = e.X;
            yDown = e.Y;
            ev3Instuction = new Instruction {
                instructionString = Math.Abs(e.X-picCanvas.Width).ToString("D4") + e.Y.ToString("D4") + "F"
            };
            g = Graphics.FromImage(picCanvas.Image);
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawFlag == true && selectedPreset == 1)
            {
                xDown = e.X;
                yDown = e.Y;
                ev3Instuction.AddCoordinate(xDown, xDown, picCanvas.Width);
                g.FillEllipse(new SolidBrush(clrSelected), xDown, yDown, intBrushSize, intBrushSize);
                g.Save();
                picCanvas.Image = bmpPic;
                picCanvas.Refresh();
            }
        }


        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            ev3Instuction.ToInstructionString();
            ev3Instuction.instructionString += Math.Abs(e.X-picCanvas.Width).ToString("D4") + e.Y.ToString("D4") + "F";
            ev3InstuctionList.Add(ev3Instuction);
            drawFlag = false;
            g.Dispose();
            picCanvas.Refresh();
        }
        

    }
}
