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
    public partial class Form_Dashboard : Form
    {
        int panelWidth;
        bool isCollapsed;

        public Form_Dashboard()
        {
            InitializeComponent();
            timerTheTime.Start();
            panelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        //Di chuyển panelKichHoat
        private void movePanelActivated(Control btn)
        {
            panelActivated.Top = btn.Top;
            panelActivated.Height = btn.Height;
        }

        //Xử lý với Timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                picLogo.Image = new Bitmap(Application.StartupPath + "\\Resources\\open-book.png");
                lbBookstore.Text = "TDC BookStore";
                lbWindows.Text = "Windows Form 2020";
                panelLeft.Width = panelLeft.Width + 10;
                if(panelLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                picLogo.Image = null;
                lbBookstore.Text = "";
                lbWindows.Text = "";
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 60)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        //Xử lý với Timer Đồng hồ
        private void timerDongHo_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbClock.Text = dt.ToString("HH:mm:ss");
             lbDate.Text = dt.ToString("dd/MM/yyyy");
        }

        //Hàm gọi Panel User Form Control
        private void AddUserFormControlToPanel(Control ufc)
        {
            ufc.Dock = DockStyle.Fill;
            panelUserForm.Controls.Clear();
            panelUserForm.Controls.Add(ufc);
        }
        //Close program
        private void btnClose_Click(object sender, EventArgs e)
        {
            using(Form_Closing form_Closing = new Form_Closing())
            {
                form_Closing.ShowDialog();
            }
        }
        //btn Home
        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            movePanelActivated(btnMenuHome);
            UFC_Home ufc_home = new UFC_Home();
            AddUserFormControlToPanel(ufc_home);
        }
        //btn Purchase Items
        private void btnMenuPurchaseItems_Click(object sender, EventArgs e)
        {
            movePanelActivated(btnMenuPurchaseItems);
            UFC_PurchaseItems ufc_PurchaseItems = new UFC_PurchaseItems();
            AddUserFormControlToPanel(ufc_PurchaseItems);
        }
        //btn Customers
        private void btnMenuCustomers_Click(object sender, EventArgs e)
        {
            movePanelActivated(btnMenuCustomers);
            UFC_Customer ufc_Customer = new UFC_Customer();
            AddUserFormControlToPanel(ufc_Customer);
        }
        // Sell Items
        private void btnSellItems_Click(object sender, EventArgs e)
        {
            movePanelActivated(btnMenuSellItems);
            UFC_SellItems ufc_SellItems = new UFC_SellItems();
            AddUserFormControlToPanel(ufc_SellItems);

        }
        //btn Reports
        private void btnMenuReports_Click(object sender, EventArgs e)
        {
            movePanelActivated(btnMenuReports);
        }

        //btn Reports
        private void btnCategories_Click(object sender, EventArgs e)
        {
            movePanelActivated(btnCategories);
            UFC_Categories ufc_Categories = new UFC_Categories();
            AddUserFormControlToPanel(ufc_Categories);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //Form Dashboard Load
        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            UFC_Home ufc_home = new UFC_Home();
            AddUserFormControlToPanel(ufc_home);
        }
        //btn Receipts
        private void btnMenuReceipts_Click(object sender, EventArgs e)
        {
            movePanelActivated(btnMenuReceipts);
            UFC_Receipts ufc_Receipts = new UFC_Receipts();
            AddUserFormControlToPanel(ufc_Receipts);
        }
    }
}
