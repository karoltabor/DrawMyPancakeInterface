using System;
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

namespace PanelTesting
{
    public partial class mainForm : Form
    {
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

            if (!IPAddress.TryParse(ipEV3, out IPAddress address))
            {
                MessageBox.Show("Fill in valid IP address of EV3");
            }
            else if (myEV3.Connect("1234", ipEV3) == true)
            {
                messageReceiveTimer.Start();
            }
            else
            {
                myEV3.Disconnect();
                MessageBox.Show("Failed to connect to EV3 with IP address " + ipEV3);
            }
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

        private void btnPencil_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                myEV3.SendMessage("Rond", "0");  // "0" means EV3_INBOX0
            }
        }
    }
}
