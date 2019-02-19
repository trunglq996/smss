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
    public partial class Student : UserControl
    {
        public Student()
        {
            InitializeComponent();
        }
        public delegate void UpdateStudent(string code);
        public event UpdateStudent update;
        private string code;
        private string urlUser = @"C:\Users\quang\Documents\GitHub\smss\smss\smss\image\user.png";
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
            txtGrade.Text = "Khóa: " + Grade.name;
            txtClass.Text = "Lớp: " + Class.name;
            txtGrade.Width = 150;
            txtClass.Width = 150;
            txtGrade.Left = 345;
            txtClass.Left = 475;

            pictureBox1.Load(urlUser);
            LoadData();
        }

        public void LoadData()
        {
            DataSet ds = new DataSet();
            string sql = "select code,photo,codeview N'Mã SV',name N'Tên SV',birthday N'Ngày sinh',note N'Ghi chú' from student where gradecode = '" + Grade.code + "' and classcode = '" + Class.code + "'";
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
            if (dataStudent.SelectedRows.Count == 0)
            {
                code = "";
                pictureBox1.Load(urlUser);
                btnEdit.Visible = false;
                btnDelete.Visible = false;
               // groupUpdate.Visible = false;
                return;
            }
            var row = dataStudent.SelectedRows[0];
            // lb
            code = row.Cells[0].Value.ToString();
            lbCodeView.Text = "Mã SV: " + row.Cells[2].Value.ToString();
            lbName.Text = "Tên SV: " + row.Cells[3].Value.ToString();
            if(!String.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                pictureBox1.Load(row.Cells[1].Value.ToString());
            else
            {
                pictureBox1.Load(urlUser);
            }

            btnEdit.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            update("");
        }

        private void dataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetValue();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            update(code);
        }
    }
}
