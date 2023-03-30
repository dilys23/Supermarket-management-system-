namespace QuanLySieuThi1
{
    partial class DetailForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHet = new System.Windows.Forms.RadioButton();
            this.rdCon = new System.Windows.Forms.RadioButton();
            this.cbbSX = new System.Windows.Forms.ComboBox();
            this.cbbMatHang = new System.Windows.Forms.ComboBox();
            this.Ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBBNhaSX = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHet);
            this.groupBox1.Controls.Add(this.rdCon);
            this.groupBox1.Controls.Add(this.cbbSX);
            this.groupBox1.Controls.Add(this.cbbMatHang);
            this.groupBox1.Controls.Add(this.Ngaynhap);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBBNhaSX);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // rdHet
            // 
            this.rdHet.AutoSize = true;
            this.rdHet.Location = new System.Drawing.Point(639, 148);
            this.rdHet.Name = "rdHet";
            this.rdHet.Size = new System.Drawing.Size(82, 20);
            this.rdHet.TabIndex = 12;
            this.rdHet.TabStop = true;
            this.rdHet.Text = "Hết hàng";
            this.rdHet.UseVisualStyleBackColor = true;
            // 
            // rdCon
            // 
            this.rdCon.AutoSize = true;
            this.rdCon.Location = new System.Drawing.Point(529, 148);
            this.rdCon.Name = "rdCon";
            this.rdCon.Size = new System.Drawing.Size(85, 20);
            this.rdCon.TabIndex = 11;
            this.rdCon.TabStop = true;
            this.rdCon.Text = "Còn hàng";
            this.rdCon.UseVisualStyleBackColor = true;
            // 
            // cbbSX
            // 
            this.cbbSX.FormattingEnabled = true;
            this.cbbSX.Location = new System.Drawing.Point(529, 88);
            this.cbbSX.Name = "cbbSX";
            this.cbbSX.Size = new System.Drawing.Size(121, 24);
            this.cbbSX.TabIndex = 10;
            // 
            // cbbMatHang
            // 
            this.cbbMatHang.FormattingEnabled = true;
            this.cbbMatHang.Location = new System.Drawing.Point(529, 48);
            this.cbbMatHang.Name = "cbbMatHang";
            this.cbbMatHang.Size = new System.Drawing.Size(121, 24);
            this.cbbMatHang.TabIndex = 9;
            this.cbbMatHang.SelectedIndexChanged += new System.EventHandler(this.cbbMatHang_SelectedIndexChanged);
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Ngaynhap.Location = new System.Drawing.Point(110, 138);
            this.Ngaynhap.Name = "Ngaynhap";
            this.Ngaynhap.Size = new System.Drawing.Size(167, 22);
            this.Ngaynhap.TabIndex = 8;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(110, 90);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(167, 22);
            this.txtTenSP.TabIndex = 7;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(110, 42);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(167, 22);
            this.txtMaSP.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tình trạng";
            // 
            // CBBNhaSX
            // 
            this.CBBNhaSX.AutoSize = true;
            this.CBBNhaSX.Location = new System.Drawing.Point(436, 91);
            this.CBBNhaSX.Name = "CBBNhaSX";
            this.CBBNhaSX.Size = new System.Drawing.Size(52, 16);
            this.CBBNhaSX.TabIndex = 4;
            this.CBBNhaSX.Text = "Nhà SX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(230, 269);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(68, 33);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(422, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 33);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHet;
        private System.Windows.Forms.RadioButton rdCon;
        private System.Windows.Forms.ComboBox cbbSX;
        private System.Windows.Forms.ComboBox cbbMatHang;
        private System.Windows.Forms.DateTimePicker Ngaynhap;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CBBNhaSX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}