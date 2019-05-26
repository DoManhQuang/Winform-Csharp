namespace WindowsFormsApp1
{
    partial class Form1
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
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.btnGioitinh = new System.Windows.Forms.Button();
            this.rdGTT3 = new System.Windows.Forms.RadioButton();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(51, 195);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(58, 21);
            this.rdNam.TabIndex = 0;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(187, 195);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(47, 21);
            this.rdNu.TabIndex = 0;
            this.rdNu.Text = "Nu";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // btnGioitinh
            // 
            this.btnGioitinh.Location = new System.Drawing.Point(153, 280);
            this.btnGioitinh.Name = "btnGioitinh";
            this.btnGioitinh.Size = new System.Drawing.Size(143, 52);
            this.btnGioitinh.TabIndex = 1;
            this.btnGioitinh.Text = "Giới Tính";
            this.btnGioitinh.UseVisualStyleBackColor = true;
            this.btnGioitinh.Click += new System.EventHandler(this.btnGioitinh_Click);
            // 
            // rdGTT3
            // 
            this.rdGTT3.AutoSize = true;
            this.rdGTT3.Checked = true;
            this.rdGTT3.Location = new System.Drawing.Point(303, 195);
            this.rdGTT3.Name = "rdGTT3";
            this.rdGTT3.Size = new System.Drawing.Size(127, 21);
            this.rdGTT3.TabIndex = 0;
            this.rdGTT3.TabStop = true;
            this.rdGTT3.Text = "Giới Tính Thứ 3";
            this.rdGTT3.UseVisualStyleBackColor = true;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(102, 99);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(255, 30);
            this.txtGioiTinh.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 445);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.btnGioitinh);
            this.Controls.Add(this.rdGTT3);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Button btnGioitinh;
        private System.Windows.Forms.RadioButton rdGTT3;
        private System.Windows.Forms.TextBox txtGioiTinh;
    }
}

