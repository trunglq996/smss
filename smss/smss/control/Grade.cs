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

        private void ViewData_Load(object sender, EventArgs e)
        {
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

    }
}
