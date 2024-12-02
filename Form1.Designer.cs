namespace _492990_AlexanderJohanPramudito_ResponsiJuniorProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_NamaKaryawan = new Label();
            tb_nama = new TextBox();
            lbl_Departemen = new Label();
            cb_departemen = new ComboBox();
            btn_Insert = new Button();
            btn_Edit = new Button();
            btn_Delete = new Button();
            info_dep = new Label();
            lbl_KaryawanTerpilih = new Label();
            dgv_karyawan = new DataGridView();
            lblDynamic_Karyawan = new Label();
            pictureBox1 = new PictureBox();
            btn_Jabatan = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_karyawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_NamaKaryawan
            // 
            lbl_NamaKaryawan.AutoSize = true;
            lbl_NamaKaryawan.Location = new Point(7, 97);
            lbl_NamaKaryawan.Margin = new Padding(2, 0, 2, 0);
            lbl_NamaKaryawan.Name = "lbl_NamaKaryawan";
            lbl_NamaKaryawan.Size = new Size(93, 15);
            lbl_NamaKaryawan.TabIndex = 1;
            lbl_NamaKaryawan.Text = "Nama Karyawan";
            // 
            // tb_nama
            // 
            tb_nama.Location = new Point(118, 97);
            tb_nama.Margin = new Padding(2);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(257, 23);
            tb_nama.TabIndex = 2;
            // 
            // lbl_Departemen
            // 
            lbl_Departemen.AutoSize = true;
            lbl_Departemen.Location = new Point(7, 132);
            lbl_Departemen.Margin = new Padding(2, 0, 2, 0);
            lbl_Departemen.Name = "lbl_Departemen";
            lbl_Departemen.Size = new Size(72, 15);
            lbl_Departemen.TabIndex = 3;
            lbl_Departemen.Text = "Departemen";
            // 
            // cb_departemen
            // 
            cb_departemen.FormattingEnabled = true;
            cb_departemen.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cb_departemen.Location = new Point(118, 130);
            cb_departemen.Margin = new Padding(2);
            cb_departemen.Name = "cb_departemen";
            cb_departemen.Size = new Size(257, 23);
            cb_departemen.TabIndex = 4;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(59, 210);
            btn_Insert.Margin = new Padding(2);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(78, 20);
            btn_Insert.TabIndex = 5;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(157, 210);
            btn_Edit.Margin = new Padding(2);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(78, 20);
            btn_Edit.TabIndex = 6;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(250, 210);
            btn_Delete.Margin = new Padding(2);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(78, 20);
            btn_Delete.TabIndex = 7;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // info_dep
            // 
            info_dep.AutoSize = true;
            info_dep.Location = new Point(394, 97);
            info_dep.Margin = new Padding(2, 0, 2, 0);
            info_dep.Name = "info_dep";
            info_dep.Size = new Size(123, 90);
            info_dep.TabIndex = 8;
            info_dep.Text = "ID Dep:\r\nHR: Human Resource\r\nENG: Engineer\r\nDEV: Developer\r\nPM: Product Manager\r\nFIN: Finance";
            // 
            // lbl_KaryawanTerpilih
            // 
            lbl_KaryawanTerpilih.AutoSize = true;
            lbl_KaryawanTerpilih.Location = new Point(7, 252);
            lbl_KaryawanTerpilih.Margin = new Padding(2, 0, 2, 0);
            lbl_KaryawanTerpilih.Name = "lbl_KaryawanTerpilih";
            lbl_KaryawanTerpilih.Size = new Size(105, 15);
            lbl_KaryawanTerpilih.TabIndex = 9;
            lbl_KaryawanTerpilih.Text = "Karyawan Terpilih: ";
            // 
            // dgv_karyawan
            // 
            dgv_karyawan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_karyawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_karyawan.Location = new Point(7, 280);
            dgv_karyawan.Margin = new Padding(2);
            dgv_karyawan.Name = "dgv_karyawan";
            dgv_karyawan.RowHeadersWidth = 62;
            dgv_karyawan.RowTemplate.Height = 33;
            dgv_karyawan.Size = new Size(543, 135);
            dgv_karyawan.TabIndex = 10;
            dgv_karyawan.CellClick += dgv_karyawan_CellClick;
            dgv_karyawan.CellContentClick += dgv_karyawan_CellContentClick;
            // 
            // lblDynamic_Karyawan
            // 
            lblDynamic_Karyawan.AutoSize = true;
            lblDynamic_Karyawan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDynamic_Karyawan.Location = new Point(118, 252);
            lblDynamic_Karyawan.Margin = new Padding(2, 0, 2, 0);
            lblDynamic_Karyawan.Name = "lblDynamic_Karyawan";
            lblDynamic_Karyawan.Size = new Size(27, 15);
            lblDynamic_Karyawan.TabIndex = 12;
            lblDynamic_Karyawan.Text = "null";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nvidia;
            pictureBox1.Location = new Point(7, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_Jabatan
            // 
            btn_Jabatan.Location = new Point(475, 11);
            btn_Jabatan.Name = "btn_Jabatan";
            btn_Jabatan.Size = new Size(75, 23);
            btn_Jabatan.TabIndex = 13;
            btn_Jabatan.Text = "Jabatan";
            btn_Jabatan.UseVisualStyleBackColor = true;
            btn_Jabatan.Click += btn_Jabatan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 426);
            Controls.Add(btn_Jabatan);
            Controls.Add(pictureBox1);
            Controls.Add(lblDynamic_Karyawan);
            Controls.Add(dgv_karyawan);
            Controls.Add(lbl_KaryawanTerpilih);
            Controls.Add(info_dep);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Insert);
            Controls.Add(cb_departemen);
            Controls.Add(lbl_Departemen);
            Controls.Add(tb_nama);
            Controls.Add(lbl_NamaKaryawan);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_karyawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_NamaKaryawan;
        private TextBox tb_nama;
        private Label lbl_Departemen;
        private ComboBox cb_departemen;
        private Button btn_Insert;
        private Button btn_Edit;
        private Button btn_Delete;
        private Label info_dep;
        private Label lbl_KaryawanTerpilih;
        private DataGridView dgv_karyawan;
        private Label lblDynamic_Karyawan;
        private PictureBox pictureBox1;
        private Button btn_Jabatan;
    }
}
