namespace QLTHUVIEN
{
    partial class Quanlysach
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
            this.labqls1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bnttimkiem = new System.Windows.Forms.Button();
            this.txbquanlysach = new System.Windows.Forms.TextBox();
            this.dgvQLS = new System.Windows.Forms.DataGridView();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQLS = new System.Windows.Forms.GroupBox();
            this.bntsua = new System.Windows.Forms.Button();
            this.bntnhaplai = new System.Windows.Forms.Button();
            this.bntxoa = new System.Windows.Forms.Button();
            this.bntthem = new System.Windows.Forms.Button();
            this.ckb1 = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labgioithieu = new System.Windows.Forms.Label();
            this.labtrangthai = new System.Windows.Forms.Label();
            this.labloaisach = new System.Windows.Forms.Label();
            this.labtacgia = new System.Windows.Forms.Label();
            this.labtensach = new System.Windows.Forms.Label();
            this.labmasach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).BeginInit();
            this.grbQLS.SuspendLayout();
            this.SuspendLayout();
            // 
            // labqls1
            // 
            this.labqls1.AutoSize = true;
            this.labqls1.Location = new System.Drawing.Point(350, 40);
            this.labqls1.Name = "labqls1";
            this.labqls1.Size = new System.Drawing.Size(91, 17);
            this.labqls1.TabIndex = 5;
            this.labqls1.Text = "Quản lý sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Từ khóa";
            // 
            // bnttimkiem
            // 
            this.bnttimkiem.Location = new System.Drawing.Point(557, 77);
            this.bnttimkiem.Name = "bnttimkiem";
            this.bnttimkiem.Size = new System.Drawing.Size(75, 23);
            this.bnttimkiem.TabIndex = 7;
            this.bnttimkiem.Text = "Tìm kiếm";
            this.bnttimkiem.UseVisualStyleBackColor = true;
            this.bnttimkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbquanlysach
            // 
            this.txbquanlysach.Location = new System.Drawing.Point(266, 77);
            this.txbquanlysach.Name = "txbquanlysach";
            this.txbquanlysach.Size = new System.Drawing.Size(264, 22);
            this.txbquanlysach.TabIndex = 8;
            // 
            // dgvQLS
            // 
            this.dgvQLS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masach,
            this.Tensach,
            this.tacgia,
            this.Trangthai,
            this.noibo});
            this.dgvQLS.Location = new System.Drawing.Point(12, 124);
            this.dgvQLS.Name = "dgvQLS";
            this.dgvQLS.RowTemplate.Height = 24;
            this.dgvQLS.Size = new System.Drawing.Size(817, 532);
            this.dgvQLS.TabIndex = 9;
            // 
            // Masach
            // 
            this.Masach.HeaderText = "Mã Sách";
            this.Masach.Name = "Masach";
            // 
            // Tensach
            // 
            this.Tensach.HeaderText = "Tên sách";
            this.Tensach.Name = "Tensach";
            // 
            // tacgia
            // 
            this.tacgia.HeaderText = "Tác giả";
            this.tacgia.Name = "tacgia";
            // 
            // Trangthai
            // 
            this.Trangthai.HeaderText = "Trạng Thái";
            this.Trangthai.Name = "Trangthai";
            // 
            // noibo
            // 
            this.noibo.HeaderText = "Nội bộ";
            this.noibo.Name = "noibo";
            // 
            // grbQLS
            // 
            this.grbQLS.Controls.Add(this.bntsua);
            this.grbQLS.Controls.Add(this.bntnhaplai);
            this.grbQLS.Controls.Add(this.bntxoa);
            this.grbQLS.Controls.Add(this.bntthem);
            this.grbQLS.Controls.Add(this.ckb1);
            this.grbQLS.Controls.Add(this.listView1);
            this.grbQLS.Controls.Add(this.comboBox2);
            this.grbQLS.Controls.Add(this.comboBox1);
            this.grbQLS.Controls.Add(this.textBox3);
            this.grbQLS.Controls.Add(this.textBox2);
            this.grbQLS.Controls.Add(this.textBox1);
            this.grbQLS.Controls.Add(this.labgioithieu);
            this.grbQLS.Controls.Add(this.labtrangthai);
            this.grbQLS.Controls.Add(this.labloaisach);
            this.grbQLS.Controls.Add(this.labtacgia);
            this.grbQLS.Controls.Add(this.labtensach);
            this.grbQLS.Controls.Add(this.labmasach);
            this.grbQLS.Location = new System.Drawing.Point(856, 40);
            this.grbQLS.Name = "grbQLS";
            this.grbQLS.Size = new System.Drawing.Size(419, 616);
            this.grbQLS.TabIndex = 10;
            this.grbQLS.TabStop = false;
            this.grbQLS.Text = "THÔNG TIN SÁCH";
            // 
            // bntsua
            // 
            this.bntsua.Location = new System.Drawing.Point(303, 546);
            this.bntsua.Name = "bntsua";
            this.bntsua.Size = new System.Drawing.Size(75, 23);
            this.bntsua.TabIndex = 25;
            this.bntsua.Text = "Sửa";
            this.bntsua.UseVisualStyleBackColor = true;
            // 
            // bntnhaplai
            // 
            this.bntnhaplai.Location = new System.Drawing.Point(214, 546);
            this.bntnhaplai.Name = "bntnhaplai";
            this.bntnhaplai.Size = new System.Drawing.Size(75, 23);
            this.bntnhaplai.TabIndex = 24;
            this.bntnhaplai.Text = "Nhập lại";
            this.bntnhaplai.UseVisualStyleBackColor = true;
            // 
            // bntxoa
            // 
            this.bntxoa.Location = new System.Drawing.Point(118, 546);
            this.bntxoa.Name = "bntxoa";
            this.bntxoa.Size = new System.Drawing.Size(75, 23);
            this.bntxoa.TabIndex = 23;
            this.bntxoa.Text = "Xóa";
            this.bntxoa.UseVisualStyleBackColor = true;
            // 
            // bntthem
            // 
            this.bntthem.Location = new System.Drawing.Point(24, 546);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(75, 23);
            this.bntthem.TabIndex = 11;
            this.bntthem.Text = "Thêm";
            this.bntthem.UseVisualStyleBackColor = true;
            // 
            // ckb1
            // 
            this.ckb1.AutoSize = true;
            this.ckb1.Location = new System.Drawing.Point(114, 498);
            this.ckb1.Name = "ckb1";
            this.ckb1.Size = new System.Drawing.Size(71, 21);
            this.ckb1.TabIndex = 22;
            this.ckb1.Text = "Nội bộ";
            this.ckb1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(111, 359);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(267, 129);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 304);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(256, 24);
            this.comboBox2.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 22);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 22);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 22);
            this.textBox1.TabIndex = 17;
            // 
            // labgioithieu
            // 
            this.labgioithieu.AutoSize = true;
            this.labgioithieu.Location = new System.Drawing.Point(31, 359);
            this.labgioithieu.Name = "labgioithieu";
            this.labgioithieu.Size = new System.Drawing.Size(68, 17);
            this.labgioithieu.TabIndex = 16;
            this.labgioithieu.Text = "Giới thiệu";
            // 
            // labtrangthai
            // 
            this.labtrangthai.AutoSize = true;
            this.labtrangthai.Location = new System.Drawing.Point(21, 304);
            this.labtrangthai.Name = "labtrangthai";
            this.labtrangthai.Size = new System.Drawing.Size(73, 17);
            this.labtrangthai.TabIndex = 15;
            this.labtrangthai.Text = "Trạng thái";
            // 
            // labloaisach
            // 
            this.labloaisach.AutoSize = true;
            this.labloaisach.Location = new System.Drawing.Point(21, 249);
            this.labloaisach.Name = "labloaisach";
            this.labloaisach.Size = new System.Drawing.Size(69, 17);
            this.labloaisach.TabIndex = 14;
            this.labloaisach.Text = "Loại sách";
            // 
            // labtacgia
            // 
            this.labtacgia.AutoSize = true;
            this.labtacgia.Location = new System.Drawing.Point(21, 191);
            this.labtacgia.Name = "labtacgia";
            this.labtacgia.Size = new System.Drawing.Size(55, 17);
            this.labtacgia.TabIndex = 13;
            this.labtacgia.Text = "Tác giả";
            this.labtacgia.Click += new System.EventHandler(this.label1_Click);
            // 
            // labtensach
            // 
            this.labtensach.AutoSize = true;
            this.labtensach.Location = new System.Drawing.Point(20, 130);
            this.labtensach.Name = "labtensach";
            this.labtensach.Size = new System.Drawing.Size(69, 17);
            this.labtensach.TabIndex = 12;
            this.labtensach.Text = "Tên Sách";
            // 
            // labmasach
            // 
            this.labmasach.AutoSize = true;
            this.labmasach.Location = new System.Drawing.Point(20, 64);
            this.labmasach.Name = "labmasach";
            this.labmasach.Size = new System.Drawing.Size(61, 17);
            this.labmasach.TabIndex = 11;
            this.labmasach.Text = "Mã sách";
            // 
            // Quanlythuvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 696);
            this.Controls.Add(this.grbQLS);
            this.Controls.Add(this.dgvQLS);
            this.Controls.Add(this.txbquanlysach);
            this.Controls.Add(this.bnttimkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labqls1);
            this.Name = "Quanlythuvien";
            this.Text = "Quản lý sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).EndInit();
            this.grbQLS.ResumeLayout(false);
            this.grbQLS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labqls1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnttimkiem;
        private System.Windows.Forms.TextBox txbquanlysach;
        private System.Windows.Forms.DataGridView dgvQLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn noibo;
        private System.Windows.Forms.GroupBox grbQLS;
        private System.Windows.Forms.Label labgioithieu;
        private System.Windows.Forms.Label labtrangthai;
        private System.Windows.Forms.Label labloaisach;
        private System.Windows.Forms.Label labtacgia;
        private System.Windows.Forms.Label labtensach;
        private System.Windows.Forms.Label labmasach;
        private System.Windows.Forms.Button bntsua;
        private System.Windows.Forms.Button bntnhaplai;
        private System.Windows.Forms.Button bntxoa;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.CheckBox ckb1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}