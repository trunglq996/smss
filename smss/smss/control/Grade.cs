using smss.model;
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
            if (rowsCount == 0 || rowsCount > 1 || dataGrade.RowCount == 1) return;
            var row = dataGrade.SelectedRows[0];
            if (row == null) return;
            code = row.Cells["code"].Value.ToString();
            name = row.Cells["name"].Value.ToString();
        }
    }
}
