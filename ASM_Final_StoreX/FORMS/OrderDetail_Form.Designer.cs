namespace ASM_Final_StoreX.FORMS
{
    partial class OrderDetail_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuanOfProduct = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotalOrder);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtQuanOfProduct);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.dgvOrderDetail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtOrderID);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 535);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel6.Location = new System.Drawing.Point(415, 131);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(172, 1);
            this.panel6.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Location = new System.Drawing.Point(172, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Total Amount of the Order";
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtTotalOrder.Location = new System.Drawing.Point(414, 112);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.Size = new System.Drawing.Size(172, 20);
            this.txtTotalOrder.TabIndex = 45;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel7.Location = new System.Drawing.Point(414, 96);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 1);
            this.panel7.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(168, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Total number of products of Order";
            // 
            // txtQuanOfProduct
            // 
            this.txtQuanOfProduct.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtQuanOfProduct.Location = new System.Drawing.Point(413, 77);
            this.txtQuanOfProduct.Name = "txtQuanOfProduct";
            this.txtQuanOfProduct.Size = new System.Drawing.Size(172, 20);
            this.txtQuanOfProduct.TabIndex = 42;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(341, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(170, 142);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.Size = new System.Drawing.Size(445, 302);
            this.dgvOrderDetail.TabIndex = 1;
            this.dgvOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(474, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ORDER DETAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(167, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Order ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Location = new System.Drawing.Point(171, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 1);
            this.panel2.TabIndex = 13;
            // 
            // txtOrderID
            // 
            this.txtOrderID.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtOrderID.Location = new System.Drawing.Point(170, 41);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(185, 20);
            this.txtOrderID.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::ASM_Final_StoreX.Properties.Resources.search_icon;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(362, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblCustomer.Location = new System.Drawing.Point(26, 170);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(64, 16);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Product ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(142, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.cbProduct);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtQuantity);
            this.panel3.Controls.Add(this.lblCustomer);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(677, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 535);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel4.Location = new System.Drawing.Point(31, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 1);
            this.panel4.TabIndex = 18;
            // 
            // cbProduct
            // 
            this.cbProduct.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(30, 189);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(185, 21);
            this.cbProduct.TabIndex = 0;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel5.Location = new System.Drawing.Point(30, 281);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 1);
            this.panel5.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label5.Location = new System.Drawing.Point(26, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtQuantity.Location = new System.Drawing.Point(29, 262);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(185, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(31, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // OrderDetail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "OrderDetail_Form";
            this.Text = "OrderDetail_Form";
            this.Load += new System.EventHandler(this.OrderDetail_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuanOfProduct;
    }
}