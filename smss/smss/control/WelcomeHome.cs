using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smss.Connection;
using smss.model;

namespace smss.control
{
    public partial class WelcomeHome : UserControl
    {
        public delegate void Login(string staffcode, string name);
        public event Login LoginEvent;
        public WelcomeHome()
        {
            InitializeComponent();
        }

        private void WelcomeHome_Load(object sender, EventArgs e)
        {
            Width = 400;
            Height = 240;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTK.Text))
            {
                error.SetError(txtTK, "Chưa nhập tài khoản");
                return;
            }
            else if (String.IsNullOrEmpty(txtMK.Text))
            {
                error.Clear();
                error.SetError(txtMK, "Chưa nhập mật khẩu");
                return;
            }
            else
            {
                error.Clear();
            }
            staffObj obj = new staffObj();
            int ret = new Connection.Connection().Login(ref obj, txtTK.Text, txtMK.Text);
            if(ret >= 0)
            {
                if(!String.IsNullOrEmpty(obj.code))
                {
                    // đăng nhập thành công
                    Menu.StaffCode = obj.code;// code của người đăng nhập
                    LoginEvent(obj.code, obj.name);
                }
                else
                {
                    MessageBox.Show("Sai tài khoản mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // sai tài khoản mật khẩu
                }
            }
            else
            {
                // có lỗi truy cập dữ liệu
                MessageBox.Show("Lỗi đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
