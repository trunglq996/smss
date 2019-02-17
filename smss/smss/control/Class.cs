using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smss.model;

namespace smss.control
{
    public partial class Class : UserControl
    {
        public Class()
        {
            InitializeComponent();
        }
        public string code;
        public string name;
        private void Class_Load(object sender, EventArgs e)
        {
            Width = 900;
            Height = 390;
            DataSet ds = new DataSet();
            string sql = "select * from class";
            int ret = new Connection.Connection().GetDataByQuery(ref ds, "class", sql);
            if (ret >= 0)
            {
                dataClass.DataSource = ds.Tables["class"];
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
