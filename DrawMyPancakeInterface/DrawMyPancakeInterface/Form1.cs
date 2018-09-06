using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                //TCP IP Test
using System.Net;               //TCP IP Test
using System.Net.Sockets;       //TCP IP Test

namespace DrawMyPancakeInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnectTest_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient rbtC = new TcpClient();
                tbStatus.Text = "connecting....\n";
                IPAddress ip = new IPAddress(long.Parse(tbAdress.Text));            //pak de textbox ip adres
                rbtC.Connect(ip, Convert.ToInt32(tbPort.Text));                     //connect met pcb/ip (ip)
                tbStatus.Text = "Connected\n";

                Console.WriteLine("type");
                string a = Console.ReadLine();
                Stream stm = rbtC.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(a);
                tbStatus.Text = "Transmitting...\n";

                stm.Write(ba, 0, ba.Length);

                byte[] bb = new byte[100];
                int k = stm.Read(bb, 0, 100);

                for (int i = 0; i < k; i++)
                {
                    tbStatus.Text = Convert.ToString(bb[i]);
                }
                rbtC.Close();
            }
            catch (Exception potato)
            {
                tbStatus.Text = "Error..." + potato.StackTrace;
            }
        }
    }
}
