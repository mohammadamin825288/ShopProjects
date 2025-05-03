
namespace shopProject
{
    partial class frmFactor
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnProductFind = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberOfOrders = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCustomerFind = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerLastname = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFactor = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grv1 = new System.Windows.Forms.DataGridView();
            this.btnNewFactor = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1354, 722);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(561, 638);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 56);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = " ثبت اطلاعات خرید\r\n\r\n>>";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txtTotalPrice);
            this.groupBox6.Location = new System.Drawing.Point(24, 623);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(516, 85);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(431, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 21);
            this.label14.TabIndex = 2;
            this.label14.Text = "مبلغ کل";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(53, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "ریال";
            this.label15.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalPrice.Location = new System.Drawing.Point(110, 28);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(299, 28);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnProductFind);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtNumberOfOrders);
            this.groupBox5.Controls.Add(this.txtInventory);
            this.groupBox5.Controls.Add(this.txtPrice);
            this.groupBox5.Controls.Add(this.txtProductName);
            this.groupBox5.Controls.Add(this.txtProductCode);
            this.groupBox5.Location = new System.Drawing.Point(714, 395);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(630, 210);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // btnProductFind
            // 
            this.btnProductFind.Location = new System.Drawing.Point(329, 24);
            this.btnProductFind.Name = "btnProductFind";
            this.btnProductFind.Size = new System.Drawing.Size(63, 28);
            this.btnProductFind.TabIndex = 3;
            this.btnProductFind.Text = "...";
            this.btnProductFind.UseVisualStyleBackColor = true;
            this.btnProductFind.Click += new System.EventHandler(this.btnProductFind_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(230, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "قیمت ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(570, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "تعداد";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(558, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "موجودی";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = " نام کالا";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "کد کالا";
            // 
            // txtNumberOfOrders
            // 
            this.txtNumberOfOrders.Location = new System.Drawing.Point(338, 147);
            this.txtNumberOfOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberOfOrders.Name = "txtNumberOfOrders";
            this.txtNumberOfOrders.Size = new System.Drawing.Size(211, 28);
            this.txtNumberOfOrders.TabIndex = 1;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(338, 85);
            this.txtInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(211, 28);
            this.txtInventory.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(36, 81);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(162, 28);
            this.txtPrice.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(36, 29);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(162, 28);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.SystemColors.Info;
            this.txtProductCode.Location = new System.Drawing.Point(398, 24);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(151, 28);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCustomerFind);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtphone);
            this.groupBox4.Controls.Add(this.txtCustomerCode);
            this.groupBox4.Controls.Add(this.txtAddress);
            this.groupBox4.Controls.Add(this.txtCustomerLastname);
            this.groupBox4.Controls.Add(this.txtCustomerName);
            this.groupBox4.Location = new System.Drawing.Point(714, 166);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(640, 210);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnCustomerFind
            // 
            this.btnCustomerFind.Location = new System.Drawing.Point(248, 29);
            this.btnCustomerFind.Name = "btnCustomerFind";
            this.btnCustomerFind.Size = new System.Drawing.Size(63, 28);
            this.btnCustomerFind.TabIndex = 3;
            this.btnCustomerFind.Text = "...";
            this.btnCustomerFind.UseVisualStyleBackColor = true;
            this.btnCustomerFind.Click += new System.EventHandler(this.btnCustomerFind_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(572, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "آدرس";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "نام خانوادگی";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "تلفن";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(548, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "کد اشتراک";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "نام";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(429, 134);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(120, 28);
            this.txtphone.TabIndex = 1;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomerCode.Location = new System.Drawing.Point(317, 29);
            this.txtCustomerCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(222, 28);
            this.txtCustomerCode.TabIndex = 1;
            this.txtCustomerCode.TextChanged += new System.EventHandler(this.txtCustomerCode_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(7, 113);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(211, 88);
            this.txtAddress.TabIndex = 1;
            // 
            // txtCustomerLastname
            // 
            this.txtCustomerLastname.Location = new System.Drawing.Point(7, 64);
            this.txtCustomerLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerLastname.Name = "txtCustomerLastname";
            this.txtCustomerLastname.Size = new System.Drawing.Size(211, 28);
            this.txtCustomerLastname.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(429, 85);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(120, 28);
            this.txtCustomerName.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtFactor);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Location = new System.Drawing.Point(714, 29);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(630, 129);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "شماره فاکتور";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "تاریخ";
            // 
            // txtFactor
            // 
            this.txtFactor.BackColor = System.Drawing.SystemColors.Info;
            this.txtFactor.Location = new System.Drawing.Point(301, 49);
            this.txtFactor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.Size = new System.Drawing.Size(211, 28);
            this.txtFactor.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(0, 49);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(228, 28);
            this.txtDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grv1);
            this.groupBox2.Location = new System.Drawing.Point(16, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(674, 580);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فهرست خرید";
            // 
            // grv1
            // 
            this.grv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv1.Location = new System.Drawing.Point(0, 25);
            this.grv1.Name = "grv1";
            this.grv1.RowHeadersWidth = 51;
            this.grv1.RowTemplate.Height = 24;
            this.grv1.Size = new System.Drawing.Size(655, 548);
            this.grv1.TabIndex = 0;
            // 
            // btnNewFactor
            // 
            this.btnNewFactor.Location = new System.Drawing.Point(72, 768);
            this.btnNewFactor.Name = "btnNewFactor";
            this.btnNewFactor.Size = new System.Drawing.Size(232, 67);
            this.btnNewFactor.TabIndex = 1;
            this.btnNewFactor.Text = "فاکتور جدید";
            this.btnNewFactor.UseVisualStyleBackColor = true;
            this.btnNewFactor.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(368, 768);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(232, 67);
            this.btnSaveClose.TabIndex = 1;
            this.btnSaveClose.Text = "ذخیره اطلاعات کل و خروج";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            // 
            // frmFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 851);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnNewFactor);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFactor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم فاکتور";
            this.Load += new System.EventHandler(this.frmFactor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnProductFind;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberOfOrders;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCustomerFind;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerLastname;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFactor;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grv1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewFactor;
        private System.Windows.Forms.Button btnSaveClose;
    }
}