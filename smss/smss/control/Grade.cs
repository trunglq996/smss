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
        private string procName;
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

            loadData();
        }

        public void setValue()
        {
            if (dataGrade.SelectedRows.Count == 0)
            {
                return;
            }
            var row = dataGrade.SelectedRows[0];
            code = row.Cells["code"].Value.ToString();
            name = row.Cells["name"].Value.ToString();
            txtMa.Text = row.Cells["codeview"].Value.ToString();
            txtName.Text = row.Cells["name"].Value.ToString();
            txtYearIn.Text = row.Cells["yearin"].Value.ToString();
            txtYearOut.Text = row.Cells["yearout"].Value.ToString();
            txtNote.Text = row.Cells["note"].Value.ToString();
        }
        public int Save(string procName)
        {
            gradeObj obj = new gradeObj() {
                code = code,
                codeview = txtMa.Text,
                name = txtName.Text,
                yearin = int.Parse(txtYearIn.Text.ToString()),
                yearout = int.Parse(txtYearOut.Text.ToString()),
                note = txtNote.Text
            };
            int ret = new Connection.Connection().Grade(obj, procName);
            if(ret > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đã có lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ret;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            procName = "UpdateGrade";
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
            procName = "InsertGrade";
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
            if (Save(procName) >=0)
            {
                groupButton.Enabled = true;
                groupUpdate.Enabled = false;
                groupData.Enabled = true;
                loadData();
            }
        }
        public void loadData()
        {
            DataSet ds = new DataSet();
            string sql = "select * from grade";
            int ret = new Connection.Connection().GetDataByQuery(ref ds, "grade", sql);
            if (ret >= 0)
            {
                dataGrade.DataSource = ds.Tables["grade"];
                setValue();
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setValue();
            groupButton.Enabled = true;
            groupUpdate.Enabled = false;
            groupData.Enabled = true;
        }

        private void dataGrade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setValue();
        }
    }
}
