using ModelDatabase.EF;
using ModelHandle;
using QuanLyNhaSach.Common;
using QuanLyNhaSach.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyNhaSach.UserFormControls
{
    public partial class UFC_Register : UserControl
    {
        private readonly UserAccountHandler _userAccountHandler = new UserAccountHandler();
        public UFC_Register()
        {
            InitializeComponent();
        }

        private void UFC_Register_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String confirmPass = txtConfirmPass.Text;

            //Xác thực
            if (password.Equals(confirmPass) && username.Equals("") == false)
            {
                //Tìm username trong database đã tồn tại hay chưa?
                if (_userAccountHandler.FindUser(username) == null)
                {
                    UserAccount user = new UserAccount();
                    PrimaryKey key = new PrimaryKey();
                    user.UserId = key.createKey();
                    user.Password = MD5Service.MD5Hash(password);
                    user.UserName = username;
                    bool result = await _userAccountHandler.CreateUser(user);
                    if (result)
                    {
                        MessageBox.Show("Succeed!");
                    }else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                //Nếu username đã tồn tại
                else
                {
                    MessageBox.Show("Username is existed");
                }
            }else
            {
                MessageBox.Show("Comfirm password or Username is wrong");
            }
        }

        //Hàm gọi UserForm vào Panel
        private void AddUserFormToPanel(Control ufc)
        {
            ufc.Dock = DockStyle.Fill;
            FormMain.Instance.PanelContainer.Controls.Clear();
            FormMain.Instance.PanelContainer.Controls.Add(ufc);
            
        }

        private void btnLoginUserForm_Click(object sender, EventArgs e)
        {
            if(!FormMain.Instance.PanelContainer.Controls.ContainsKey("UFC_Login"))
            {
                UFC_Login ufc_Login = new UFC_Login();
                AddUserFormToPanel(ufc_Login);
            }
            FormMain.Instance.PanelContainer.Controls["UFC_Login"].BringToFront();
        }

        //private void txtUsername_Leave(object sender, EventArgs e)
        //{
        //    Control ctr = (Control)sender;

        //    if (ctr.Text.Trim().Length == 0)
        //    {
        //        this.errorProvider1.SetError(txtUsername, "You must enter username");
        //        txtUsername.Clear();
        //        txtUsername.Focus();  
        //    }
        //    else
        //    {
        //        Regex check = new Regex(@"^[a-zA-Z0-9]+$");
        //        bool vallid = check.IsMatch(ctr.Text);
        //        if(vallid == true)
        //        {
        //            this.errorProvider1.Clear();
        //            return;
        //        }
        //        else
        //        {
        //            this.errorProvider1.SetError(txtUsername, "At least one letter or number");
        //        }
        //    }
               
        //}

        //private void txtPassword_Leave(object sender, EventArgs e)
        //{
        //    Control ctr = (Control)sender;

        //    if (ctr.Text.Trim().Length == 0)
        //    {
        //        this.errorProvider1.SetError(txtPassword, "You must enter password");
        //        txtPassword.Clear();
        //        txtPassword.Focus();
        //    }
        //    else
        //    {
        //        Regex check = new Regex(@"^[a-zA-Z0-9]+$");
        //        bool vallid = check.IsMatch(ctr.Text);
        //        if (vallid == true)
        //        {
        //            this.errorProvider1.Clear();
        //            return;
        //        }
        //        else
        //        {
        //            this.errorProvider1.SetError(txtPassword, "At least one letter or number");
        //        }
        //    }
        //}

        //private void UFC_Register_Leave(object sender, EventArgs e)
        //{
            
        //}

        //private void txtConfirmPass_Leave(object sender, EventArgs e)
        //{
        //    Control ctr = (Control)sender;

        //    if (ctr.Text.Trim().Length == 0)
        //    {
        //        this.errorProvider1.SetError(txtConfirmPass, "You must enter confirm password");
        //        txtConfirmPass.Clear();
        //        txtConfirmPass.Focus();
        //    }
        //    else
        //    {
        //        if (txtConfirmPass.Text.Equals(txtPassword.Text) == false)
        //        {
        //            this.errorProvider1.SetError(txtConfirmPass, "It is not match!");
        //            txtConfirmPass.Clear();
        //            txtConfirmPass.Focus();
        //        }
        //        else
        //        {
        //            this.errorProvider1.Clear();

        //        }

        //    }
        //}
    }
}