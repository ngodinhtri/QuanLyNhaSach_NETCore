using QuanLyNhaSach.UserFormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FormMain : Form
    {
        static FormMain _obj;
        public static FormMain Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new FormMain();
                }
                return _obj;
            }
        }

        public Panel PanelContainer
        {
            get { return panelUserForm; }
            set { panelUserForm = value; }
        }

        public FormMain()
        {
            InitializeComponent();
            
        }
        //Hàm gọi UserForm vào Panel
        private void AddUserFormToPanel(Control ufc)
        {
            ufc.Dock = DockStyle.Fill;
            panelUserForm.Controls.Clear();
            panelUserForm.Controls.Add(ufc);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            using(Form_Closing form_Closing = new Form_Closing())
            {
                form_Closing.ShowDialog();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _obj = this;

            UFC_Login ufc_login = new UFC_Login();
            AddUserFormToPanel(ufc_login);
        }
    }
}
