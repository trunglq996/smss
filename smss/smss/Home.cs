using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smss
{
    public partial class Home : Form
    {
        
        readonly control.WelcomeHome _wc = new control.WelcomeHome();
        readonly control.Menu _menu = new control.Menu();
        readonly control.ViewData _data = new control.ViewData();

        public Home()
        {
            InitializeComponent();
        }

        private void loginControl_LoginEvent(string staffcode, string name)
        {
            // Đã đăng nhập thành công
            Remove();
            Controls.Add(_menu);
            Controls.Add(_data);
            _menu.staffcode = staffcode;
            _menu.Hello(name);
            _menu.Location = new Point(0, 0);
            _data.Location = new Point(0, 67);
            _menu.Show();
            _data.Show();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            _wc.LoginEvent += loginControl_LoginEvent;
            // nếu đăng nhập đúng thì quay trở lại form chính để chuyển usercontrol khác
            Width = 900;
            Height = 500;
            Controls.Add(_wc);
            _wc.Location = new Point(250, 130);
            _wc.Show();
        }
        public void Remove()
        {
            Controls.Remove(_wc);
            Controls.Remove(_menu);
        }
    }
}
