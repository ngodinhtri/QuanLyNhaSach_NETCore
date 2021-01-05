using ModelDatabase.EF;
using ModelHandle;
using QuanLyNhaSach.Common;
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
    public partial class UFC_Categories : UserControl
    {
        private string _filePath = "";
        private string _fileName = "";
        private string _rootProjectPath = Path.GetDirectoryName(Application.StartupPath) + "\\CommonImage\\";
        private CategoryHandler _categoryHandler = new CategoryHandler();
        public UFC_Categories()
        {
            InitializeComponent();
        }

        private void picCate_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.png;)|*.jpg;*.jpeg;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picCate.Image = new Bitmap(opnfd.FileName);
                _filePath = opnfd.FileName;
            }
            opnfd.Dispose();
        }
        //Btn add
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtNameCate.Text;
            //Kiểm tra name rỗng
            if (name.Length > 0)
            {
                //Kiểm tra đã thêm ảnh chưa?
                if (_filePath.Length > 0)
                {
                    //Kiểm tra đã có Category chưa?
                    if (_categoryHandler.FindCategory(name) == null)
                    {
                        PrimaryKey key = new PrimaryKey();
                        Category cate = new Category();
                        cate.CategoryId = key.createKey();
                        cate.Name = name;
                        cate.Image = Guid.NewGuid() + Path.GetFileName(_filePath);  //Lưu tên file vào database
                        cate.dateTime = DateTime.Now;
                        bool result = await _categoryHandler.CreateCategory(cate);

                        if (result)
                        {
                            //Lưu ảnh vào folder
                            try
                            {
                                Bitmap bImg = new Bitmap(_filePath);
                                bImg.Save(_rootProjectPath + cate.Image.ToString());
                                bImg.Dispose();
                                MessageBox.Show("Completed!");

                                LoadDTGVShow();
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
            else
            {
                MessageBox.Show("Name is empty!");
            }
            //Reset
            _filePath = "";
            txtCateID.Clear();
            txtNameCate.Clear();
            picCate.Image = new Bitmap(Application.StartupPath + "\\Resources\\shopping-bag.png");
        }
        //Hàm load dtgvCategories
        private void LoadDTGVShow()
        {
            dtgvCategories.RowTemplate.Height = 100;
            dtgvCategories.Rows.Clear();
            List<Category> categories = _categoryHandler.GetCategoryList();
            int count = 0;
            Image img = null;
            foreach (var Item in categories)
            {
                count++;
                 img =  Image.FromFile(_rootProjectPath + Item.Image);

                dtgvCategories.Rows.Add(count, Item.CategoryId, Item.Name, img);
                
            }
            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;

            
        }

        //Hàm load UFC_Category
        private void UFC_Categories_Load(object sender, EventArgs e)
        {
            LoadDTGVShow();
            foreach (DataGridViewColumn column in dtgvCategories.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        //CellDoubleClick
        private async void dtgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCateID.Text = dtgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNameCate.Text = dtgvCategories.Rows[e.RowIndex].Cells[2].Value.ToString();
                picCate.Image = (Bitmap)dtgvCategories.Rows[e.RowIndex].Cells[3].Value;

                Category cate = await _categoryHandler.GetCategory(txtCateID.Text);
                if (cate != null)
                {
                    _fileName = cate.Image;
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
        //Lưu sửa chữa
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string cateID = txtCateID.Text;
            string name = txtNameCate.Text;
            //Kiểm tra name rỗng
            if (name.Length > 0)
            {
                //Kiểm tra đã thêm ảnh chưa?
                if (picCate.Image!=null)
                {
                    //Kiểm tra đã có Category chưa?
                    if (_categoryHandler.FindCategory(name) == null)
                    {
                        Category cate = await _categoryHandler.GetCategory(cateID);
                        cate.Name = name;
                        //Nếu có thay đổi ảnh
                        if(_filePath.Length > 0)
                        { 
                            cate.Image = Guid.NewGuid() + Path.GetFileName(_filePath);  //Lưu tên file vào database
                            Bitmap bImg = new Bitmap(_filePath);
                            bImg.Save(_rootProjectPath + cate.Image.ToString());
                            bImg.Dispose();
                        }
                       
                        bool result = await _categoryHandler.UpdateCategoryAsync(cate);
                        if (result)
                        {
                            MessageBox.Show("Completed!");
                            LoadDTGVShow();
                        }
                        else
                        {
                            MessageBox.Show("Update failed");
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
            else
            {
                MessageBox.Show("Name is empty!");
            }
            //Reset
            _filePath = "";
            txtCateID.Clear();
            txtNameCate.Clear();
            picCate.Image = new Bitmap(Application.StartupPath + "\\Resources\\shopping-bag.png");

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string CateID = txtCateID.Text;
            DialogResult r = MessageBox.Show("Delete this Category?", "WARNING", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(r == DialogResult.Yes)
            {
                bool result = await _categoryHandler.RemoveCategory(CateID);
                if (result)
                {
                    MessageBox.Show("Deleted!");
                    LoadDTGVShow();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _filePath = "";
            txtCateID.Clear();
            txtNameCate.Clear();
            picCate.Image = new Bitmap(Application.StartupPath + "\\Resources\\shopping-bag.png");

            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }
        //Tìm kiếm 
        private void btnSearchCate_Click(object sender, EventArgs e)
        {
            string sSearch = txtSearchCate.Text;
            dtgvCategories.Rows.Clear();
            List<Category> categories = _categoryHandler.GetSearchedList(sSearch);
            int count = 0;
            if (categories.Any())
            {
                foreach (var Item in categories)
                {
                    count++;
                    Image img = Image.FromFile(_rootProjectPath + Item.Image);

                    dtgvCategories.Rows.Add(count, Item.CategoryId, Item.Name, img);

                }
            }
            else
            {
                MessageBox.Show("Could not find anything");
                txtSearchCate.Clear();
                txtSearchCate.Focus();
            }
            
            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

       
    }
}
