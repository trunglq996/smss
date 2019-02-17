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
            dataClass.ReadOnly = true;
            dataClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void dataClass_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dataClass.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1 || dataClass.RowCount == 1) return;
            var row = dataClass.SelectedRows[0];
            if (row == null) return;
            code = row.Cells["code"].Value.ToString();
            name = row.Cells["name"].Value.ToString();
        }
    }
}
