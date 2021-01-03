namespace Quan_Ly_Nha_Sach
{
    partial class FormPhieuNhapSach
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
            this.dataGVPhieuNhapSach = new System.Windows.Forms.DataGridView();
            this.btnLapPhieuNhapSach = new System.Windows.Forms.Button();
            this.btnCapNhatPhieuNhapSach = new System.Windows.Forms.Button();
            this.btnXoaPhieuNhapSach = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGVCTPhieuNhapSach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.btnLapCTPhieuNhapSach = new System.Windows.Forms.Button();
            this.btnCapNhatCTPhieuNhapSach = new System.Windows.Forms.Button();
            this.btnXoaCTPhieuNhapSach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaPN = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.txtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPhieuNhapSach)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCTPhieuNhapSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu nhập sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGVPhieuNhapSach);
            this.panel1.Location = new System.Drawing.Point(331, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 123);
            this.panel1.TabIndex = 1;
            // 
            // dataGVPhieuNhapSach
            // 
            this.dataGVPhieuNhapSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVPhieuNhapSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVPhieuNhapSach.Location = new System.Drawing.Point(0, 0);
            this.dataGVPhieuNhapSach.Name = "dataGVPhieuNhapSach";
            this.dataGVPhieuNhapSach.Size = new System.Drawing.Size(521, 123);
            this.dataGVPhieuNhapSach.TabIndex = 3;
            // 
            // btnLapPhieuNhapSach
            // 
            this.btnLapPhieuNhapSach.Location = new System.Drawing.Point(21, 99);
            this.btnLapPhieuNhapSach.Name = "btnLapPhieuNhapSach";
            this.btnLapPhieuNhapSach.Size = new System.Drawing.Size(155, 23);
            this.btnLapPhieuNhapSach.TabIndex = 0;
            this.btnLapPhieuNhapSach.Text = "Lập phiếu nhập sách";
            this.btnLapPhieuNhapSach.UseVisualStyleBackColor = true;
            this.btnLapPhieuNhapSach.Click += new System.EventHandler(this.btnLapPhieuNhapSach_Click);
            // 
            // btnCapNhatPhieuNhapSach
            // 
            this.btnCapNhatPhieuNhapSach.Location = new System.Drawing.Point(182, 99);
            this.btnCapNhatPhieuNhapSach.Name = "btnCapNhatPhieuNhapSach";
            this.btnCapNhatPhieuNhapSach.Size = new System.Drawing.Size(143, 23);
            this.btnCapNhatPhieuNhapSach.TabIndex = 1;
            this.btnCapNhatPhieuNhapSach.Text = "Cập nhật phiếu nhập sách";
            this.btnCapNhatPhieuNhapSach.UseVisualStyleBackColor = true;
            this.btnCapNhatPhieuNhapSach.Click += new System.EventHandler(this.btnCapNhatPhieuNhapSach_Click);
            // 
            // btnXoaPhieuNhapSach
            // 
            this.btnXoaPhieuNhapSach.Location = new System.Drawing.Point(21, 128);
            this.btnXoaPhieuNhapSach.Name = "btnXoaPhieuNhapSach";
            this.btnXoaPhieuNhapSach.Size = new System.Drawing.Size(155, 23);
            this.btnXoaPhieuNhapSach.TabIndex = 2;
            this.btnXoaPhieuNhapSach.Text = "Xóa phiếu nhập sách";
            this.btnXoaPhieuNhapSach.UseVisualStyleBackColor = true;
            this.btnXoaPhieuNhapSach.Click += new System.EventHandler(this.btnXoaPhieuNhapSach_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGVCTPhieuNhapSach);
            this.panel3.Location = new System.Drawing.Point(16, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 236);
            this.panel3.TabIndex = 4;
            // 
            // dataGVCTPhieuNhapSach
            // 
            this.dataGVCTPhieuNhapSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCTPhieuNhapSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVCTPhieuNhapSach.Location = new System.Drawing.Point(0, 0);
            this.dataGVCTPhieuNhapSach.Name = "dataGVCTPhieuNhapSach";
            this.dataGVCTPhieuNhapSach.Size = new System.Drawing.Size(836, 236);
            this.dataGVCTPhieuNhapSach.TabIndex = 1;
            this.dataGVCTPhieuNhapSach.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGVCTPhieuNhapSach_CellMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã Phiếu nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày nhập:";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(106, 47);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(219, 20);
            this.txtMaPN.TabIndex = 10;
            // 
            // btnLapCTPhieuNhapSach
            // 
            this.btnLapCTPhieuNhapSach.Location = new System.Drawing.Point(18, 488);
            this.btnLapCTPhieuNhapSach.Name = "btnLapCTPhieuNhapSach";
            this.btnLapCTPhieuNhapSach.Size = new System.Drawing.Size(160, 23);
            this.btnLapCTPhieuNhapSach.TabIndex = 5;
            this.btnLapCTPhieuNhapSach.Text = "Lập chi tiết phiếu nhập sách";
            this.btnLapCTPhieuNhapSach.UseVisualStyleBackColor = true;
            this.btnLapCTPhieuNhapSach.Click += new System.EventHandler(this.btnLapCTPhieuNhapSach_Click);
            // 
            // btnCapNhatCTPhieuNhapSach
            // 
            this.btnCapNhatCTPhieuNhapSach.Location = new System.Drawing.Point(346, 488);
            this.btnCapNhatCTPhieuNhapSach.Name = "btnCapNhatCTPhieuNhapSach";
            this.btnCapNhatCTPhieuNhapSach.Size = new System.Drawing.Size(170, 23);
            this.btnCapNhatCTPhieuNhapSach.TabIndex = 6;
            this.btnCapNhatCTPhieuNhapSach.Text = "Cập chi tiết nhật phiếu nhập sách";
            this.btnCapNhatCTPhieuNhapSach.UseVisualStyleBackColor = true;
            this.btnCapNhatCTPhieuNhapSach.Click += new System.EventHandler(this.btnCapNhatCTPhieuNhapSach_Click);
            // 
            // btnXoaCTPhieuNhapSach
            // 
            this.btnXoaCTPhieuNhapSach.Location = new System.Drawing.Point(692, 488);
            this.btnXoaCTPhieuNhapSach.Name = "btnXoaCTPhieuNhapSach";
            this.btnXoaCTPhieuNhapSach.Size = new System.Drawing.Size(160, 23);
            this.btnXoaCTPhieuNhapSach.TabIndex = 7;
            this.btnXoaCTPhieuNhapSach.Text = "Xóa chi tiết phiếu nhập sách";
            this.btnXoaCTPhieuNhapSach.UseVisualStyleBackColor = true;
            this.btnXoaCTPhieuNhapSach.Click += new System.EventHandler(this.btnXoaCTPhieuNhapSach_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(17, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(835, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chi tiết phiếu nhập sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã phiếu nhập:";
            // 
            // lblMaPN
            // 
            this.lblMaPN.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMaPN.Location = new System.Drawing.Point(103, 212);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(100, 23);
            this.lblMaPN.TabIndex = 13;
            this.lblMaPN.Text = "PN000";
            this.lblMaPN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNgayNhap.Location = new System.Drawing.Point(302, 212);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(100, 23);
            this.lblNgayNhap.TabIndex = 15;
            this.lblNgayNhap.Text = "00/00/0000";
            this.lblNgayNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(225, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày nhập:";
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(182, 128);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(143, 23);
            this.btnXemChiTiet.TabIndex = 16;
            this.btnXemChiTiet.Text = "Xem chi tiết phiếu nhập";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayNhap.Location = new System.Drawing.Point(106, 74);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(219, 20);
            this.txtNgayNhap.TabIndex = 17;
            // 
            // FormPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 523);
            this.Controls.Add(this.txtNgayNhap);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMaPN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaPN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoaCTPhieuNhapSach);
            this.Controls.Add(this.btnCapNhatCTPhieuNhapSach);
            this.Controls.Add(this.btnLapCTPhieuNhapSach);
            this.Controls.Add(this.btnXoaPhieuNhapSach);
            this.Controls.Add(this.btnCapNhatPhieuNhapSach);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLapPhieuNhapSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormPhieuNhapSach";
            this.Text = "FormPhieuNhapSach";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPhieuNhapSach)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCTPhieuNhapSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLapPhieuNhapSach;
        private System.Windows.Forms.Button btnCapNhatPhieuNhapSach;
        private System.Windows.Forms.Button btnXoaPhieuNhapSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Button btnLapCTPhieuNhapSach;
        private System.Windows.Forms.Button btnCapNhatCTPhieuNhapSach;
        private System.Windows.Forms.Button btnXoaCTPhieuNhapSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaPN;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGVCTPhieuNhapSach;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.DataGridView dataGVPhieuNhapSach;
        private System.Windows.Forms.DateTimePicker txtNgayNhap;

    }
}