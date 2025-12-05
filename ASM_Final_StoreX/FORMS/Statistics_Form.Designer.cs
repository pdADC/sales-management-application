namespace ASM_Final_StoreX.FORMS
{
    partial class Statistics_Form
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
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Location = new System.Drawing.Point(272, 134);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.Size = new System.Drawing.Size(451, 302);
            this.dgvStatistic.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(423, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "STATISTIC";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerOrderDate);
            this.panel1.Controls.Add(this.rbtnMonth);
            this.panel1.Controls.Add(this.rbtnDay);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRevenue);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTotalOrder);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Controls.Add(this.dgvStatistic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 567);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(421, 102);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerOrderDate.TabIndex = 43;
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.rbtnMonth.Location = new System.Drawing.Point(488, 70);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(55, 17);
            this.rbtnMonth.TabIndex = 42;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.rbtnDay.Location = new System.Drawing.Point(421, 70);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(44, 17);
            this.rbtnDay.TabIndex = 41;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel5.Location = new System.Drawing.Point(458, 504);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 1);
            this.panel5.TabIndex = 40;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Location = new System.Drawing.Point(279, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Total revenue:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtRevenue
            // 
            this.txtRevenue.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtRevenue.Location = new System.Drawing.Point(457, 485);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(172, 20);
            this.txtRevenue.TabIndex = 39;
            this.txtRevenue.TextChanged += new System.EventHandler(this.txtRevenue_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.Location = new System.Drawing.Point(457, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 1);
            this.panel3.TabIndex = 37;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label5.Location = new System.Drawing.Point(275, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Total number of orders:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtTotalOrder.Location = new System.Drawing.Point(456, 450);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.Size = new System.Drawing.Size(172, 20);
            this.txtTotalOrder.TabIndex = 36;
            this.txtTotalOrder.TextChanged += new System.EventHandler(this.txtTotalOrder_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(291, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Statistics by:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblCustomer.Location = new System.Drawing.Point(302, 104);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(44, 16);
            this.lblCustomer.TabIndex = 23;
            this.lblCustomer.Text = "Date:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::ASM_Final_StoreX.Properties.Resources.search_icon;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(562, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Statistics_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 567);
            this.Controls.Add(this.panel1);
            this.Name = "Statistics_Form";
            this.Text = "Statistics_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
    }
}