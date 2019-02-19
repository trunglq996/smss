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
        control.Grade _grade = new control.Grade();
        control.Class _class; // khi nào dùng sẽ khai báo
        control.Student _student; // khi nào dùng sẽ khai báo
        control.SqlStudent _insertStudent;

        public Home()
        {
            InitializeComponent();
        }
        private void ChangeTab(int tabID)
        {
            Remove();
            if (tabID == 1)
            {
                _grade = new control.Grade();
                Controls.Add(_grade);
                _grade.Location = new Point(0, 67);
            }
            else if(tabID == 2)
            {
                _class = new control.Class(); // tạo lại userControl mới để chạy lại loadData theo gradecode
                Controls.Add(_class);
                _class.Location = new Point(0, 67);
            }
            else if(tabID == 3)
            {
                _student = new control.Student(); // tạo lại userControl mới để chạy lại loadData theo classcode
                _student.update += UpdateStudent; 
                Controls.Add(_student);
                _student.Location = new Point(0, 67);
            }
        }
        private void UpdateStudent(string code)
        {
            if (!String.IsNullOrEmpty(code))
            {
                // thực hiện mở form cập nhật
            }
            else
            {
                _insertStudent = new control.SqlStudent();
                Width = _insertStudent.Width + 15;
                Height = _insertStudent.Height + 35;
                Controls.Remove(_menu);
                Controls.Remove(_student);
                Controls.Add(_insertStudent);
                // thực hiện mở form  thêm mới
            }
        }
        private void loginControl_LoginEvent(string staffcode, string name)
        {
            // Đã đăng nhập thành công

            Controls.Remove(_wc);
            Controls.Add(_menu);
            Controls.Add(_grade); // đăng nhập xong chuyển vào trang khóa học
            _menu.Hello(name);
            _menu.Location = new Point(0, 0);
            _grade.Location = new Point(0, 67);
        }
        private void Home_Load(object sender, EventArgs e)
        {
            // bắt các sự kiện từ các userControl con
            _wc.LoginEvent += loginControl_LoginEvent;// click đăng nhập
            _menu.Change += ChangeTab; // click chuyển tab
            Width = 905;
            Height = 500;
            Controls.Add(_wc);
            _wc.Location = new Point(250, 130);
        }
        public void Remove()
        {
            Controls.Remove(_grade);
            Controls.Remove(_class);
            Controls.Remove(_student);
        }
    }
}
