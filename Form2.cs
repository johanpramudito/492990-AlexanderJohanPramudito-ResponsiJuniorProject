using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _492990_AlexanderJohanPramudito_ResponsiJuniorProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost; Port=5432; Username=postgres; Password=informatika; Database=ResponsiJuniorProject";

        public DataTable dtjabatan;
        public static NpgsqlCommand cmd;
        public string sql = null;
        private DataGridViewRow rjabatan;

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            LoadData();
        }

        private void btn_InsertJabatan_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "SELECT * FROM jabatan_insert(:_id_jabatan, :_nama_jabatan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_jabatan", tb_idjabatan.Text);
                cmd.Parameters.AddWithValue("_nama_jabatan", tb_jabatan.Text);

                object result = cmd.ExecuteScalar();
                if (result != null && (int)result == 1)
                {
                    MessageBox.Show("Data berhasil ditambahkan!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    LoadData();
                    tb_jabatan.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DeleteJabatan_Click(object sender, EventArgs e)
        {
            if (rjabatan == null)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        sql = "SELECT * FROM kr_delete(:_id_jabatan)";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("_id_jabatan", rjabatan.Cells["_id_jabatan"].Value.ToString());

                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            MessageBox.Show("Data berhasil dihapus!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                            LoadData();
                            tb_jabatan.Text = null;
                            rjabatan = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Gagal Menghapus!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rjabatan = dgv_jabatan.Rows[e.RowIndex];
                tb_jabatan.Text = rjabatan.Cells["_nama"].Value.ToString();
            }
        }

        private void btn_BackToForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                dgv_jabatan.DataSource = null;
                sql = "SELECT * FROM jabatan_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dtjabatan = new DataTable();
                NpgsqlDataReader reader = cmd.ExecuteReader();
                dtjabatan.Load(reader);
                dgv_jabatan.DataSource = dtjabatan;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
