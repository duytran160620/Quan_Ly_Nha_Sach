namespace Quan_Ly_Nha_Sach
{
    partial class FormTimKiemSach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnTacGia = new System.Windows.Forms.RadioButton();
            this.radioBtnTheLoai = new System.Windows.Forms.RadioButton();
            this.radioBtnTenSach = new System.Windows.Forms.RadioButton();
            this.radioBtnMaSach = new System.Windows.Forms.RadioButton();
            this.dataGVKetQua = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 75);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(382, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 106);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(15, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 226);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 106);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cần tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGVKetQua);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 226);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnTacGia);
            this.groupBox1.Controls.Add(this.radioBtnTheLoai);
            this.groupBox1.Controls.Add(this.radioBtnTenSach);
            this.groupBox1.Controls.Add(this.radioBtnMaSach);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // radioBtnTacGia
            // 
            this.radioBtnTacGia.AutoSize = true;
            this.radioBtnTacGia.Location = new System.Drawing.Point(296, 29);
            this.radioBtnTacGia.Name = "radioBtnTacGia";
            this.radioBtnTacGia.Size = new System.Drawing.Size(61, 17);
            this.radioBtnTacGia.TabIndex = 11;
            this.radioBtnTacGia.TabStop = true;
            this.radioBtnTacGia.Text = "Tác giả";
            this.radioBtnTacGia.UseVisualStyleBackColor = true;
            // 
            // radioBtnTheLoai
            // 
            this.radioBtnTheLoai.AutoSize = true;
            this.radioBtnTheLoai.Location = new System.Drawing.Point(204, 29);
            this.radioBtnTheLoai.Name = "radioBtnTheLoai";
            this.radioBtnTheLoai.Size = new System.Drawing.Size(63, 17);
            this.radioBtnTheLoai.TabIndex = 10;
            this.radioBtnTheLoai.TabStop = true;
            this.radioBtnTheLoai.Text = "Thể loại";
            this.radioBtnTheLoai.UseVisualStyleBackColor = true;
            // 
            // radioBtnTenSach
            // 
            this.radioBtnTenSach.AutoSize = true;
            this.radioBtnTenSach.Location = new System.Drawing.Point(97, 29);
            this.radioBtnTenSach.Name = "radioBtnTenSach";
            this.radioBtnTenSach.Size = new System.Drawing.Size(70, 17);
            this.radioBtnTenSach.TabIndex = 9;
            this.radioBtnTenSach.TabStop = true;
            this.radioBtnTenSach.Text = "Tên sách";
            this.radioBtnTenSach.UseVisualStyleBackColor = true;
            // 
            // radioBtnMaSach
            // 
            this.radioBtnMaSach.AutoSize = true;
            this.radioBtnMaSach.Location = new System.Drawing.Point(6, 29);
            this.radioBtnMaSach.Name = "radioBtnMaSach";
            this.radioBtnMaSach.Size = new System.Drawing.Size(66, 17);
            this.radioBtnMaSach.TabIndex = 8;
            this.radioBtnMaSach.TabStop = true;
            this.radioBtnMaSach.Text = "Mã sách";
            this.radioBtnMaSach.UseVisualStyleBackColor = true;
            // 
            // dataGVKetQua
            // 
            this.dataGVKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVKetQua.Location = new System.Drawing.Point(3, 16);
            this.dataGVKetQua.Name = "dataGVKetQua";
            this.dataGVKetQua.Size = new System.Drawing.Size(682, 207);
            this.dataGVKetQua.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(87, 69);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(161, 31);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(147, 28);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(170, 20);
            this.txtInput.TabIndex = 2;
            // 
            // FormTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 437);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormTimKiemSach";
            this.Text = "FormTimKiemSach";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKetQua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnTacGia;
        private System.Windows.Forms.RadioButton radioBtnTheLoai;
        private System.Windows.Forms.RadioButton radioBtnTenSach;
        private System.Windows.Forms.RadioButton radioBtnMaSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGVKetQua;
    }
}