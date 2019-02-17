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
        public string code;
        public string name;
        private void ViewData_Load(object sender, EventArgs e)
        {
            dataGrade.ReadOnly = true;
            dataGrade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            Width = 900;
            Height = 390;
            groupUpdate.Width = 250;
            groupUpdate.Height = 380;

            groupData.Left = 255;
            groupData.Height = 380;
            groupData.Width = 630;
            DataSet ds = new DataSet();
            string sql = "select * from grade";
            int ret = new Connection.Connection().GetDataByQuery(ref ds, "grade", sql);
            if(ret >= 0)
            {
                dataGrade.DataSource = ds.Tables["grade"];
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGrade_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dataGrade.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1 || dataGrade.RowCount == 1) {
                code = name = "";
                return;
            };
            var row = dataGrade.SelectedRows[0];
            code = row.Cells["code"].Value.ToString();
            name = row.Cells["name"].Value.ToString();
            setValue();
        }
        public void setValue()
        {
            var row = dataGrade.SelectedRows[0];
            txtMa.Text = row.Cells["code"].Value.ToString();
            txtName.Text = row.Cells["name"].Value.ToString();
            txtYearIn.Text = row.Cells["yearin"].Value.ToString();
            txtYearOut.Text = row.Cells["yearout"].Value.ToString();
            txtNote.Text = row.Cells["note"].Value.ToString();
        }
        public void Save(string procName)
        {
            gradeObj obj = new gradeObj() {
                code = txtMa.Text,
                name = txtName.Text,
                yearin = int.Parse(txtYearIn.Text.Trim()),
                yearout = int.Parse(txtYearOut.Text.Trim()),
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
        }
    }
}
