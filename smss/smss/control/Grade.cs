using smss.model;
using smss.Connection;
using System;
using System.Data;
using System.Windows.Forms;


namespace smss.control
{
    public partial class Grade : UserControl
    {
        public Grade()
        {
            InitializeComponent();
        }
        public static string code;
        public static string name;
        private string _procName;
        private void ViewData_Load(object sender, EventArgs e)
        {
            txtYearIn.Text = "";
            txtYearOut.Text = "";
            dataGrade.ReadOnly = true;
            dataGrade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGrade.AllowUserToAddRows = false;
            dataGrade.MultiSelect = false;

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

            LoadData(code);
        }

        public void SetValue()
        {
            if (dataGrade.SelectedRows.Count == 0)
            {
                code = name = "";
                return;
            }
            var row = dataGrade.SelectedRows[0];
            code = row.Cells[0].Value.ToString();
            name = row.Cells[2].Value.ToString();
            txtMa.Text = row.Cells[1].Value.ToString();
            txtName.Text = row.Cells[2].Value.ToString();
            txtYearIn.Text = row.Cells[3].Value.ToString();
            txtYearOut.Text = row.Cells[4].Value.ToString();
            txtNote.Text = row.Cells[5].Value.ToString();
        }
        public void Save(string procName)
        {
            string newcode = code;
            if (procName == "InsertGrade")
            {
                newcode = new Connection.Connection().GenNextCode("grade");
            }
            gradeObj obj = new gradeObj() {
                code = newcode,
                codeview = txtMa.Text,
                name = txtName.Text,
                yearin = int.Parse(txtYearIn.Text),
                yearout = int.Parse(txtYearOut.Text),
                note = txtNote.Text
            };
            int ret = new Connection.Connection().Grade(obj, procName);
            if(ret > 0)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(code))
            {

                DialogResult result = MessageBox.Show("Bản ghi sẽ mất vĩnh viễn?", "Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int ret = new Connection.Connection().DoSql("delete from grade where code = '" + code + "'");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _procName = "UpdateGrade";
            groupButton.Enabled = false;
            groupUpdate.Enabled = true;
            groupData.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtName.Text = "";
            txtYearIn.Text = "";
            txtYearOut.Text = "";
            txtNote.Text = "";
            _procName = "InsertGrade";
            groupButton.Enabled = false;
            groupUpdate.Enabled = true;
            groupData.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Chưa nhập mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtYearIn.Text))
            {
                MessageBox.Show("Chưa nhập năm vào trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(txtYearOut.Text))
            {
                MessageBox.Show("Chưa nhập năm ra trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Save(_procName);
        }
        public void LoadData(string selectcode)
        {
            DataSet ds = new DataSet();
            string sql = "select code, codeview N'Mã',name N'Tên',yearin N'Năm vào',yearout N'Năm ra',note N'Ghi chú' from grade";
            int ret = new Connection.Connection().GetDataByQuery(ref ds, "grade", sql);
            if (ret >= 0)
            {
                dataGrade.DataSource = ds.Tables["grade"];
                dataGrade.Columns[0].Visible = false;
                if (!String.IsNullOrEmpty(selectcode))
                {
                    // chọn vào bản ghi mong muốn
                    for (int i = 0; i < dataGrade.RowCount; i++)
                    {
                        if (dataGrade.Rows[i].Cells["code"].Value.ToString().Equals(selectcode))
                        {
                            dataGrade.Rows[i].Selected = true;
                            dataGrade.CurrentCell = dataGrade.Rows[i].Cells[1];
                            break;
                        }
                    }
                }
                SetValue();
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetValue();
            groupButton.Enabled = true;
            groupUpdate.Enabled = false;
            groupData.Enabled = true;
        }

        private void dataGrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetValue();
        }
    }
}
