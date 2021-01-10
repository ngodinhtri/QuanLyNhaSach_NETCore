using ModelDatabase.EF;
using ModelHandle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.UserFormControls
{
    public partial class UFC_Home : UserControl
    {
        private CustomerHandler _customerHandler = new CustomerHandler();
        private ProductHandler _productHandler = new ProductHandler();
        private BillHandler _billHandler = new BillHandler();
        private BillItemHandler _billItemHandler = new BillItemHandler();
        public UFC_Home()
        {
            InitializeComponent();
        }

        private void UFC_Home_Load(object sender, EventArgs e)
        {
            List<BillItem> billitems = _billItemHandler.GetList();
            int quanity = 0;
            if(billitems.Count == 0)
            {
                lbSoldItems.Text = "0";
            }
            else
            {
                foreach (var item in billitems)
                {
                    quanity += item.Quanity;
                }
                lbSoldItems.Text = quanity.ToString();
            }

            List<Product> products = _productHandler.GetProductList();
            quanity = 0;
            if (products.Count == 0)
            {
                lbStockItems.Text = "0";
            }
            else
            {
                foreach (var item in products)
                {
                    quanity += item.Quantiy;
                }
                lbStockItems.Text = quanity.ToString();
            }

            List<Customer> customers = _customerHandler.GetList();
            if (products.Count == 0)
            {
                lbCustomersQty.Text = "0";
            }
            else
            { 
                lbCustomersQty.Text = customers.Count.ToString();
            }
        }
    }
}
