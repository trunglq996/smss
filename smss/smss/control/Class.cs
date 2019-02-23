using System;
using System.Data;
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
        private string _procName;
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
            LoadData(code);
        }

        public void SetValue()
        {
            if (dataClass.SelectedRows.Count == 0)
            {
                code = name = "";
                return;
            }
            var row = dataClass.SelectedRows[0];

            code = row.Cells[0].Value.ToString();
            name = row.Cells[2].Value.ToString();

            txtMa.Text = row.Cells[1].Value.ToString();
            txtName.Text = row.Cells[2].Value.ToString();
            txtNote.Text = row.Cells[3].Value.ToString();
        }
        public void LoadData(string selectcode)
        {
            if(String.IsNullOrEmpty(Grade.code))
            {
                MessageBox.Show("Chưa chọn khóa học nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataSet ds = new DataSet();
            string sql = "select code,codeview N'Mã',name N'Tên',note N'Ghi chú' from class where gradecode = '" + Grade.code + "'";
            int ret = new Connection.Connection().GetDataByQuery(ref ds, "class", sql);
            if (ret >= 0)
            {
                dataClass.DataSource = ds.Tables["class"];
                dataClass.Columns[0].Visible = false;
                if (!String.IsNullOrEmpty(selectcode))
                {
                    // chọn vào bản ghi mong muốn
                    for (int i = 0; i < dataClass.RowCount; i++)
                    {
                        if (dataClass.Rows[i].Cells["code"].Value.ToString().Equals(selectcode))
                        {
                            dataClass.Rows[i].Selected = true;
                            dataClass.CurrentCell = dataClass.Rows[i].Cells[1];
                            break;
                        }
                    }
                }
                SetValue();
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
            _procName = "InsertClass";
            groupButton.Enabled = false;
            groupUpdate.Enabled = true;
            groupData.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _procName = "UpdateClass";
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
                        LoadData("");
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
            Save(_procName);
        }
        public void Save(string procName)
        {
            string newcode = code;
            if (procName == "InsertClass")
            {
                newcode = new Connection.Connection().GenNextCode("class");
            }
            classObj obj = new classObj()
            {
                code = newcode,
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
                groupButton.Enabled = true;
                groupUpdate.Enabled = false;
                groupData.Enabled = true;
                LoadData(newcode);
            }
            else
            {
                MessageBox.Show("Đã có lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetValue();
            groupButton.Enabled = true;
            groupUpdate.Enabled = false;
            groupData.Enabled = true;
        }

        private void dataClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetValue();
        }
    }
}
