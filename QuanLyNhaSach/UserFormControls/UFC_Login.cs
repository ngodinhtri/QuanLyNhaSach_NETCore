using ModelDatabase.EF;
using ModelHandle;
using QuanLyNhaSach.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.UserFormControls
{
    public partial class UFC_Login : UserControl
    {
        public UFC_Login()
        {
            InitializeComponent();
        }

        private readonly UserAccountHandler _userAccountHandler = new UserAccountHandler();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            //Kiểm tra rỗng
            if (username.Length > 0 || password.Length > 0)
            {
                UserAccount user = _userAccountHandler.FindUser(username);
                if (user != null)
                {
                    if(user.UserName == username && user.Password == MD5Service.MD5Hash(password))
                    {
                        using (Form_Dashboard form_Dashboard = new Form_Dashboard())
                        {
                            form_Dashboard.ShowDialog();
                        }
                    }
                    //Nếu đăng nhập sai
                    else
                    {
                        MessageBox.Show("Password is wrong");
                    }
                }
                else
                {
                    MessageBox.Show("The acount is not existed!");
                }
            }
            else
            {
                MessageBox.Show("Username or Password is empty!");
            }
        }

        //Hàm gọi UserForm vào Panel
        private void AddUserFormToPanel(Control ufc)
        {
            ufc.Dock = DockStyle.Fill;
            FormMain.Instance.PanelContainer.Controls.Clear();
            FormMain.Instance.PanelContainer.Controls.Add(ufc);
        }

        private void btnRegisterUserForm_Click_1(object sender, EventArgs e)
        {
            if (!FormMain.Instance.PanelContainer.Controls.ContainsKey("UFC_Register"))
            {
                UFC_Register ufc_Register = new UFC_Register();
                AddUserFormToPanel(ufc_Register);
            }
            FormMain.Instance.PanelContainer.Controls["UFC_Register"].BringToFront();
        }
    }
}
