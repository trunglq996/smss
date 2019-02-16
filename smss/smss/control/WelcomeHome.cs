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

namespace smss.control
{
    public partial class WelcomeHome : UserControl
    {
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
            string sql = "";
            DataSet ds = new DataSet();
            int ret = new Connection.Connection().GetDataByQuery(ref ds, "staff", sql);
            if(ret >= 0)
            {
                if(ds.Tables["staff"].Rows.Count > 0)
                {
                    // đăng nhập thành công
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
