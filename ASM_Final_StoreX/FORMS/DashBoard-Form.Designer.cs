namespace ASM_Final_StoreX.FORMS
{
    partial class DashBoard_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard_Form));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFromEmployee = new System.Windows.Forms.Button();
            this.btnFormCustomer = new System.Windows.Forms.Button();
            this.btnOrderDetail = new System.Windows.Forms.Button();
            this.btnFormOrders = new System.Windows.Forms.Button();
            this.btnFormProducts = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 59);
            this.panel2.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = global::ASM_Final_StoreX.Properties.Resources.log_out_icon_icons_com_50106;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(912, 6);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(104, 38);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Gray;
            this.lblUser.Location = new System.Drawing.Point(30, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(96, 29);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "ADMIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(465, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "STORE X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnFromEmployee);
            this.panel1.Controls.Add(this.btnFormCustomer);
            this.panel1.Controls.Add(this.btnOrderDetail);
            this.panel1.Controls.Add(this.btnFormOrders);
            this.panel1.Controls.Add(this.btnFormProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnFromEmployee
            // 
            this.btnFromEmployee.FlatAppearance.BorderSize = 0;
            this.btnFromEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromEmployee.Image = global::ASM_Final_StoreX.Properties.Resources.employee_card_identity_identification_id_school_back_education_icon_219905;
            this.btnFromEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFromEmployee.Location = new System.Drawing.Point(24, 6);
            this.btnFromEmployee.Name = "btnFromEmployee";
            this.btnFromEmployee.Size = new System.Drawing.Size(133, 41);
            this.btnFromEmployee.TabIndex = 1;
            this.btnFromEmployee.Text = "Employee";
            this.btnFromEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFromEmployee.UseVisualStyleBackColor = true;
            this.btnFromEmployee.Click += new System.EventHandler(this.btnFromEmployee_Click);
            // 
            // btnFormCustomer
            // 
            this.btnFormCustomer.FlatAppearance.BorderSize = 0;
            this.btnFormCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormCustomer.Image = global::ASM_Final_StoreX.Properties.Resources.customer_icon;
            this.btnFormCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormCustomer.Location = new System.Drawing.Point(204, 6);
            this.btnFormCustomer.Name = "btnFormCustomer";
            this.btnFormCustomer.Size = new System.Drawing.Size(132, 41);
            this.btnFormCustomer.TabIndex = 2;
            this.btnFormCustomer.Text = " Customer";
            this.btnFormCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormCustomer.UseVisualStyleBackColor = true;
            this.btnFormCustomer.Click += new System.EventHandler(this.btnFormCustomer_Click);
            // 
            // btnOrderDetail
            // 
            this.btnOrderDetail.FlatAppearance.BorderSize = 0;
            this.btnOrderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDetail.Image = global::ASM_Final_StoreX.Properties.Resources.orderdetail_icon;
            this.btnOrderDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderDetail.Location = new System.Drawing.Point(699, 6);
            this.btnOrderDetail.Name = "btnOrderDetail";
            this.btnOrderDetail.Size = new System.Drawing.Size(128, 39);
            this.btnOrderDetail.TabIndex = 5;
            this.btnOrderDetail.Text = "OrderDetail";
            this.btnOrderDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderDetail.UseVisualStyleBackColor = true;
            this.btnOrderDetail.Click += new System.EventHandler(this.btnOrderDetail_Click);
            // 
            // btnFormOrders
            // 
            this.btnFormOrders.FlatAppearance.BorderSize = 0;
            this.btnFormOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormOrders.Image = global::ASM_Final_StoreX.Properties.Resources.order_icon;
            this.btnFormOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormOrders.Location = new System.Drawing.Point(541, 7);
            this.btnFormOrders.Name = "btnFormOrders";
            this.btnFormOrders.Size = new System.Drawing.Size(117, 38);
            this.btnFormOrders.TabIndex = 4;
            this.btnFormOrders.Text = "Orders";
            this.btnFormOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormOrders.UseVisualStyleBackColor = true;
            this.btnFormOrders.Click += new System.EventHandler(this.btnFormOrders_Click);
            // 
            // btnFormProducts
            // 
            this.btnFormProducts.FlatAppearance.BorderSize = 0;
            this.btnFormProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormProducts.Image = global::ASM_Final_StoreX.Properties.Resources.Product_icon;
            this.btnFormProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormProducts.Location = new System.Drawing.Point(372, 7);
            this.btnFormProducts.Name = "btnFormProducts";
            this.btnFormProducts.Size = new System.Drawing.Size(125, 38);
            this.btnFormProducts.TabIndex = 3;
            this.btnFormProducts.Text = "Products";
            this.btnFormProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormProducts.UseVisualStyleBackColor = true;
            this.btnFormProducts.Click += new System.EventHandler(this.btnFormProducts_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 109);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1028, 497);
            this.panelDesktop.TabIndex = 1;
            // 
            // DashBoard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 606);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashBoard_Form_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFromEmployee;
        private System.Windows.Forms.Button btnFormCustomer;
        private System.Windows.Forms.Button btnOrderDetail;
        private System.Windows.Forms.Button btnFormOrders;
        private System.Windows.Forms.Button btnFormProducts;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnLogOut;
    }
}