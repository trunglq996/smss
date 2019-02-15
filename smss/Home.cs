using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smss
{
    public partial class Home : Form
    {
        readonly control.WelcomeHome _wc = new control.WelcomeHome();
        public Home()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 1000;
            Height = 600;
            Controls.Add(_wc);
            _wc.Location = new Point(400,200);
            _wc.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
