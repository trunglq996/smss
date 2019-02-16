using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smss.control
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        public delegate void ChangeTab(int tabID);
        public event ChangeTab Change;
        public string staffcode;
        public void Hello(string name)
        {
            lbHello.Text = "[" + name + "]";
        }
        private void menu_Load(object sender, EventArgs e)
        {
            Width = 900;
            Height = 65;
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            Change(1);// gọi đến sự kiện ChangeTab ở Home.cs
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Change(2); //gọi đến sự kiện ChangeTab ở Home.cs
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Change(3); //gọi đến sự kiện ChangeTab ở Home.cs
        }
    }
}
