using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawMyPancake
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void lblBrushColor_Click(object sender, EventArgs e)
        {
            clrBrushColor.ShowDialog();
            lblBrushColor.BackColor = clrBrushColor.Color;
        }
    }
}
