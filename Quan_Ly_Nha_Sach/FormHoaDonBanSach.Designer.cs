namespace Quan_Ly_Nha_Sach
{
    partial class FormHoaDonBanSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMaKH = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.btnDeleteHoaDon = new System.Windows.Forms.Button();
            this.btnCapNhatHoaDon = new System.Windows.Forms.Button();
            this.btnXemChiTietHD = new System.Windows.Forms.Button();
            this.dataGVHoaDon = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLapCTHoaDon = new System.Windows.Forms.Button();
            this.btnCapNhatCTHoaDon = new System.Windows.Forms.Button();
            this.btnXoaCTHoaDon = new System.Windows.Forms.Button();
            this.dataGVCTHoaDon = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHoaDon)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCTHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(840, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn bán sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(16, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 88);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(512, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 168);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXemChiTietHD);
            this.panel3.Controls.Add(this.btnCapNhatHoaDon);
            this.panel3.Controls.Add(this.btnDeleteHoaDon);
            this.panel3.Controls.Add(this.btnLapHoaDon);
            this.panel3.Location = new System.Drawing.Point(16, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 74);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày lập hóa đơn:";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayLap.Location = new System.Drawing.Point(103, 62);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(108, 20);
            this.txtNgayLap.TabIndex = 2;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(103, 22);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(108, 20);
            this.txtMaHD.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Họ tên khách hàng:";
            // 
            // comboBoxMaKH
            // 
            this.comboBoxMaKH.FormattingEnabled = true;
            this.comboBoxMaKH.Location = new System.Drawing.Point(325, 21);
            this.comboBoxMaKH.Name = "comboBoxMaKH";
            this.comboBoxMaKH.Size = new System.Drawing.Size(159, 21);
            this.comboBoxMaKH.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.comboBoxMaKH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNgayLap);
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(325, 59);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(159, 20);
            this.txtTenKH.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGVHoaDon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các hóa đơn đã lập";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(840, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Chi tiết hóa đơn bán sách";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Location = new System.Drawing.Point(3, 3);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(226, 27);
            this.btnLapHoaDon.TabIndex = 0;
            this.btnLapHoaDon.Text = "Lập hóa đơn mới";
            this.btnLapHoaDon.UseVisualStyleBackColor = true;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // btnDeleteHoaDon
            // 
            this.btnDeleteHoaDon.Location = new System.Drawing.Point(258, 3);
            this.btnDeleteHoaDon.Name = "btnDeleteHoaDon";
            this.btnDeleteHoaDon.Size = new System.Drawing.Size(226, 27);
            this.btnDeleteHoaDon.TabIndex = 1;
            this.btnDeleteHoaDon.Text = "Xóa hóa đơn ";
            this.btnDeleteHoaDon.UseVisualStyleBackColor = true;
            this.btnDeleteHoaDon.Click += new System.EventHandler(this.btnDeleteHoaDon_Click);
            // 
            // btnCapNhatHoaDon
            // 
            this.btnCapNhatHoaDon.Location = new System.Drawing.Point(3, 44);
            this.btnCapNhatHoaDon.Name = "btnCapNhatHoaDon";
            this.btnCapNhatHoaDon.Size = new System.Drawing.Size(226, 27);
            this.btnCapNhatHoaDon.TabIndex = 2;
            this.btnCapNhatHoaDon.Text = "Cập nhật hóa đơn";
            this.btnCapNhatHoaDon.UseVisualStyleBackColor = true;
            this.btnCapNhatHoaDon.Click += new System.EventHandler(this.btnCapNhatHoaDon_Click);
            // 
            // btnXemChiTietHD
            // 
            this.btnXemChiTietHD.Location = new System.Drawing.Point(258, 44);
            this.btnXemChiTietHD.Name = "btnXemChiTietHD";
            this.btnXemChiTietHD.Size = new System.Drawing.Size(226, 27);
            this.btnXemChiTietHD.TabIndex = 3;
            this.btnXemChiTietHD.Text = "Xem chi tiết hóa đơn";
            this.btnXemChiTietHD.UseVisualStyleBackColor = true;
            this.btnXemChiTietHD.Click += new System.EventHandler(this.btnXemChiTietHD_Click);
            // 
            // dataGVHoaDon
            // 
            this.dataGVHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVHoaDon.Location = new System.Drawing.Point(3, 16);
            this.dataGVHoaDon.Name = "dataGVHoaDon";
            this.dataGVHoaDon.Size = new System.Drawing.Size(338, 149);
            this.dataGVHoaDon.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGVCTHoaDon);
            this.panel4.Location = new System.Drawing.Point(12, 263);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(840, 214);
            this.panel4.TabIndex = 4;
            // 
            // btnLapCTHoaDon
            // 
            this.btnLapCTHoaDon.Location = new System.Drawing.Point(12, 483);
            this.btnLapCTHoaDon.Name = "btnLapCTHoaDon";
            this.btnLapCTHoaDon.Size = new System.Drawing.Size(165, 28);
            this.btnLapCTHoaDon.TabIndex = 5;
            this.btnLapCTHoaDon.Text = "Lập chi tiết hóa đơn";
            this.btnLapCTHoaDon.UseVisualStyleBackColor = true;
            this.btnLapCTHoaDon.Click += new System.EventHandler(this.btnLapCTHoaDon_Click);
            // 
            // btnCapNhatCTHoaDon
            // 
            this.btnCapNhatCTHoaDon.Location = new System.Drawing.Point(370, 483);
            this.btnCapNhatCTHoaDon.Name = "btnCapNhatCTHoaDon";
            this.btnCapNhatCTHoaDon.Size = new System.Drawing.Size(165, 28);
            this.btnCapNhatCTHoaDon.TabIndex = 6;
            this.btnCapNhatCTHoaDon.Text = "Cập nhật chi tiết hóa đơn";
            this.btnCapNhatCTHoaDon.UseVisualStyleBackColor = true;
            this.btnCapNhatCTHoaDon.Click += new System.EventHandler(this.btnCapNhatCTHoaDon_Click);
            // 
            // btnXoaCTHoaDon
            // 
            this.btnXoaCTHoaDon.Location = new System.Drawing.Point(691, 483);
            this.btnXoaCTHoaDon.Name = "btnXoaCTHoaDon";
            this.btnXoaCTHoaDon.Size = new System.Drawing.Size(165, 28);
            this.btnXoaCTHoaDon.TabIndex = 7;
            this.btnXoaCTHoaDon.Text = "Xóa chi tiết hóa đơn";
            this.btnXoaCTHoaDon.UseVisualStyleBackColor = true;
            this.btnXoaCTHoaDon.Click += new System.EventHandler(this.btnXoaCTHoaDon_Click);
            // 
            // dataGVCTHoaDon
            // 
            this.dataGVCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCTHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVCTHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dataGVCTHoaDon.Name = "dataGVCTHoaDon";
            this.dataGVCTHoaDon.Size = new System.Drawing.Size(840, 214);
            this.dataGVCTHoaDon.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã hóa đơn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ngày lập hóa đơn:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMaHD.Location = new System.Drawing.Point(92, 229);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(65, 12);
            this.lblMaHD.TabIndex = 10;
            this.lblMaHD.Text = "HD000";
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNgayLapHD.Location = new System.Drawing.Point(261, 229);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(114, 13);
            this.lblNgayLapHD.TabIndex = 11;
            this.lblNgayLapHD.Text = "00/00/0000";
            // 
            // FormHoaDonBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 523);
            this.Controls.Add(this.lblNgayLapHD);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoaCTHoaDon);
            this.Controls.Add(this.btnCapNhatCTHoaDon);
            this.Controls.Add(this.btnLapCTHoaDon);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormHoaDonBanSach";
            this.Text = "FormHoaDonBanSach";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHoaDon)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCTHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ComboBox comboBoxMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtNgayLap;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXemChiTietHD;
        private System.Windows.Forms.Button btnCapNhatHoaDon;
        private System.Windows.Forms.Button btnDeleteHoaDon;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGVHoaDon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLapCTHoaDon;
        private System.Windows.Forms.Button btnCapNhatCTHoaDon;
        private System.Windows.Forms.Button btnXoaCTHoaDon;
        private System.Windows.Forms.DataGridView dataGVCTHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblNgayLapHD;
    }
}