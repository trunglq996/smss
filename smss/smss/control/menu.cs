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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        public delegate void ChangeTab(int tabID);
        public event ChangeTab Change;
        public static string StaffCode;
        public void Hello(string name)
        {
            lbHello.Text = "[" + name + "]";
        }
        private void menu_Load(object sender, EventArgs e)
        {
            Width = 900;
            Height = 65;
            btnStudent.Enabled = false;
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            btnStudent.Enabled = false;
            Change(1);// gọi đến sự kiện ChangeTab ở Home.cs
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            btnStudent.Enabled = true;
            if (!String.IsNullOrEmpty(Grade.code))
                Change(2); //gọi đến sự kiện ChangeTab ở Home.cs
            else
                MessageBox.Show("Chưa chọn khóa học nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Class.code))
                Change(3); //gọi đến sự kiện ChangeTab ở Home.cs
            else
                MessageBox.Show("Chưa chọn lớp học nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
