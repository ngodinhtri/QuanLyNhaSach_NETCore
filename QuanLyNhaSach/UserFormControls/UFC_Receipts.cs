using ModelDatabase.EF;
using ModelHandle;
using QuanLyNhaSach.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.UserFormControls
{
    public partial class UFC_Receipts : UserControl
    { 
        private CustomerHandler _customerHandler = new CustomerHandler();
        private ProductHandler _productHandler = new ProductHandler();
        private BillHandler _billHandler = new BillHandler();
        private BillItemHandler _billItemHandler = new BillItemHandler();
        public UFC_Receipts()
        {
            InitializeComponent();
        }

        private void UFC_Receipts_Load(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
        }

        //Load DataGridView
        private void LoadDTGVShow()
        {
            dtgvBills.Rows.Clear();
            List<Bill> list = _billHandler.GetList();
            int count = 0;
            foreach (var Item in list)
            {
                count++;
                String customerName = _customerHandler.GetName(Item.CustomerID);
                dtgvBills.Rows.Add(count,Item.ID, customerName, Item.dateTime.ToString("dd/MM/yyyy h:mm tt"), Item.Total);
            }
        }
        //CellDoubleClick
        private async void dtgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbCustomer.Items.Clear();
            cbCustomer.Text = "";
            txtInvoid.Text = "";
            txtDate.Text = "";
            txtTotal.Text = "";
            lvDetail.Items.Clear();


            if (e.RowIndex >= 0)
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = true;

                Bill bill = _billHandler.GetByID(dtgvBills.Rows[e.RowIndex].Cells[1].Value.ToString());
                Customer customer =  _customerHandler.GetCustomer(bill.CustomerID);
                txtInvoid.Text = bill.ID;
                txtDate.Text = bill.dateTime.ToString("dd/MM/yyyy h:mm tt");
                txtTotal.Text = bill.Total.ToString();

                List<Customer> customers = _customerHandler.GetList();
                int count = 0;
                int index = 0;
                foreach (var Item in customers)
                {
                    ComboboxItem boxItem = new ComboboxItem();
                    boxItem.Text = Item.Name;
                    boxItem.Value = Item.ID;
                    cbCustomer.Items.Add(boxItem);

                    if (Item.ID == customer.ID)
                    {
                        index = count;
                    }
                    count++;
                }
                cbCustomer.SelectedIndex = index;

                //Detail Bill
                List<BillItem> billItems = _billItemHandler.GetList(bill.ID);
                foreach(var element in billItems)
                {
                    
                    string[] arrRow = new string[3];
                    ListViewItem item;

                    arrRow[0] = element.ProductName;
                    arrRow[1] = element.Quanity.ToString();
                    arrRow[2] = (element.Price * element.Quanity).ToString();

                    item = new ListViewItem(arrRow);

                    lvDetail.Items.Add(item);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadDTGVShow();
            cbCustomer.Items.Clear();
            cbCustomer.Text = "";
            txtInvoid.Text = "";
            txtDate.Text = "";
            txtTotal.Text = "";
            lvDetail.Items.Clear();
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Bill bill = _billHandler.GetByID(txtInvoid.Text);
            string customerID = (cbCustomer.SelectedItem as ComboboxItem).Value.ToString();
            if(!customerID.Equals(bill.CustomerID))
            {
                bill.CustomerID = customerID;
                bool result = await _billHandler.Update(bill);
                if(result)
                {
                    MessageBox.Show("Done");
                    btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                string id = txtInvoid.Text;
                bool result = await _billHandler.Delete(id);
                if (result)
                {
                    MessageBox.Show("Deleted");
                    btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            } 
        }
    }
}
