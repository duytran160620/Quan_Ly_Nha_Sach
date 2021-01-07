namespace Quan_Ly_Nha_Sach
{
    partial class FormQuanLySach
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
            this.dataGVDanhSachDauSach = new System.Windows.Forms.DataGridView();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnCapNhatSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDanhSachDauSach)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVDanhSachDauSach
            // 
            this.dataGVDanhSachDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDanhSachDauSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDanhSachDauSach.Location = new System.Drawing.Point(0, 0);
            this.dataGVDanhSachDauSach.Name = "dataGVDanhSachDauSach";
            this.dataGVDanhSachDauSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVDanhSachDauSach.Size = new System.Drawing.Size(739, 294);
            this.dataGVDanhSachDauSach.TabIndex = 1;
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(589, 360);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(172, 34);
            this.btnXoaSach.TabIndex = 9;
            this.btnXoaSach.Text = "Xóa thông tin sách";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnCapNhatSach
            // 
            this.btnCapNhatSach.Location = new System.Drawing.Point(311, 361);
            this.btnCapNhatSach.Name = "btnCapNhatSach";
            this.btnCapNhatSach.Size = new System.Drawing.Size(172, 34);
            this.btnCapNhatSach.TabIndex = 8;
            this.btnCapNhatSach.Text = "Cập nhật thông tin sách";
            this.btnCapNhatSach.UseVisualStyleBackColor = true;
            this.btnCapNhatSach.Click += new System.EventHandler(this.btnCapNhatSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(22, 360);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(172, 34);
            this.btnThemSach.TabIndex = 7;
            this.btnThemSach.Text = "Thêm thông tin sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGVDanhSachDauSach);
            this.panel1.Location = new System.Drawing.Point(22, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 294);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 419);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.btnCapNhatSach);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLySach";
            this.Text = "FormQuanLySach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDanhSachDauSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVDanhSachDauSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnCapNhatSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}