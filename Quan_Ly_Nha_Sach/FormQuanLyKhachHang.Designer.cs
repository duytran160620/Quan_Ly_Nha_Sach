namespace Quan_Ly_Nha_Sach
{
    partial class FormQuanLyKhachHang
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
            this.dataGVDanhSachKH = new System.Windows.Forms.DataGridView();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnCapNhatKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDanhSachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGVDanhSachKH);
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 294);
            this.panel1.TabIndex = 1;
            // 
            // dataGVDanhSachKH
            // 
            this.dataGVDanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDanhSachKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDanhSachKH.Location = new System.Drawing.Point(0, 0);
            this.dataGVDanhSachKH.Name = "dataGVDanhSachKH";
            this.dataGVDanhSachKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVDanhSachKH.Size = new System.Drawing.Size(739, 294);
            this.dataGVDanhSachKH.TabIndex = 1;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(13, 360);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(172, 34);
            this.btnThemKH.TabIndex = 2;
            this.btnThemKH.Text = "Thêm thông tin khách hàng";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnCapNhatKH
            // 
            this.btnCapNhatKH.Location = new System.Drawing.Point(302, 361);
            this.btnCapNhatKH.Name = "btnCapNhatKH";
            this.btnCapNhatKH.Size = new System.Drawing.Size(172, 34);
            this.btnCapNhatKH.TabIndex = 3;
            this.btnCapNhatKH.Text = "Cập nhật thông tin khách hàng";
            this.btnCapNhatKH.UseVisualStyleBackColor = true;
            this.btnCapNhatKH.Click += new System.EventHandler(this.btnCapNhatKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(580, 360);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(172, 34);
            this.btnXoaKH.TabIndex = 4;
            this.btnXoaKH.Text = "Xóa thông tin khách hàng";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // FormQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 407);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnCapNhatKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLyKhachHang";
            this.Text = "FormQuanLyKhachHang";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDanhSachKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGVDanhSachKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnCapNhatKH;
        private System.Windows.Forms.Button btnXoaKH;
    }
}