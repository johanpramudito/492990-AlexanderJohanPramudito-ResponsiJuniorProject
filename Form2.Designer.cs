namespace _492990_AlexanderJohanPramudito_ResponsiJuniorProject
{
    partial class Form2
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
            lbl_Jabatan = new Label();
            tb_jabatan = new TextBox();
            dgv_jabatan = new DataGridView();
            btn_InsertJabatan = new Button();
            btn_DeleteJabatan = new Button();
            btn_BackToForm1 = new Button();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            lbl_IDJabatan = new Label();
            tb_idjabatan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_jabatan).BeginInit();
            SuspendLayout();
            // 
            // lbl_Jabatan
            // 
            lbl_Jabatan.AutoSize = true;
            lbl_Jabatan.Location = new Point(34, 66);
            lbl_Jabatan.Name = "lbl_Jabatan";
            lbl_Jabatan.Size = new Size(47, 15);
            lbl_Jabatan.TabIndex = 0;
            lbl_Jabatan.Text = "Jabatan";
            // 
            // tb_jabatan
            // 
            tb_jabatan.Location = new Point(107, 67);
            tb_jabatan.Name = "tb_jabatan";
            tb_jabatan.Size = new Size(204, 23);
            tb_jabatan.TabIndex = 1;
            // 
            // dgv_jabatan
            // 
            dgv_jabatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_jabatan.Location = new Point(34, 146);
            dgv_jabatan.Name = "dgv_jabatan";
            dgv_jabatan.RowTemplate.Height = 25;
            dgv_jabatan.Size = new Size(277, 150);
            dgv_jabatan.TabIndex = 2;
            dgv_jabatan.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_InsertJabatan
            // 
            btn_InsertJabatan.Location = new Point(34, 106);
            btn_InsertJabatan.Name = "btn_InsertJabatan";
            btn_InsertJabatan.Size = new Size(75, 23);
            btn_InsertJabatan.TabIndex = 3;
            btn_InsertJabatan.Text = "Insert";
            btn_InsertJabatan.UseVisualStyleBackColor = true;
            btn_InsertJabatan.Click += btn_InsertJabatan_Click;
            // 
            // btn_DeleteJabatan
            // 
            btn_DeleteJabatan.Location = new Point(136, 106);
            btn_DeleteJabatan.Name = "btn_DeleteJabatan";
            btn_DeleteJabatan.Size = new Size(75, 23);
            btn_DeleteJabatan.TabIndex = 4;
            btn_DeleteJabatan.Text = "Delete";
            btn_DeleteJabatan.UseVisualStyleBackColor = true;
            btn_DeleteJabatan.Click += btn_DeleteJabatan_Click;
            // 
            // btn_BackToForm1
            // 
            btn_BackToForm1.Location = new Point(236, 315);
            btn_BackToForm1.Name = "btn_BackToForm1";
            btn_BackToForm1.Size = new Size(75, 23);
            btn_BackToForm1.TabIndex = 5;
            btn_BackToForm1.Text = "Back";
            btn_BackToForm1.UseVisualStyleBackColor = true;
            btn_BackToForm1.Click += btn_BackToForm1_Click;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // lbl_IDJabatan
            // 
            lbl_IDJabatan.AutoSize = true;
            lbl_IDJabatan.Location = new Point(34, 39);
            lbl_IDJabatan.Name = "lbl_IDJabatan";
            lbl_IDJabatan.Size = new Size(18, 15);
            lbl_IDJabatan.TabIndex = 6;
            lbl_IDJabatan.Text = "ID";
            // 
            // tb_idjabatan
            // 
            tb_idjabatan.Location = new Point(107, 36);
            tb_idjabatan.Name = "tb_idjabatan";
            tb_idjabatan.Size = new Size(204, 23);
            tb_idjabatan.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 350);
            Controls.Add(tb_idjabatan);
            Controls.Add(lbl_IDJabatan);
            Controls.Add(btn_BackToForm1);
            Controls.Add(btn_DeleteJabatan);
            Controls.Add(btn_InsertJabatan);
            Controls.Add(dgv_jabatan);
            Controls.Add(tb_jabatan);
            Controls.Add(lbl_Jabatan);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_jabatan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Jabatan;
        private TextBox tb_jabatan;
        private DataGridView dgv_jabatan;
        private Button btn_InsertJabatan;
        private Button btn_DeleteJabatan;
        private Button btn_BackToForm1;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Label lbl_IDJabatan;
        private TextBox tb_idjabatan;
    }
}