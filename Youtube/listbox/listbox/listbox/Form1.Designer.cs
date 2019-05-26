namespace listbox
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
            this.lstDanhsach1 = new System.Windows.Forms.ListBox();
            this.lstDanhsach2 = new System.Windows.Forms.ListBox();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnallphai = new System.Windows.Forms.Button();
            this.btnallTrai = new System.Windows.Forms.Button();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.btnadditemtrai = new System.Windows.Forms.Button();
            this.btnadditemphai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDanhsach1
            // 
            this.lstDanhsach1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDanhsach1.FormattingEnabled = true;
            this.lstDanhsach1.ItemHeight = 25;
            this.lstDanhsach1.Items.AddRange(new object[] {
            "Mì xào",
            "Cà muối",
            "Khoai tây chiên",
            "Coca Cola",
            "7UP",
            "Coffe"});
            this.lstDanhsach1.Location = new System.Drawing.Point(12, 12);
            this.lstDanhsach1.Name = "lstDanhsach1";
            this.lstDanhsach1.Size = new System.Drawing.Size(230, 279);
            this.lstDanhsach1.TabIndex = 0;
            // 
            // lstDanhsach2
            // 
            this.lstDanhsach2.FormattingEnabled = true;
            this.lstDanhsach2.ItemHeight = 16;
            this.lstDanhsach2.Location = new System.Drawing.Point(440, 12);
            this.lstDanhsach2.Name = "lstDanhsach2";
            this.lstDanhsach2.Size = new System.Drawing.Size(213, 276);
            this.lstDanhsach2.TabIndex = 1;
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(281, 39);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(128, 47);
            this.btnPhai.TabIndex = 2;
            this.btnPhai.Text = ">";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(281, 105);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(128, 47);
            this.btnTrai.TabIndex = 2;
            this.btnTrai.Text = "<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnallphai
            // 
            this.btnallphai.Location = new System.Drawing.Point(281, 167);
            this.btnallphai.Name = "btnallphai";
            this.btnallphai.Size = new System.Drawing.Size(128, 47);
            this.btnallphai.TabIndex = 2;
            this.btnallphai.Text = ">>";
            this.btnallphai.UseVisualStyleBackColor = true;
            this.btnallphai.Click += new System.EventHandler(this.btnallphai_Click);
            // 
            // btnallTrai
            // 
            this.btnallTrai.Location = new System.Drawing.Point(281, 230);
            this.btnallTrai.Name = "btnallTrai";
            this.btnallTrai.Size = new System.Drawing.Size(128, 47);
            this.btnallTrai.TabIndex = 2;
            this.btnallTrai.Text = "<<";
            this.btnallTrai.UseVisualStyleBackColor = true;
            this.btnallTrai.Click += new System.EventHandler(this.btnallTrai_Click);
            // 
            // txtItems
            // 
            this.txtItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItems.Location = new System.Drawing.Point(159, 339);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(337, 30);
            this.txtItems.TabIndex = 3;
            // 
            // btnadditemtrai
            // 
            this.btnadditemtrai.Location = new System.Drawing.Point(12, 334);
            this.btnadditemtrai.Name = "btnadditemtrai";
            this.btnadditemtrai.Size = new System.Drawing.Size(128, 47);
            this.btnadditemtrai.TabIndex = 2;
            this.btnadditemtrai.Text = "<item";
            this.btnadditemtrai.UseVisualStyleBackColor = true;
            this.btnadditemtrai.Click += new System.EventHandler(this.btnadditemtrai_Click);
            // 
            // btnadditemphai
            // 
            this.btnadditemphai.Location = new System.Drawing.Point(525, 334);
            this.btnadditemphai.Name = "btnadditemphai";
            this.btnadditemphai.Size = new System.Drawing.Size(128, 47);
            this.btnadditemphai.TabIndex = 2;
            this.btnadditemphai.Text = "item>";
            this.btnadditemphai.UseVisualStyleBackColor = true;
            this.btnadditemphai.Click += new System.EventHandler(this.btnadditemphai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 402);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.btnallTrai);
            this.Controls.Add(this.btnallphai);
            this.Controls.Add(this.btnadditemphai);
            this.Controls.Add(this.btnadditemtrai);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.lstDanhsach2);
            this.Controls.Add(this.lstDanhsach1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDanhsach1;
        private System.Windows.Forms.ListBox lstDanhsach2;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btnallphai;
        private System.Windows.Forms.Button btnallTrai;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Button btnadditemtrai;
        private System.Windows.Forms.Button btnadditemphai;
    }
}

