
namespace QuanLyNhaSach.UserFormControls
{
    partial class UFC_SellItems
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
            this.components = new System.ComponentModel.Container();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lvSellItems = new System.Windows.Forms.ListView();
            this.col_ItemName = new System.Windows.Forms.ColumnHeader();
            this.col_Quanity = new System.Windows.Forms.ColumnHeader();
            this.col_Amount = new System.Windows.Forms.ColumnHeader();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtgvProducts = new System.Windows.Forms.DataGridView();
            this.col_Numeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Gainsboro;
            this.panelRight.Controls.Add(this.lvSellItems);
            this.panelRight.Controls.Add(this.panel4);
            this.panelRight.Controls.Add(this.panel3);
            this.panelRight.Controls.Add(this.panel2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(725, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(260, 580);
            this.panelRight.TabIndex = 0;
            // 
            // lvSellItems
            // 
            this.lvSellItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ItemName,
            this.col_Quanity,
            this.col_Amount});
            this.lvSellItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSellItems.FullRowSelect = true;
            this.lvSellItems.GridLines = true;
            this.lvSellItems.HideSelection = false;
            this.lvSellItems.Location = new System.Drawing.Point(10, 0);
            this.lvSellItems.MultiSelect = false;
            this.lvSellItems.Name = "lvSellItems";
            this.lvSellItems.Size = new System.Drawing.Size(240, 334);
            this.lvSellItems.TabIndex = 3;
            this.lvSellItems.UseCompatibleStateImageBehavior = false;
            this.lvSellItems.View = System.Windows.Forms.View.Details;
            // 
            // col_ItemName
            // 
            this.col_ItemName.Text = "Name";
            this.col_ItemName.Width = 100;
            // 
            // col_Quanity
            // 
            this.col_Quanity.Text = "Qty";
            this.col_Quanity.Width = 50;
            // 
            // col_Amount
            // 
            this.col_Amount.Text = "Amount";
            this.col_Amount.Width = 90;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbCustomer);
            this.panel4.Controls.Add(this.btnFinish);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lbTotal);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 246);
            this.panel4.TabIndex = 2;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(11, 162);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(224, 32);
            this.cbCustomer.TabIndex = 3;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(134, 200);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(100, 30);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Brown;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(6, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(163)))), ((int)(((byte)(195)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(240, 5);
            this.panel8.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(11, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customer:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.lbTotal.Location = new System.Drawing.Point(6, 101);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 34);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAdd);
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 40);
            this.panel7.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnAdd.Location = new System.Drawing.Point(134, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(11, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(163)))), ((int)(((byte)(195)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 5);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(163)))), ((int)(((byte)(195)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Location = new System.Drawing.Point(0, 236);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 10);
            this.panel5.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(163)))), ((int)(((byte)(195)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(250, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 580);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(163)))), ((int)(((byte)(195)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 580);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(-187, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quanity:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvProducts);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 580);
            this.panel1.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtQuantity);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 509);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(725, 71);
            this.panel9.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(136, 15);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(583, 32);
            this.txtQuantity.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quanity:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtgvProducts
            // 
            this.dtgvProducts.AllowUserToAddRows = false;
            this.dtgvProducts.AllowUserToDeleteRows = false;
            this.dtgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Numeric,
            this.col_Name,
            this.col_Img,
            this.col_Category,
            this.col_Stock,
            this.col_Price});
            this.dtgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dtgvProducts.MultiSelect = false;
            this.dtgvProducts.Name = "dtgvProducts";
            this.dtgvProducts.ReadOnly = true;
            this.dtgvProducts.RowHeadersVisible = false;
            this.dtgvProducts.RowHeadersWidth = 51;
            this.dtgvProducts.RowTemplate.Height = 29;
            this.dtgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProducts.Size = new System.Drawing.Size(725, 509);
            this.dtgvProducts.TabIndex = 6;
            // 
            // col_Numeric
            // 
            this.col_Numeric.FillWeight = 26.73796F;
            this.col_Numeric.HeaderText = "#";
            this.col_Numeric.MinimumWidth = 6;
            this.col_Numeric.Name = "col_Numeric";
            this.col_Numeric.ReadOnly = true;
            this.col_Numeric.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Name
            // 
            this.col_Name.FillWeight = 138.5163F;
            this.col_Name.HeaderText = "Name";
            this.col_Name.MinimumWidth = 6;
            this.col_Name.Name = "col_Name";
            this.col_Name.ReadOnly = true;
            this.col_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Img
            // 
            this.col_Img.FillWeight = 138.5163F;
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
            // col_Stock
            // 
            this.col_Stock.FillWeight = 57.71307F;
            this.col_Stock.HeaderText = "Stock";
            this.col_Stock.MinimumWidth = 6;
            this.col_Stock.Name = "col_Stock";
            this.col_Stock.ReadOnly = true;
            this.col_Stock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Price
            // 
            this.col_Price.FillWeight = 138.5163F;
            this.col_Price.HeaderText = "Price";
            this.col_Price.MinimumWidth = 6;
            this.col_Price.Name = "col_Price";
            this.col_Price.ReadOnly = true;
            this.col_Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UFC_SellItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRight);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UFC_SellItems";
            this.Size = new System.Drawing.Size(985, 580);
            this.Load += new System.EventHandler(this.UFC_SellItems_Load);
            this.panelRight.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lvSellItems;
        private System.Windows.Forms.ColumnHeader col_ItemName;
        private System.Windows.Forms.ColumnHeader col_Quanity;
        private System.Windows.Forms.ColumnHeader col_Amount;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dtgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Numeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewImageColumn col_Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Price;
    }
}
