
namespace QuanLyNhaSach.UserFormControls
{
    partial class UFC_Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UFC_Categories));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picCate = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCateID = new System.Windows.Forms.TextBox();
            this.txtNameCate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvCategories = new System.Windows.Forms.DataGridView();
            this.col_Numeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDCate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearchCate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchCate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategories)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 570);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 10);
            this.panel4.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(975, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 570);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 10);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 580);
            this.panel1.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.picCate);
            this.panel7.Controls.Add(this.btnSave);
            this.panel7.Controls.Add(this.btnClear);
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Controls.Add(this.btnAdd);
            this.panel7.Controls.Add(this.txtCateID);
            this.panel7.Controls.Add(this.txtNameCate);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(642, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(333, 510);
            this.panel7.TabIndex = 19;
            // 
            // picCate
            // 
            this.picCate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCate.Image = ((System.Drawing.Image)(resources.GetObject("picCate.Image")));
            this.picCate.Location = new System.Drawing.Point(9, 157);
            this.picCate.Name = "picCate";
            this.picCate.Size = new System.Drawing.Size(316, 251);
            this.picCate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCate.TabIndex = 33;
            this.picCate.TabStop = false;
            this.picCate.Click += new System.EventHandler(this.picCate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(232, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 40);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(120, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 40);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(9, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(318, 40);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(8, 414);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 40);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCateID
            // 
            this.txtCateID.Location = new System.Drawing.Point(80, 6);
            this.txtCateID.Name = "txtCateID";
            this.txtCateID.ReadOnly = true;
            this.txtCateID.Size = new System.Drawing.Size(241, 34);
            this.txtCateID.TabIndex = 27;
            // 
            // txtNameCate
            // 
            this.txtNameCate.Location = new System.Drawing.Point(80, 55);
            this.txtNameCate.Name = "txtNameCate";
            this.txtNameCate.Size = new System.Drawing.Size(241, 34);
            this.txtNameCate.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "Image:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Name:";
            // 
            // dtgvCategories
            // 
            this.dtgvCategories.AllowUserToAddRows = false;
            this.dtgvCategories.AllowUserToDeleteRows = false;
            this.dtgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Numeric,
            this.col_IDCate,
            this.col_Name,
            this.col_Image});
            this.dtgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCategories.Location = new System.Drawing.Point(10, 60);
            this.dtgvCategories.MultiSelect = false;
            this.dtgvCategories.Name = "dtgvCategories";
            this.dtgvCategories.ReadOnly = true;
            this.dtgvCategories.RowHeadersVisible = false;
            this.dtgvCategories.RowHeadersWidth = 51;
            this.dtgvCategories.RowTemplate.Height = 29;
            this.dtgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCategories.Size = new System.Drawing.Size(632, 510);
            this.dtgvCategories.TabIndex = 20;
            this.dtgvCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategories_CellDoubleClick);
            // 
            // col_Numeric
            // 
            this.col_Numeric.FillWeight = 32.08556F;
            this.col_Numeric.HeaderText = "#";
            this.col_Numeric.MinimumWidth = 6;
            this.col_Numeric.Name = "col_Numeric";
            this.col_Numeric.ReadOnly = true;
            this.col_Numeric.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_IDCate
            // 
            this.col_IDCate.FillWeight = 122.6381F;
            this.col_IDCate.HeaderText = "ID";
            this.col_IDCate.MinimumWidth = 6;
            this.col_IDCate.Name = "col_IDCate";
            this.col_IDCate.ReadOnly = true;
            this.col_IDCate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Name
            // 
            this.col_Name.FillWeight = 122.6381F;
            this.col_Name.HeaderText = "Name";
            this.col_Name.MinimumWidth = 6;
            this.col_Name.Name = "col_Name";
            this.col_Name.ReadOnly = true;
            this.col_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Image
            // 
            this.col_Image.FillWeight = 122.6381F;
            this.col_Image.HeaderText = "Image";
            this.col_Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.col_Image.MinimumWidth = 6;
            this.col_Image.Name = "col_Image";
            this.col_Image.ReadOnly = true;
            this.col_Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2005, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(2245, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 34);
            this.textBox1.TabIndex = 4;
            // 
            // btnSearchCate
            // 
            this.btnSearchCate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchCate.FlatAppearance.BorderSize = 0;
            this.btnSearchCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCate.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCate.Image")));
            this.btnSearchCate.Location = new System.Drawing.Point(922, 0);
            this.btnSearchCate.Name = "btnSearchCate";
            this.btnSearchCate.Size = new System.Drawing.Size(43, 50);
            this.btnSearchCate.TabIndex = 5;
            this.btnSearchCate.UseVisualStyleBackColor = true;
            this.btnSearchCate.Click += new System.EventHandler(this.btnSearchCate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(2088, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 36);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1397, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(1480, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 34);
            this.txtSearch.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(163)))), ((int)(((byte)(195)))));
            this.panel5.Controls.Add(this.txtSearchCate);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.btnSearchCate);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(965, 50);
            this.panel5.TabIndex = 18;
            // 
            // txtSearchCate
            // 
            this.txtSearchCate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCate.Location = new System.Drawing.Point(715, 8);
            this.txtSearchCate.Name = "txtSearchCate";
            this.txtSearchCate.Size = new System.Drawing.Size(201, 34);
            this.txtSearchCate.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(632, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Search:";
            // 
            // UFC_Categories
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dtgvCategories);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UFC_Categories";
            this.Size = new System.Drawing.Size(985, 580);
            this.Load += new System.EventHandler(this.UFC_Categories_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategories)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNameCate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picCate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearchCate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchCate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCateID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Numeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewImageColumn col_Image;
    }
}
