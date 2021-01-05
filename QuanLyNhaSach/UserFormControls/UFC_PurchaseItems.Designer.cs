
namespace QuanLyNhaSach.UserFormControls
{
    partial class UFC_PurchaseItems
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFC_PurchaseItems));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSearchItems = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteItems = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dtgvProducts = new System.Windows.Forms.DataGridView();
            this.col_Numemric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 570);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 10);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(975, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 570);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 10);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 580);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(163)))), ((int)(((byte)(195)))));
            this.panel5.Controls.Add(this.btnSearchItems);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnDeleteItems);
            this.panel5.Controls.Add(this.btnAddNew);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(965, 50);
            this.panel5.TabIndex = 8;
            // 
            // btnSearchItems
            // 
            this.btnSearchItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchItems.FlatAppearance.BorderSize = 0;
            this.btnSearchItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchItems.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchItems.Image")));
            this.btnSearchItems.Location = new System.Drawing.Point(922, 0);
            this.btnSearchItems.Name = "btnSearchItems";
            this.btnSearchItems.Size = new System.Drawing.Size(43, 50);
            this.btnSearchItems.TabIndex = 5;
            this.btnSearchItems.UseVisualStyleBackColor = true;
            this.btnSearchItems.Click += new System.EventHandler(this.btnSearchItems_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(670, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(246, 32);
            this.txtSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(587, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // btnDeleteItems
            // 
            this.btnDeleteItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteItems.FlatAppearance.BorderSize = 0;
            this.btnDeleteItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItems.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteItems.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItems.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItems.Image")));
            this.btnDeleteItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteItems.Location = new System.Drawing.Point(151, 0);
            this.btnDeleteItems.Name = "btnDeleteItems";
            this.btnDeleteItems.Size = new System.Drawing.Size(151, 50);
            this.btnDeleteItems.TabIndex = 2;
            this.btnDeleteItems.Text = "  Delete";
            this.btnDeleteItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteItems.UseVisualStyleBackColor = true;
            this.btnDeleteItems.Click += new System.EventHandler(this.btnDeleteItems_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(0, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(151, 50);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "  Add new";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dtgvProducts
            // 
            this.dtgvProducts.AllowUserToAddRows = false;
            this.dtgvProducts.AllowUserToDeleteRows = false;
            this.dtgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProducts.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Numemric,
            this.col_Name,
            this.col_Img,
            this.col_Category,
            this.col_Quanity,
            this.col_Price});
            this.dtgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProducts.GridColor = System.Drawing.Color.White;
            this.dtgvProducts.Location = new System.Drawing.Point(10, 60);
            this.dtgvProducts.MultiSelect = false;
            this.dtgvProducts.Name = "dtgvProducts";
            this.dtgvProducts.ReadOnly = true;
            this.dtgvProducts.RowHeadersVisible = false;
            this.dtgvProducts.RowHeadersWidth = 51;
            this.dtgvProducts.RowTemplate.Height = 29;
            this.dtgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProducts.Size = new System.Drawing.Size(965, 510);
            this.dtgvProducts.TabIndex = 9;
            this.dtgvProducts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvProducts_CellMouseDoubleClick);
            // 
            // col_Numemric
            // 
            this.col_Numemric.FillWeight = 26.73797F;
            this.col_Numemric.HeaderText = "#";
            this.col_Numemric.MinimumWidth = 6;
            this.col_Numemric.Name = "col_Numemric";
            this.col_Numemric.ReadOnly = true;
            this.col_Numemric.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Name
            // 
            this.col_Name.FillWeight = 118.3155F;
            this.col_Name.HeaderText = "Name";
            this.col_Name.MinimumWidth = 6;
            this.col_Name.Name = "col_Name";
            this.col_Name.ReadOnly = true;
            this.col_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Img
            // 
            this.col_Img.FillWeight = 118.3155F;
            this.col_Img.HeaderText = "Image";
            this.col_Img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_Img.MinimumWidth = 6;
            this.col_Img.Name = "col_Img";
            this.col_Img.ReadOnly = true;
            this.col_Img.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_Category
            // 
            this.col_Category.HeaderText = "Category";
            this.col_Category.MinimumWidth = 6;
            this.col_Category.Name = "col_Category";
            this.col_Category.ReadOnly = true;
            this.col_Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Quanity
            // 
            this.col_Quanity.FillWeight = 118.3155F;
            this.col_Quanity.HeaderText = "Quanity";
            this.col_Quanity.MinimumWidth = 6;
            this.col_Quanity.Name = "col_Quanity";
            this.col_Quanity.ReadOnly = true;
            this.col_Quanity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Price
            // 
            this.col_Price.FillWeight = 118.3155F;
            this.col_Price.HeaderText = "Price";
            this.col_Price.MinimumWidth = 6;
            this.col_Price.Name = "col_Price";
            this.col_Price.ReadOnly = true;
            this.col_Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UFC_PurchaseItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtgvProducts);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UFC_PurchaseItems";
            this.Size = new System.Drawing.Size(985, 580);
            this.Load += new System.EventHandler(this.UFC_PurchaseItems_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearchItems;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteItems;
        private System.Windows.Forms.DataGridView dtgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Numemric;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewImageColumn col_Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quanity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Price;
    }
}
