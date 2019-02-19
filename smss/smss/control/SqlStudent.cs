using System;
using System.Windows.Forms;
using smss.Connection;
using smss.model;

namespace smss.control
{
    public partial class SqlStudent : UserControl
    {
        public SqlStudent()
        {
            InitializeComponent();
        }
        public delegate void ReturnHome(bool kq);
        public event ReturnHome click;
        private string url = "";
        public static string code;
        private void SqlStudent_Load(object sender, EventArgs e)
        {
            label1.Text = Grade.name + " (" + Class.name + ")";
            if (!String.IsNullOrEmpty(code))
            {

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            click(false);
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            int ret = 0;
            if (!String.IsNullOrEmpty(code))
            {
                studentObj obj = new studentObj()
                {
                    code = code,
                    photo = url,
                    codeview = txtCodeview.Text,
                    name = txtName.Text,
                    note = txtNote.Text,
                    birthday = dateTimePicker1.Value,
                    gradecode = Grade.code,
                    classcode = Class.code

                };
                ret = new Connection.Connection().Student(obj, "UpdateStudent");
            }
            else
            {
                studentObj obj = new studentObj()
                {
                    code = new Connection.Connection().GenNextCode("student"),
                    photo = url,
                    codeview = txtCodeview.Text,
                    name = txtName.Text,
                    note = txtNote.Text,
                    birthday = dateTimePicker1.Value,
                    gradecode = Grade.code,
                    classcode = Class.code
                };
                ret = new Connection.Connection().Student(obj, "InsertStudent");
            }
            if(ret >= 0)
            {
                MessageBox.Show("Đã cập nhật bản ghi!", "Thông báo");
                click(true);
            }
            else
            {
                MessageBox.Show("Lỗi ghi dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadFileSteam = new OpenFileDialog();

            uploadFileSteam.InitialDirectory = "c:\\";
            uploadFileSteam.Filter = "Ảnh|*.jpg;*.png";
            uploadFileSteam.FilterIndex = 2;

            if (uploadFileSteam.ShowDialog() == DialogResult.OK)
            {
                url = uploadFileSteam.FileName;
                pictureBox1.Load(uploadFileSteam.FileName);
            }
        }
    }
}
