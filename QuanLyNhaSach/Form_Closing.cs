using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class Form_Closing : Form
    {
        public Form_Closing()
        {
            InitializeComponent();
        }
        //Exit program
        private void btnYes_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        //Cancel
        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
