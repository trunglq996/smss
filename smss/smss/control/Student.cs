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
    public partial class Student : UserControl
    {
        public Student()
        {
            InitializeComponent();
        }
        private void Student_Load(object sender, EventArgs e)
        {
            dataStudent.ReadOnly = true;
            dataStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataStudent.MultiSelect = false;

            Width = 900;
            Height = 390;
            DataSet ds = new DataSet();
            string sql = "select * from student";
            int ret = new Connection.Connection().GetDataByQuery(ref ds, "student", sql);
            if (ret >= 0)
            {
                dataStudent.DataSource = ds.Tables["student"];
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
