namespace label
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.rdLabel = new System.Windows.Forms.RadioButton();
            this.rdRadio = new System.Windows.Forms.RadioButton();
            this.rdTextbox = new System.Windows.Forms.RadioButton();
            this.rdPictureBox = new System.Windows.Forms.RadioButton();
            this.lbKetqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tôi là Control gì ?";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(126, 343);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(116, 50);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // rdLabel
            // 
            this.rdLabel.AutoSize = true;
            this.rdLabel.Location = new System.Drawing.Point(50, 162);
            this.rdLabel.Name = "rdLabel";
            this.rdLabel.Size = new System.Drawing.Size(59, 21);
            this.rdLabel.TabIndex = 2;
            this.rdLabel.TabStop = true;
            this.rdLabel.Text = "label";
            this.rdLabel.UseVisualStyleBackColor = true;
            // 
            // rdRadio
            // 
            this.rdRadio.AutoSize = true;
            this.rdRadio.Location = new System.Drawing.Point(271, 162);
            this.rdRadio.Name = "rdRadio";
            this.rdRadio.Size = new System.Drawing.Size(66, 21);
            this.rdRadio.TabIndex = 2;
            this.rdRadio.TabStop = true;
            this.rdRadio.Text = "Radio";
            this.rdRadio.UseVisualStyleBackColor = true;
            // 
            // rdTextbox
            // 
            this.rdTextbox.AutoSize = true;
            this.rdTextbox.Location = new System.Drawing.Point(50, 237);
            this.rdTextbox.Name = "rdTextbox";
            this.rdTextbox.Size = new System.Drawing.Size(79, 21);
            this.rdTextbox.TabIndex = 2;
            this.rdTextbox.TabStop = true;
            this.rdTextbox.Text = "TextBox";
            this.rdTextbox.UseVisualStyleBackColor = true;
            // 
            // rdPictureBox
            // 
            this.rdPictureBox.AutoSize = true;
            this.rdPictureBox.Location = new System.Drawing.Point(271, 237);
            this.rdPictureBox.Name = "rdPictureBox";
            this.rdPictureBox.Size = new System.Drawing.Size(96, 21);
            this.rdPictureBox.TabIndex = 2;
            this.rdPictureBox.TabStop = true;
            this.rdPictureBox.Text = "PictureBox";
            this.rdPictureBox.UseVisualStyleBackColor = true;
            // 
            // lbKetqua
            // 
            this.lbKetqua.AutoSize = true;
            this.lbKetqua.BackColor = System.Drawing.Color.Transparent;
            this.lbKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetqua.Location = new System.Drawing.Point(427, 76);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(85, 25);
            this.lbKetqua.TabIndex = 0;
            this.lbKetqua.Text = "Kết Quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdPictureBox);
            this.Controls.Add(this.rdTextbox);
            this.Controls.Add(this.rdRadio);
            this.Controls.Add(this.rdLabel);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lbKetqua);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.RadioButton rdLabel;
        private System.Windows.Forms.RadioButton rdRadio;
        private System.Windows.Forms.RadioButton rdTextbox;
        private System.Windows.Forms.RadioButton rdPictureBox;
        private System.Windows.Forms.Label lbKetqua;
    }
}

