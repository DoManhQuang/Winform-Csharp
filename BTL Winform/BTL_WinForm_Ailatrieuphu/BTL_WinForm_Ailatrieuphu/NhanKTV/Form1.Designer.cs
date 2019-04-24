namespace BTL_WinForm_Ailatrieuphu
{
    partial class FormKyThuatVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKyThuatVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.dgvCauHoi = new System.Windows.Forms.DataGridView();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dapan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dapandung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dokho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trogiupxoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trogiuptuvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKTV = new System.Windows.Forms.TextBox();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDAD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTrogiup = new System.Windows.Forms.Label();
            this.lblTuVan = new System.Windows.Forms.Label();
            this.btnLayFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtDapan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btbThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.numTrang = new System.Windows.Forms.NumericUpDown();
            this.cauHoiResourse = new BTL_WinForm_Ailatrieuphu.NhanKTV.CauHoiResourse();
            this.tblCauhoiTableAdapter = new BTL_WinForm_Ailatrieuphu.NhanKTV.CauHoiResourseTableAdapters.tblCauhoiTableAdapter();
            this.cbDAD = new System.Windows.Forms.ComboBox();
            this.cbDoKho = new System.Windows.Forms.ComboBox();
            this.txtTroGiup = new System.Windows.Forms.TextBox();
            this.txtTuVan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiResourse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Câu Hỏi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã câu hỏi";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Enabled = false;
            this.txtMaCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCH.Location = new System.Drawing.Point(424, 73);
            this.txtMaCH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(273, 30);
            this.txtMaCH.TabIndex = 1;
            // 
            // dgvCauHoi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCauHoi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCauHoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCH,
            this.MaKTV,
            this.TenCH,
            this.Dapan,
            this.Dapandung,
            this.Dokho,
            this.Trogiupxoa,
            this.Trogiuptuvan});
            this.dgvCauHoi.Location = new System.Drawing.Point(0, 378);
            this.dgvCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCauHoi.Name = "dgvCauHoi";
            this.dgvCauHoi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCauHoi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCauHoi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCauHoi.Size = new System.Drawing.Size(1235, 246);
            this.dgvCauHoi.TabIndex = 3;
            this.dgvCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCauHoi_CellClick);
            // 
            // MaCH
            // 
            this.MaCH.DataPropertyName = "MaCH";
            this.MaCH.HeaderText = "Mã Câu hỏi";
            this.MaCH.Name = "MaCH";
            this.MaCH.ReadOnly = true;
            // 
            // MaKTV
            // 
            this.MaKTV.DataPropertyName = "MaKTV";
            this.MaKTV.HeaderText = "Mã kỹ thuật viên";
            this.MaKTV.Name = "MaKTV";
            this.MaKTV.ReadOnly = true;
            // 
            // TenCH
            // 
            this.TenCH.DataPropertyName = "TenCH";
            this.TenCH.HeaderText = "Tên Câu Hỏi";
            this.TenCH.Name = "TenCH";
            this.TenCH.ReadOnly = true;
            // 
            // Dapan
            // 
            this.Dapan.DataPropertyName = "Dapan";
            this.Dapan.HeaderText = "Đáp Án";
            this.Dapan.Name = "Dapan";
            this.Dapan.ReadOnly = true;
            // 
            // Dapandung
            // 
            this.Dapandung.DataPropertyName = "Dapandung";
            this.Dapandung.HeaderText = "Đáp án đúng";
            this.Dapandung.Name = "Dapandung";
            this.Dapandung.ReadOnly = true;
            // 
            // Dokho
            // 
            this.Dokho.DataPropertyName = "Dokho";
            this.Dokho.HeaderText = "Độ khó";
            this.Dokho.Name = "Dokho";
            this.Dokho.ReadOnly = true;
            // 
            // Trogiupxoa
            // 
            this.Trogiupxoa.DataPropertyName = "Trogiupxoa";
            this.Trogiupxoa.HeaderText = "Trợ Giúp Xóa";
            this.Trogiupxoa.Name = "Trogiupxoa";
            this.Trogiupxoa.ReadOnly = true;
            // 
            // Trogiuptuvan
            // 
            this.Trogiuptuvan.DataPropertyName = "Trogiuptuvan";
            this.Trogiuptuvan.HeaderText = "Trợ Giúp Tư Vấn";
            this.Trogiuptuvan.Name = "Trogiuptuvan";
            this.Trogiuptuvan.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã kỹ thuật viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên câu hỏi";
            // 
            // txtMaKTV
            // 
            this.txtMaKTV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKTV.Location = new System.Drawing.Point(424, 114);
            this.txtMaKTV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKTV.Name = "txtMaKTV";
            this.txtMaKTV.Size = new System.Drawing.Size(273, 30);
            this.txtMaKTV.TabIndex = 2;
            // 
            // txtTenCH
            // 
            this.txtTenCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCH.Location = new System.Drawing.Point(424, 156);
            this.txtTenCH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(273, 30);
            this.txtTenCH.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đáp án";
            // 
            // lblDAD
            // 
            this.lblDAD.AutoSize = true;
            this.lblDAD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDAD.Location = new System.Drawing.Point(749, 73);
            this.lblDAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDAD.Name = "lblDAD";
            this.lblDAD.Size = new System.Drawing.Size(109, 22);
            this.lblDAD.TabIndex = 1;
            this.lblDAD.Text = "Đáp án đúng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(749, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Độ khó";
            // 
            // lblTrogiup
            // 
            this.lblTrogiup.AutoSize = true;
            this.lblTrogiup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrogiup.Location = new System.Drawing.Point(749, 160);
            this.lblTrogiup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrogiup.Name = "lblTrogiup";
            this.lblTrogiup.Size = new System.Drawing.Size(112, 22);
            this.lblTrogiup.TabIndex = 1;
            this.lblTrogiup.Text = "Trợ giúp xóa";
            // 
            // lblTuVan
            // 
            this.lblTuVan.AutoSize = true;
            this.lblTuVan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuVan.Location = new System.Drawing.Point(741, 207);
            this.lblTuVan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuVan.Name = "lblTuVan";
            this.lblTuVan.Size = new System.Drawing.Size(133, 22);
            this.lblTuVan.TabIndex = 1;
            this.lblTuVan.Text = "Trợ giúp tư vấn";
            // 
            // btnLayFile
            // 
            this.btnLayFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLayFile.Location = new System.Drawing.Point(1140, 340);
            this.btnLayFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLayFile.Name = "btnLayFile";
            this.btnLayFile.Size = new System.Drawing.Size(89, 26);
            this.btnLayFile.TabIndex = 15;
            this.btnLayFile.Text = "Browse...";
            this.btnLayFile.UseVisualStyleBackColor = true;
            this.btnLayFile.Click += new System.EventHandler(this.btnLayFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(1003, 342);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(132, 22);
            this.txtFilePath.TabIndex = 16;
            // 
            // txtDapan
            // 
            this.txtDapan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapan.Location = new System.Drawing.Point(424, 203);
            this.txtDapan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDapan.Multiline = true;
            this.txtDapan.Name = "txtDapan";
            this.txtDapan.Size = new System.Drawing.Size(273, 79);
            this.txtDapan.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 186);
            this.panel1.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Location = new System.Drawing.Point(728, 308);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(81, 59);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btbThoat
            // 
            this.btbThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btbThoat.BackgroundImage")));
            this.btbThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbThoat.Location = new System.Drawing.Point(884, 303);
            this.btbThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btbThoat.Name = "btbThoat";
            this.btbThoat.Size = new System.Drawing.Size(80, 65);
            this.btbThoat.TabIndex = 12;
            this.btbThoat.UseVisualStyleBackColor = true;
            this.btbThoat.Click += new System.EventHandler(this.btbThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(424, 302);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 65);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(284, 302);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 65);
            this.btnSua.TabIndex = 10;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.Location = new System.Drawing.Point(163, 302);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 65);
            this.btnThem.TabIndex = 9;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.Location = new System.Drawing.Point(573, 300);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(79, 66);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Tag = "14";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // numTrang
            // 
            this.numTrang.Location = new System.Drawing.Point(560, 631);
            this.numTrang.Margin = new System.Windows.Forms.Padding(4);
            this.numTrang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrang.Name = "numTrang";
            this.numTrang.Size = new System.Drawing.Size(57, 22);
            this.numTrang.TabIndex = 19;
            this.numTrang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrang.MouseDown += new System.Windows.Forms.MouseEventHandler(this.numTrang_MouseDown);
            this.numTrang.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numTrang_MouseUp);
            // 
            // cauHoiResourse
            // 
            this.cauHoiResourse.DataSetName = "CauHoiResourse";
            this.cauHoiResourse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCauhoiTableAdapter
            // 
            this.tblCauhoiTableAdapter.ClearBeforeFill = true;
            // 
            // cbDAD
            // 
            this.cbDAD.FormattingEnabled = true;
            this.cbDAD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDAD.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbDAD.Location = new System.Drawing.Point(884, 73);
            this.cbDAD.Margin = new System.Windows.Forms.Padding(4);
            this.cbDAD.Name = "cbDAD";
            this.cbDAD.Size = new System.Drawing.Size(251, 24);
            this.cbDAD.TabIndex = 23;
            // 
            // cbDoKho
            // 
            this.cbDoKho.FormattingEnabled = true;
            this.cbDoKho.Location = new System.Drawing.Point(884, 111);
            this.cbDoKho.Margin = new System.Windows.Forms.Padding(4);
            this.cbDoKho.Name = "cbDoKho";
            this.cbDoKho.Size = new System.Drawing.Size(251, 24);
            this.cbDoKho.TabIndex = 24;
            // 
            // txtTroGiup
            // 
            this.txtTroGiup.Location = new System.Drawing.Point(884, 154);
            this.txtTroGiup.Margin = new System.Windows.Forms.Padding(4);
            this.txtTroGiup.Multiline = true;
            this.txtTroGiup.Name = "txtTroGiup";
            this.txtTroGiup.Size = new System.Drawing.Size(251, 34);
            this.txtTroGiup.TabIndex = 25;
            // 
            // txtTuVan
            // 
            this.txtTuVan.Location = new System.Drawing.Point(884, 203);
            this.txtTuVan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuVan.Multiline = true;
            this.txtTuVan.Name = "txtTuVan";
            this.txtTuVan.Size = new System.Drawing.Size(251, 35);
            this.txtTuVan.TabIndex = 25;
            // 
            // FormKyThuatVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 661);
            this.Controls.Add(this.txtTuVan);
            this.Controls.Add(this.txtTroGiup);
            this.Controls.Add(this.cbDoKho);
            this.Controls.Add(this.cbDAD);
            this.Controls.Add(this.numTrang);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtDapan);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnLayFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btbThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCauHoi);
            this.Controls.Add(this.txtTenCH);
            this.Controls.Add(this.txtMaKTV);
            this.Controls.Add(this.txtMaCH);
            this.Controls.Add(this.lblTuVan);
            this.Controls.Add(this.lblTrogiup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDAD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKyThuatVien";
            this.ShowInTaskbar = false;
            this.Text = "Câu hỏi";
            this.Load += new System.EventHandler(this.btnLoad_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauHoiResourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.DataGridView dgvCauHoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKTV;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDAD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTrogiup;
        private System.Windows.Forms.Label lblTuVan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btbThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLayFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtDapan;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.NumericUpDown numTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dapan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dapandung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dokho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trogiupxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trogiuptuvan;
        private NhanKTV.CauHoiResourse cauHoiResourse;
        private NhanKTV.CauHoiResourseTableAdapters.tblCauhoiTableAdapter tblCauhoiTableAdapter;
        private System.Windows.Forms.ComboBox cbDAD;
        private System.Windows.Forms.ComboBox cbDoKho;
        private System.Windows.Forms.TextBox txtTroGiup;
        private System.Windows.Forms.TextBox txtTuVan;
    }
}

