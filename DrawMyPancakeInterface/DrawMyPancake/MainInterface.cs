using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using EV3WifiLib;

namespace DrawMyPancake
{
    public partial class mainForm : Form
    {
        #region paintVariables

        Graphics g; //defines an incredible number of methods for drawing and manipulating gaphic objects.
        bool drawFlag = false; //check mouse down
        int xDown, yDown, xUp, yUp, //track the screen positions
            LLint, TTint, WWint, HHint = 0; //define the bounding rectangle for all of the geometric shapes 
        int intBrushSize = 20;
        int selectedPreset = 1;
        Bitmap bmpPic;
        Color clrSelected = Color.Black;
        private Instruction ev3Instuction;
        private ArrayList ev3InstuctionList;

        #endregion

        TextInputDialog inputBox;

        #region ev3 Variables
        private string ipEV3 = "192.168.43.153";
        // myEV3 is used to communicate with the LEGO EV3.
        private EV3Wifi myEV3;

        // You need a timer to receive messages from the EV3
        // at specified time intervals.
        private Timer messageReceiveTimer;
        #endregion

        public mainForm()
        {
            InitializeComponent();
            #region Lego EV3 Stuff
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
            #endregion

            #region Drawing prep

            bmpPic = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(bmpPic);
            g.Clear(Color.White);
            picCanvas.Image = bmpPic;
            #endregion

        }

        #region ev3Connectionmanagement
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
        #endregion

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

        #region Presets
        private void btnPresetFreeDraw_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            selectedPreset = 1;
            picCanvas.BackColor = Color.White;
        }

        private void btnPresetSquare_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            selectedPreset = 2;
            picCanvas.BackColor = Color.DarkOliveGreen;
        }

        private void btnPresetCircle_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            selectedPreset = 3;
            picCanvas.BackColor = Color.Brown;
        }

        private void btnPresetTriangle_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            selectedPreset = 4;
            picCanvas.BackColor = Color.White;
        }

        private void btnPresetHeart_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            selectedPreset = 5;
            picCanvas.BackColor = Color.Red;
        }

        private void btnPresetSpiral_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            selectedPreset = 6;
            picCanvas.BackColor = Color.Blue;
        }

        private void btnPresetText_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            selectedPreset = 7;
            //inputBox = new TextInputDialog();
            //inputBox.Text = "Vul tekst in";
            //inputBox.Show();
            //inputBox.btnSubmit.Click += new EventHandler(writeText);
        }

        private void writeText(object sender, EventArgs e)
        {
            //lblTextOverlay.Visible = true;
            //lblTextOverlay.Text = inputBox.tbInput.Text;
            inputBox.Close();
        }
        #endregion


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

        private void mainForm_ResizeEnd(object sender, EventArgs e)
        {
            //dit is voor canvas
        }

        #region Button clicks
            
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

        private void tbText_TextChanged(object sender, EventArgs e)
        {
            tbText.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdSavePic.Filter = "bitmap |*.bmp";
            if (sfdSavePic.ShowDialog() == DialogResult.OK)
            {
                picCanvas.Image.Save(sfdSavePic.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                MessageBox.Show("file saved.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ofdLoadPic.Filter = "bitmap |*.bmp";
            ofdLoadPic.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            g = Graphics.FromImage(picCanvas.Image);
            g.Clear(Color.White);
            picCanvas.Refresh();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
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
                        //methode voor analyse();
                        myEV3.SendMessage("FreeDraw", ev3String);  // "0" means EV3_INBOX0 
                        break;
                }

            }
        }

        #endregion
        #region Drawing canvas
        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawFlag = true;
            xDown = e.X;
            yDown = e.Y;
            ev3Instuction = new Instruction {
                instructionString = e.X.ToString("D4") + e.Y.ToString("D4") + "F"
            };
            g = Graphics.FromImage(picCanvas.Image);
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawFlag == true && selectedPreset == 1)
            {
                xDown = e.X;
                yDown = e.Y;
                ev3Instuction.AddCoordinate(xDown, xDown);
                g.FillEllipse(new SolidBrush(clrSelected), xDown, yDown, intBrushSize, intBrushSize);
                g.Save();
                picCanvas.Image = bmpPic;
                picCanvas.Refresh();
            }
        }


        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            ev3Instuction.OptimizePath();
            ev3Instuction.ToInstructionString();
            ev3Instuction.instructionString += e.X.ToString("D4") + e.Y.ToString("D4") + "F";
            ev3InstuctionList.Add(ev3Instuction);
            drawFlag = false;
            g.Dispose();
            picCanvas.Refresh();
        }
        #endregion

    }
}
