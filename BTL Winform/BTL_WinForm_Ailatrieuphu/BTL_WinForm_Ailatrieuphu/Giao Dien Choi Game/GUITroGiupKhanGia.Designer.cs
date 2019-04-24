namespace TroGiupKhanGia
{
    partial class GUITroGiupKhanGia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUITroGiupKhanGia));
            this.pictureTroGiupKhanGia = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTroGiupKhanGia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureTroGiupKhanGia
            // 
            this.pictureTroGiupKhanGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureTroGiupKhanGia.Image = ((System.Drawing.Image)(resources.GetObject("pictureTroGiupKhanGia.Image")));
            this.pictureTroGiupKhanGia.Location = new System.Drawing.Point(0, 0);
            this.pictureTroGiupKhanGia.Margin = new System.Windows.Forms.Padding(4);
            this.pictureTroGiupKhanGia.Name = "pictureTroGiupKhanGia";
            this.pictureTroGiupKhanGia.Size = new System.Drawing.Size(427, 460);
            this.pictureTroGiupKhanGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTroGiupKhanGia.TabIndex = 1;
            this.pictureTroGiupKhanGia.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GUITroGiupKhanGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 460);
            this.Controls.Add(this.pictureTroGiupKhanGia);
            this.Name = "GUITroGiupKhanGia";
            this.Text = "Sự trợ giúp của khán giả";
            this.Load += new System.EventHandler(this.GUITroGiupKhanGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTroGiupKhanGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureTroGiupKhanGia;
        private System.Windows.Forms.Timer timer1;
    }
}

