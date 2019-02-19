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
        private string procName;
        private void Class_Load(object sender, EventArgs e)
        {
            
            dataClass.ReadOnly = true;
            dataClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataClass.MultiSelect = false;
            dataClass.AllowUserToAddRows = false;

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
            setValue();
        }

        public void setValue()
        {
            if (dataClass.SelectedRows.Count == 0)
            {
                return;
            }
            var row = dataClass.SelectedRows[0];

            code = row.Cells["code"].Value.ToString();
            name = row.Cells["name"].Value.ToString();

            txtMa.Text = row.Cells["codeview"].Value.ToString();
            txtName.Text = row.Cells["name"].Value.ToString();
            txtNote.Text = row.Cells["note"].Value.ToString();
        }
        public void loadData()
        {
            if(String.IsNullOrEmpty(Grade.code))
            {
                MessageBox.Show("Chưa chọn khóa học nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataSet ds = new DataSet();
            string sql = "select code,name,note,codeview from class where gradecode = '" + Grade.code + "'";
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
            txtMa.Text = "";
            txtName.Text = "";
            txtNote.Text = "";
            procName = "InsertClass";
            groupButton.Enabled = false;
            groupUpdate.Enabled = true;
            groupData.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            procName = "UpdateClass";
            groupButton.Enabled = false;
            groupUpdate.Enabled = true;
            groupData.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(code))
            {

                DialogResult result = MessageBox.Show("Bản ghi sẽ mất vĩnh viễn?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int ret = new Connection.Connection().DoSql("delete from class where code = '" + code + "'");
                    if (ret >= 0)
                    {
                        MessageBox.Show("Success!", "Thông báo");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Chưa nhập mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Save(procName) >= 0)
            {
                groupButton.Enabled = true;
                groupUpdate.Enabled = false;
                groupData.Enabled = true;
                loadData();
            }
        }
        public int Save(string procName)
        {
            classObj obj = new classObj()
            {
                code = code,
                codeview = txtMa.Text,
                name = txtName.Text,
                staffcode = Menu.StaffCode,
                gradecode = Grade.code,
                note = txtNote.Text
            };
            int ret = new Connection.Connection().Class(obj, procName);
            if (ret > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đã có lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ret;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            setValue();
            groupButton.Enabled = true;
            groupUpdate.Enabled = false;
            groupData.Enabled = true;
        }

        private void dataClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setValue();
        }
    }
}
