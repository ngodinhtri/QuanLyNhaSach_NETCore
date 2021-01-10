using ModelDatabase.EF;
using ModelHandle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaSach.UserFormControls
{
    public partial class UFC_PurchaseItems : UserControl
    {
        //Khai báo
        private string nameProductCurrent = "";
        private CategoryHandler _categoryHandler = new CategoryHandler();
        private ProductHandler _productHandler = new ProductHandler();
        private string _rootProjectPath = Path.GetDirectoryName(Application.StartupPath) + "\\CommonImage\\";

        public UFC_PurchaseItems()
        {
            InitializeComponent();
        }

        //Tìm kiếm sản phẩm
        private void btnSearchItems_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text;

            dtgvProducts.Rows.Clear();
            List<Product> products = _productHandler.GetSearchedList(key);
            int count = 0;
            if (products.Any())
            {
                foreach (var Item in products)
                {
                    count++;
                    Image img = Image.FromFile(_rootProjectPath + Item.Image);
                    dtgvProducts.Rows.Add(count, Item.Name, img, Item.category != null ? Item.category.Name : "Null", Item.Quantiy, Item.Price);
                }
                if (dtgvProducts.Rows.Count > 0)
                {
                    nameProductCurrent = dtgvProducts.Rows[0].Cells[1].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Could not find anything");
                txtSearch.Clear();
                txtSearch.Focus();
            }
        }

        //Xóa sản phẩm
        private async void btnDeleteItems_Click(object sender, EventArgs e)
        {
            Product pd = _productHandler.GetProduct(nameProductCurrent);
            if (pd != null)
            {
                DialogResult r = MessageBox.Show("Do you want to delete this product?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    bool result = await _productHandler.RemoveProduct(pd.ID);

                    if (result == true)
                    {
                        MessageBox.Show("Deleted");
                        LoadDTGVShow();
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
            }
            else
            {
                MessageBox.Show("Not have any product");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using(Form_AddNewItem form_AddNewItem = new Form_AddNewItem())
            {
                form_AddNewItem.ShowDialog();
            }
            LoadDTGVShow();
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
                dtgvProducts.Rows.Add(count, Item.Name, img, Item.category != null ? Item.category.Name: "Null", Item.Quantiy, Item.Price);

            }
            if (dtgvProducts.Rows.Count > 0)
            {
                nameProductCurrent = dtgvProducts.Rows[0].Cells[1].Value.ToString();
            }
        }

        private void UFC_PurchaseItems_Load(object sender, EventArgs e)
        {
            LoadDTGVShow();
        }
        //Double Cell Click
        private void dtgvProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex <= dtgvProducts.Rows.Count)
                {
                    string nameItem = dtgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Product pd = _productHandler.GetProduct(nameItem);
                    if (pd != null)
                    {
                        string idItem = pd.ID;
                        using (Form_EditItem form_EditItem = new Form_EditItem(idItem))
                        {
                            form_EditItem.ShowDialog();
                        }
                        UFC_PurchaseItems_Load(sender, e);
                    }
                }
            }
        }

        private void dtgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameProductCurrent = dtgvProducts.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
