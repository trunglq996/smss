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
            dataStudent.AllowUserToAddRows = false;

            Width = 900;
            Height = 390;
            groupUpdate.Width = 250;
            groupUpdate.Height = 380;

            groupData.Left = 255;
            groupData.Height = 380;
            groupData.Width = 630;

            groupData2.Height = 345;
            groupData2.Width = 620;

            //groupButton.Width = 250;
            //groupButton.Height = 57;
            //groupButton.Top = 325;
            LoadData();
        }

        public void LoadData()
        {
            DataSet ds = new DataSet();
            string sql = "select code,photo,codeview N'Mã SV',name N'Tên SV',birthday N'Ngày sinh',note N'Ghi chú' from student";
            int ret = new Connection.Connection().GetDataByQuery(ref ds, "student", sql);
            if (ret >= 0)
            {
                dataStudent.DataSource = ds.Tables["student"];
                dataStudent.Columns[0].Visible = false;
                dataStudent.Columns[1].Visible = false;
                SetValue();
            }
            else
            {
                MessageBox.Show("Lỗi lấy dữ liệu sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SetValue()
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void dataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
