﻿using System;
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
    }
}
