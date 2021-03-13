using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace autocklikker_Arthur
{
    public partial class Arthur_clicker : Form
    {
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public Arthur_clicker()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
           
            try
            {
                timer1.Enabled = true;
                int interval = int.Parse(txttijd.Text);
                timer1.Interval = interval * 1000;
            }
            catch (Exception)
            {
                timer1.Enabled = false;
                MessageBox.Show("geen correcte input text/interval", "foutje?");

                throw;
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            SendKeys.SendWait(txttext.Text);
            SendKeys.Send("{ ESC }");
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txttijd.Text = "2";
        }
    }
}
