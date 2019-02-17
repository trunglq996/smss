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

        public static string code;
        public static string name;
        private void Class_Load(object sender, EventArgs e)
        {
            
            dataClass.ReadOnly = true;
            dataClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            Width = 900;
            Height = 390;
            groupUpdate.Width = 250;
            groupUpdate.Height = 320;
            groupUpdate.Enabled = false;

            groupData.Left = 255;
            groupData.Height = 380;
            groupData.Width = 630;

            groupButton.Width = 250;
            groupButton.Height = 57;
            groupButton.Top = 325;
            groupUpdate.Text = "Cập nhật lớp học (" + Grade.name + ")";
            groupData.Text = "Danh mục lớp học (" + Grade.name + ")";
            loadData();
        }

        private void dataClass_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dataClass.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1 || dataClass.RowCount == 1)
            {
                code = name = "";
            }
            else
            {
                var row = dataClass.SelectedRows[0];
                code = row.Cells["code"].Value.ToString();
                name = row.Cells["name"].Value.ToString();
                setValue();
            }

        }
        public void setValue()
        {
            var row = dataClass.SelectedRows[0];
            txtMa.Text = row.Cells["code"].Value.ToString();
            txtName.Text = row.Cells["name"].Value.ToString();
            txtNote.Text = row.Cells["note"].Value.ToString();
        }
        public void loadData()
        {
            DataSet ds = new DataSet();
            string sql = "select * from class where gradecode = '" + control.Grade.code + "'";
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

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
