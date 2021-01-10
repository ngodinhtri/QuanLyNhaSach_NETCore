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
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class Form_EditItem : Form
    {
        //Khai báo 
        private string sIDItem = "";
        private string _filePath = "";
        private string _rootProjectPath = Path.GetDirectoryName(Application.StartupPath) + "\\CommonImage\\";
        private CategoryHandler _categoryHandler = new CategoryHandler();
        private ProductHandler _productHandler = new ProductHandler();

        public Form_EditItem(String idItem)
        {
            InitializeComponent();
            sIDItem = idItem;
        }
        public Form_EditItem()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.png;)|*.jpg;*.jpeg;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picItem.Image = new Bitmap(opnfd.FileName);
                _filePath = opnfd.FileName;
            }
            opnfd.Dispose();
        }
        //Save
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int quanity = 0;
            double price = 0.0;
            try
            {
                quanity = Int32.Parse(txtQuanity.Text);
                price = Double.Parse(txtPrice.Text);

                if (quanity < 0.0 || price < 0)
                {
                    MessageBox.Show("The price or the quantity is invalid");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The price or the quantity is invalid");
                return;
            }

            string cateID = (cbCategories.SelectedItem as ComboboxItem).Value.ToString();

            //Kiểm tra đã thêm ảnh chưa?
            if (picItem.Image != null)
            {

                if (_productHandler.FindProductByName(name) == null || name.Equals(_productHandler.getName(sIDItem)))
                {
                    PrimaryKey key = new PrimaryKey();
                    Product pd = await _productHandler.GetProductyByID(sIDItem);
                    pd.Name = name;
                    pd.Quantiy = quanity;
                    pd.Price = price;
                    pd.CategoryID = cateID;
                    //Kiểm tra có thay đổi ảnh hay không
                    if (_filePath.Length > 0)
                    {
                        pd.Image = Guid.NewGuid() + Path.GetFileName(_filePath);  //Lưu tên file vào database
                        Bitmap bImg = new Bitmap(_filePath);
                        bImg.Save(_rootProjectPath + pd.Image.ToString());
                        bImg.Dispose();
                    }

                    bool result = await _productHandler.UpdateProductAsync(pd);
                    if (result)
                    {
                        MessageBox.Show("Completed!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update failed");
                    }
                }
                else
                {
                    MessageBox.Show("The product's name is existed.");
                }
                
            }
            else
            {
                MessageBox.Show("Import an image!");
            }
        }
        //Load
        private async void Form_EditItem_Load(object sender, EventArgs e)
        {
            Product pd = await _productHandler.GetProductyByID(sIDItem);
            List<Category> categories = _categoryHandler.GetCategoryList();

            txtName.Text = pd.Name;
            txtPrice.Text = pd.Price.ToString();
            txtQuanity.Text = pd.Quantiy.ToString();

            int count = 0;
            int index = 0;
            foreach (var Item in categories)
            {
                ComboboxItem boxItem = new ComboboxItem();
                boxItem.Text = Item.Name;
                boxItem.Value = Item.CategoryId;
                cbCategories.Items.Add(boxItem);

                if(Item.CategoryId == pd.CategoryID)
                {
                    index = count;
                }
                    count++;
            }
            cbCategories.SelectedIndex = index;

            picItem.Image = new Bitmap(_rootProjectPath + pd.Image);
        }
    }
}
