﻿using System;
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
        readonly control.Grade _grade = new control.Grade();
        readonly control.Class _class = new control.Class();
        readonly control.Student _student = new control.Student();

        public Home()
        {
            InitializeComponent();
        }
        private void ChangeTab(int tabID)
        {
            Controls.Remove(_grade);
            Controls.Remove(_class);
            Controls.Remove(_student);
            if (tabID == 1)
            {
                Controls.Add(_grade);
                _grade.Location = new Point(0, 67);
                _grade.Show();
            }
            else if(tabID == 2)
            {
                Controls.Add(_class);
                _class.Location = new Point(0, 67);
                _class.Show();
            }
            else if(tabID == 3)
            {
                Controls.Add(_student);
                _student.Location = new Point(0, 67);
                _student.Show();
            }
        }
        private void loginControl_LoginEvent(string staffcode, string name)
        {
            // Đã đăng nhập thành công
            Remove();
            Controls.Add(_menu);
            Controls.Add(_grade); // đăng nhập xong chuyển vào trang khóa học
            _menu.staffcode = staffcode;
            _menu.Hello(name);
            _menu.Location = new Point(0, 0);
            _grade.Location = new Point(0, 67);
            _menu.Show();
            _grade.Show();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            // bắt các sự kiện từ các userControl con
            _wc.LoginEvent += loginControl_LoginEvent;// click đăng nhập
            _menu.Change += ChangeTab; // click chuyển tab
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
            Controls.Remove(_grade);
            Controls.Remove(_class);
            Controls.Remove(_student);
        }
    }
}
