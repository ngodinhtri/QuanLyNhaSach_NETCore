using ModelDatabase.EF;
using ModelHandle;
using QuanLyNhaSach.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyNhaSach.UserFormControls
{
    public partial class UFC_SellItems : UserControl
    {
        //Khai báo
        private double dTotal = 0.0;
        private double dTotalTemp = 0.0;

        private string nameProductCurrent = "";
        private CategoryHandler _categoryHandler = new CategoryHandler();
        private ProductHandler _productHandler = new ProductHandler();
        private CustomerHandler _customerHandler = new CustomerHandler();
        private string _rootProjectPath = Path.GetDirectoryName(Application.StartupPath) + "\\CommonImage\\";

        public UFC_SellItems()
        {
            InitializeComponent();
        }

        private void UFC_SellItems_Load(object sender, EventArgs e)
        {
            LoadDTGVShow();
            List<Customer> customers = _customerHandler.GetList();
            foreach (var Item in customers)
            {
                ComboboxItem boxItem = new ComboboxItem();
                boxItem.Text = Item.Name;
                boxItem.Value = Item.ID;
                cbCustomer.Items.Add(boxItem);
            }
            cbCustomer.SelectedIndex = 0;
        }

        //Load DataGridView
        private void LoadDTGVShow()
        {
            dtgvProducts.RowTemplate.Height = 100;
            dtgvProducts.Rows.Clear();
            List<Product> products = _productHandler.GetProductList();
            int count = 0;
            Image img = null;
            foreach (var Item in products)
            {
                count++;
                img = Image.FromFile(_rootProjectPath + Item.Image);
                dtgvProducts.Rows.Add(count, Item.Name, img, Item.category != null ? Item.category.Name : "Null", Item.Quantiy, Item.Price);

            }
        }
        //Button Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quanity = 0;
            if(txtQuantity.Text.Length > 0)
            {
                Regex regex = new Regex(@"^[0-9]*$");
                if(regex.IsMatch(txtQuantity.Text))
                {
                    quanity = Int32.Parse(txtQuantity.Text);
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(txtQuantity, "Please input an number!");
                    txtQuantity.Clear();
                    txtQuantity.Focus();
                    return;
                }
            }
            else
            {
                errorProvider1.SetError(txtQuantity, "The quanity box is empty");
                txtQuantity.Focus();
                return;
            }

            if (dtgvProducts.SelectedRows.Count > 0)
            {
                string name = dtgvProducts.SelectedRows[0].Cells["col_Name"].Value.ToString();
                int stock = Int32.Parse(dtgvProducts.SelectedRows[0].Cells["col_Stock"].Value.ToString());
                double price = Double.Parse(dtgvProducts.SelectedRows[0].Cells["col_Price"].Value.ToString());
                //Kiểm tra số hàng còn lại lớn hơn số lượng mua
                if(quanity <= stock)
                {
                    string[] arrRow = new string[3];
                    ListViewItem item;

                    arrRow[0] = name;
                    arrRow[1] = quanity.ToString();
                    arrRow[2] = (price * quanity).ToString();

                    item = new ListViewItem(arrRow);

                    lvSellItems.Items.Add(item);
                    dTotal += (quanity * price);
                  

                    dtgvProducts.SelectedRows[0].Cells["col_Stock"].Value = (stock - quanity).ToString();
                    lbTotal.Text = dTotal.ToString();
                    txtQuantity.Clear();
                }
                else
                {
                    MessageBox.Show("Quanity > Stock");
                }
            }
            else
            {
                MessageBox.Show("No rows have been selected");
            }
        }
        //Dekte Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvSellItems.SelectedItems.Count > 0)
            {
                string name = lvSellItems.SelectedItems[0].SubItems[0].Text;
                int quanity = Int32.Parse(lvSellItems.SelectedItems[0].SubItems[1].Text);
                double price = Int32.Parse(lvSellItems.SelectedItems[0].SubItems[2].Text);

                foreach (DataGridViewRow row in dtgvProducts.Rows)
                {
                    if(row.Cells["col_Name"].Value.ToString().Equals(name))
                    {
                        row.Cells["col_Stock"].Value = Int32.Parse(row.Cells["col_Stock"].Value.ToString()) + quanity;
                    }
                }
                dTotal -= price;
                lbTotal.Text = dTotal.ToString();
                lvSellItems.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("No rows have been selected");
            }
        }
        //Clear buttton
        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }
    }
}
