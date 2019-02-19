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
    public partial class SqlStudent : UserControl
    {
        public SqlStudent()
        {
            InitializeComponent();
        }

        private void SqlStudent_Load(object sender, EventArgs e)
        {
            label1.Text = Grade.name + " (" + Class.name + ")";
        }
    }
}
