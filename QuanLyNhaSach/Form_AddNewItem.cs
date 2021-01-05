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
    public partial class Form_AddNewItem : Form
    {

        //Khai báo
        private string _filePath = "";
        private string _rootProjectPath = Path.GetDirectoryName(Application.StartupPath) + "\\CommonImage\\";
        private CategoryHandler _categoryHandler = new CategoryHandler();
        private ProductHandler _productHandler = new ProductHandler();

        public Form_AddNewItem()
        {
            InitializeComponent();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Upload ảnh
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
        //Thêm sản phẩm
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string category = cbCategories.SelectedItem.ToString();
            int quanity = Int32.Parse(txtQuanity.Text);
            double price = Double.Parse(txtPrice.Text);
            string cateID = (cbCategories.SelectedItem as ComboboxItem).Value.ToString();

            //Kiểm tra đã thêm ảnh chưa?
            if (_filePath.Length > 0)
            {
                //Kiểm tra đã có tên sản phẩm chưa?
                if (_productHandler.FindProductByName(name) == null)
                {
                    PrimaryKey key = new PrimaryKey();
                    Product pd = new Product();
                    pd.ID = key.createKey();
                    pd.Name = name;
                    pd.Image = Guid.NewGuid() + Path.GetFileName(_filePath);  //Lưu tên file vào database
                    pd.Quantiy = quanity;
                    pd.Price = price;
                    pd.CategoryID = cateID;
                    pd.dateTime = DateTime.Now;
                    bool result = await _productHandler.CreateProduct(pd);

                    if (result)
                    {
                        //Lưu ảnh vào folder
                        try
                        {
                            Bitmap bImg = new Bitmap(_filePath);
                            bImg.Save(_rootProjectPath + pd.Image.ToString());
                            bImg.Dispose();
                            MessageBox.Show("Completed!");

                            this.Dispose();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Save image failed!");
                    }
                }
                else
                {
                    MessageBox.Show("This category is existed!");
                }
            }
            else
            {
                MessageBox.Show("Import an image!");
            }
        }
        //Form Load
        private void Form_AddNewItem_Load(object sender, EventArgs e)
        {
            List<Category> categories = _categoryHandler.GetCategoryList();
            foreach (var Item in categories)
            {
                ComboboxItem boxItem = new ComboboxItem();
                boxItem.Text = Item.Name;
                boxItem.Value = Item.CategoryId;
                cbCategories.Items.Add(boxItem);
            }
            cbCategories.SelectedIndex = 0;
        }
    }
}
