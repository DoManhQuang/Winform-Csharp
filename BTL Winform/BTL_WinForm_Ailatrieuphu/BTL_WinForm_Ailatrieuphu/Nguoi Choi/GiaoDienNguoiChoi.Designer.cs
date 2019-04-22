namespace BTL_WinForm_Ailatrieuphu.Nguoi_Choi
{
    partial class GiaoDienNguoiChoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienNguoiChoi));
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnThongtin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXepHang = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBatDau
            // 
            this.btnBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBatDau.Location = new System.Drawing.Point(321, 441);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(183, 82);
            this.btnBatDau.TabIndex = 2;
            this.btnBatDau.Text = "Bắt Đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnThongtin
            // 
            this.btnThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnThongtin.Location = new System.Drawing.Point(86, 441);
            this.btnThongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongtin.Name = "btnThongtin";
            this.btnThongtin.Size = new System.Drawing.Size(166, 82);
            this.btnThongtin.TabIndex = 1;
            this.btnThongtin.Text = "Xem Thông Tin";
            this.btnThongtin.UseVisualStyleBackColor = true;
            this.btnThongtin.Click += new System.EventHandler(this.btnThongtin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnThongtin);
            this.groupBox1.Controls.Add(this.btnDangXuat);
            this.groupBox1.Controls.Add(this.btnXepHang);
            this.groupBox1.Controls.Add(this.btnBatDau);
            this.groupBox1.Location = new System.Drawing.Point(18, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 653);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnXepHang
            // 
            this.btnXepHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnXepHang.Location = new System.Drawing.Point(562, 441);
            this.btnXepHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXepHang.Name = "btnXepHang";
            this.btnXepHang.Size = new System.Drawing.Size(183, 82);
            this.btnXepHang.TabIndex = 3;
            this.btnXepHang.Text = "Xếp Hạng";
            this.btnXepHang.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDangXuat.Location = new System.Drawing.Point(562, 51);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(183, 82);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // GiaoDienNguoiChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 662);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GiaoDienNguoiChoi";
            this.Text = "Ai Là Triêu Phú";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnThongtin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXepHang;
        private System.Windows.Forms.Button btnDangXuat;
    }
}