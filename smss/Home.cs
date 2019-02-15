using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smss.classKN;

namespace smss
{
    public partial class Home : Form
    {
        control.WelcomeHome wc = new control.WelcomeHome();
        public Home()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = 1000;
            panel1.Height = 80;
            panel2.Height = 520;
            panel2.Width = 150;
            btnLogo.Width = 80;
            btnLogo.Height = 80;
            Width = 1000;
            Height = 600;
            Controls.Add(wc);
            wc.Location = new Point(400,200);
            wc.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
