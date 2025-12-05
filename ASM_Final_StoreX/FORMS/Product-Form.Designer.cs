namespace ASM_Final_StoreX.FORMS
{
    partial class Product_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockquantity = new System.Windows.Forms.TextBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel8.Location = new System.Drawing.Point(16, 422);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(203, 1);
            this.panel8.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel6.Location = new System.Drawing.Point(16, 291);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 1);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel5.Location = new System.Drawing.Point(16, 211);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 1);
            this.panel5.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtProductID);
            this.panel3.Controls.Add(this.lblProductName);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.txtProductName);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblCategory);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtStockquantity);
            this.panel3.Controls.Add(this.cbSupplier);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.cbCategory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 481);
            this.panel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel7.Location = new System.Drawing.Point(16, 358);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(203, 1);
            this.panel7.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel4.Location = new System.Drawing.Point(16, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 1);
            this.panel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Location = new System.Drawing.Point(15, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 1);
            this.panel2.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::ASM_Final_StoreX.Properties.Resources.search_icon;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(224, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // txtProductID
            // 
            this.txtProductID.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtProductID.Location = new System.Drawing.Point(15, 48);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(203, 20);
            this.txtProductID.TabIndex = 0;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblProductName.Location = new System.Drawing.Point(12, 106);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(105, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(121, 436);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 33);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtProductName.Location = new System.Drawing.Point(15, 125);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(203, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 436);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Supplier";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblCategory.Location = new System.Drawing.Point(12, 172);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(70, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(12, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label7.Location = new System.Drawing.Point(12, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Price";
            // 
            // txtStockquantity
            // 
            this.txtStockquantity.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtStockquantity.Location = new System.Drawing.Point(15, 403);
            this.txtStockquantity.Name = "txtStockquantity";
            this.txtStockquantity.Size = new System.Drawing.Size(203, 20);
            this.txtStockquantity.TabIndex = 6;
            // 
            // cbSupplier
            // 
            this.cbSupplier.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(15, 271);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(203, 21);
            this.cbSupplier.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtPrice.Location = new System.Drawing.Point(15, 339);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(203, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(15, 191);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(203, 21);
            this.cbCategory.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.dgvProduct);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 481);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(592, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 33);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(303, 52);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(643, 342);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(562, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "MANAGE PRODUCTS";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(903, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 25);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Product_Form";
            this.Text = "Product_Form";
            this.Load += new System.EventHandler(this.Product_Form_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockquantity;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
    }
}