using ModelDatabase.EF;
using ModelHandle;
using QuanLyNhaSach.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.UserFormControls
{
    public partial class UFC_Customer : UserControl
    {
        //Khai báo
        CustomerHandler _customerHandler = new CustomerHandler();
        private string id_Customer = "";

        public UFC_Customer()
        {
            InitializeComponent();
            
        }
        //Btn Add
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string gender = "";
            if(rdoMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            //Kiểm tra có trùng số sdt không
            if(_customerHandler.FindPhone(phone) == null)
            {
                PrimaryKey key = new PrimaryKey();
                Customer customer = new Customer();

                customer.ID = key.createKey();
                customer.Phone = phone;
                customer.Name = name;
                customer.Gender = gender;
                customer.Address = address;

                bool result = await _customerHandler.CreateCustomer(customer);
                if (result)
                {
                    MessageBox.Show("Completed!");
                    LoadDTGVShow();
                    btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed.");
                }
            }
            else
            {
                MessageBox.Show("The number phone is existed.");
            }
        }

        

        //Load DTGV
        private void LoadDTGVShow()
        {
            dtgvCustomers.Rows.Clear();
            List<Customer> customers = _customerHandler.GetList();
            int count = 0;
            foreach (var Item in customers)
            {
                count++;
                dtgvCustomers.Rows.Add(count, Item.Name, Item.Phone, Item.Gender, Item.Address);
            }

            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        //Cell Double Click
        private void dtgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dtgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhone.Text = dtgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                string gender = dtgvCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                switch (gender)
                {
                    case "Male":
                        rdoMale.Checked = true;
                        break;
                    case "Female":
                        rdoFemale.Checked = true;
                        break;
                }
                txtAddress.Text = dtgvCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();

                Customer customer = _customerHandler.GetByPhone(txtPhone.Text);
                if (customer != null)
                {
                    id_Customer = customer.ID;

                    btnAdd.Enabled = false;
                    btnClear.Enabled = true;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    MessageBox.Show("CateID is not valid");
                }
            }
                
        }
        //Btn Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            id_Customer = "";

            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            rdoMale.Checked = true;

            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }
        //Btn Save
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string gender = "";

            if (rdoMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            
            PrimaryKey key = new PrimaryKey();
            Customer customer = await _customerHandler.GetByID(id_Customer);

            customer.Phone = phone;
            customer.Name = name;
            customer.Gender = gender;
            customer.Address = address;

            bool result = await _customerHandler.UpdateAsync(customer);
            if (result)
            {
                MessageBox.Show("Completed!");
                LoadDTGVShow();
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Failed.");
            }
            
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string id = id_Customer;
            DialogResult r = MessageBox.Show("Delete this Customer?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                bool result = await _customerHandler.Remove(id);
                if (result)
                {
                    MessageBox.Show("Deleted!");
                    LoadDTGVShow();
                    btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private  void btnSearch_Click(object sender, EventArgs e)
        {
            string sSearch = txtSearch.Text;
            dtgvCustomers.Rows.Clear();
            List<Customer> customers =  _customerHandler.GetSearchedList(sSearch);
            int count = 0;
            if (customers.Any())
            {
                foreach (var Item in customers)
                {
                    count++;
                    count++;
                    dtgvCustomers.Rows.Add(count, Item.Name, Item.Phone, Item.Gender, Item.Address);

                }
            }
            else
            {
                MessageBox.Show("Could not find anything");
                txtSearch.Clear();
                txtSearch.Focus();
            }

            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void UFC_Customer_Load(object sender, EventArgs e)
        {
            rdoMale.Checked = true;

            LoadDTGVShow();

            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
