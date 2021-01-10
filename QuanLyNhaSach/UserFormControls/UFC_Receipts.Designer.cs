
namespace QuanLyNhaSach.UserFormControls
{
    partial class UFC_Receipts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.lvDetail = new System.Windows.Forms.ListView();
            this.col_Name = new System.Windows.Forms.ColumnHeader();
            this.col_Quanity = new System.Windows.Forms.ColumnHeader();
            this.col_Amount = new System.Windows.Forms.ColumnHeader();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtInvoid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvBills = new System.Windows.Forms.DataGridView();
            this.col_Numeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 580);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(975, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 580);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 570);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 10);
            this.panel4.TabIndex = 3;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btnDelete);
            this.panelRight.Controls.Add(this.btnClear);
            this.panelRight.Controls.Add(this.btnSave);
            this.panelRight.Controls.Add(this.cbCustomer);
            this.panelRight.Controls.Add(this.lvDetail);
            this.panelRight.Controls.Add(this.txtTotal);
            this.panelRight.Controls.Add(this.txtDate);
            this.panelRight.Controls.Add(this.txtInvoid);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(648, 10);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(327, 560);
            this.panelRight.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(16, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(125, 505);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(227, 505);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(125, 72);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(196, 32);
            this.cbCustomer.TabIndex = 3;
            // 
            // lvDetail
            // 
            this.lvDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Name,
            this.col_Quanity,
            this.col_Amount});
            this.lvDetail.GridLines = true;
            this.lvDetail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDetail.HideSelection = false;
            this.lvDetail.Location = new System.Drawing.Point(11, 208);
            this.lvDetail.MultiSelect = false;
            this.lvDetail.Name = "lvDetail";
            this.lvDetail.Size = new System.Drawing.Size(310, 291);
            this.lvDetail.TabIndex = 2;
            this.lvDetail.UseCompatibleStateImageBehavior = false;
            this.lvDetail.View = System.Windows.Forms.View.Details;
            // 
            // col_Name
            // 
            this.col_Name.Text = "Name";
            this.col_Name.Width = 130;
            // 
            // col_Quanity
            // 
            this.col_Quanity.Text = "Qty";
            this.col_Quanity.Width = 50;
            // 
            // col_Amount
            // 
            this.col_Amount.Text = "Amount";
            this.col_Amount.Width = 130;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(125, 152);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(196, 32);
            this.txtTotal.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(125, 114);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(196, 32);
            this.txtDate.TabIndex = 1;
            // 
            // txtInvoid
            // 
            this.txtInvoid.Location = new System.Drawing.Point(125, 30);
            this.txtInvoid.Name = "txtInvoid";
            this.txtInvoid.ReadOnly = true;
            this.txtInvoid.Size = new System.Drawing.Size(196, 32);
            this.txtInvoid.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label4.Location = new System.Drawing.Point(62, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(59, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Invoice No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(86)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(148, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details";
            // 
            // dtgvBills
            // 
            this.dtgvBills.AllowUserToAddRows = false;
            this.dtgvBills.AllowUserToDeleteRows = false;
            this.dtgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Numeric,
            this.col_ID,
            this.col_Customer,
            this.col_Date,
            this.col_Total});
            this.dtgvBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBills.Location = new System.Drawing.Point(10, 10);
            this.dtgvBills.MultiSelect = false;
            this.dtgvBills.Name = "dtgvBills";
            this.dtgvBills.ReadOnly = true;
            this.dtgvBills.RowHeadersVisible = false;
            this.dtgvBills.RowHeadersWidth = 51;
            this.dtgvBills.RowTemplate.Height = 29;
            this.dtgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBills.Size = new System.Drawing.Size(638, 560);
            this.dtgvBills.TabIndex = 5;
            this.dtgvBills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBills_CellDoubleClick);
            // 
            // col_Numeric
            // 
            this.col_Numeric.FillWeight = 26.73797F;
            this.col_Numeric.HeaderText = "#";
            this.col_Numeric.MinimumWidth = 6;
            this.col_Numeric.Name = "col_Numeric";
            this.col_Numeric.ReadOnly = true;
            this.col_Numeric.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Customer
            // 
            this.col_Customer.FillWeight = 118.3155F;
            this.col_Customer.HeaderText = "Customer";
            this.col_Customer.MinimumWidth = 6;
            this.col_Customer.Name = "col_Customer";
            this.col_Customer.ReadOnly = true;
            this.col_Customer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Date
            // 
            this.col_Date.FillWeight = 118.3155F;
            this.col_Date.HeaderText = "Date";
            this.col_Date.MinimumWidth = 6;
            this.col_Date.Name = "col_Date";
            this.col_Date.ReadOnly = true;
            this.col_Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_Total
            // 
            this.col_Total.FillWeight = 118.3155F;
            this.col_Total.HeaderText = "Total";
            this.col_Total.MinimumWidth = 6;
            this.col_Total.Name = "col_Total";
            this.col_Total.ReadOnly = true;
            this.col_Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UFC_Receipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtgvBills);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UFC_Receipts";
            this.Size = new System.Drawing.Size(985, 580);
            this.Load += new System.EventHandler(this.UFC_Receipts_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ListView lvDetail;
        private System.Windows.Forms.ColumnHeader col_Name;
        private System.Windows.Forms.ColumnHeader col_Quanity;
        private System.Windows.Forms.ColumnHeader col_Amount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dtgvBills;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Numeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Total;
    }
}
