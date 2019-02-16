using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smss.Connection;

namespace smss.control
{
    public partial class WelcomeHome : UserControl
    {
        public WelcomeHome()
        {
            InitializeComponent();
        }

        private void WelcomeHome_Load(object sender, EventArgs e)
        {
            Width = 400;
            Height = 240;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            int ret = new Db().GetDataByQuery(ref ds, "staff", "select * from staff");
            if(ret >= 0)
            {

            }
        }
    }
}
