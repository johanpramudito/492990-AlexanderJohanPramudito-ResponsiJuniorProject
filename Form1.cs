using Npgsql;
using System.Data;
using System.Reflection.Metadata;

namespace _492990_AlexanderJohanPramudito_ResponsiJuniorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost; Port=5432; Username=postgres; Password=informatika; Database=ResponsiJuniorProject";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        public string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            LoadData();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "SELECT * FROM kr_insert(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("_id_dep", cb_departemen.SelectedItem.ToString());

                object result = cmd.ExecuteScalar();
                if (result != null && (int)result == 1)
                {
                    MessageBox.Show("Data berhasil ditambahkan!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    LoadData();
                    tb_nama.Text = cb_departemen.Text = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih data yang akan diubah!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    conn.Open();
                    sql = "SELECT * FROM kr_update(:_id_karyawan, :_nama, :_id_dep)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                    cmd.Parameters.AddWithValue("_nama", tb_nama.Text);
                    cmd.Parameters.AddWithValue("_id_dep", cb_departemen.SelectedItem.ToString());

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data berhasil diubah!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        LoadData();
                        tb_nama.Text = cb_departemen.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (r == null)
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
                        sql = "SELECT * FROM kr_delete(:_id_karyawan)";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());

                        if ((int)cmd.ExecuteScalar() == 1)
                        {
                            MessageBox.Show("Data berhasil dihapus!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                            LoadData();
                            tb_nama.Text = cb_departemen.Text = null;
                            r = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Gagal Menghapus!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgv_karyawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgv_karyawan.Rows[e.RowIndex];
                lblDynamic_Karyawan.Text = r.Cells["_id_karyawan"].Value.ToString();
                tb_nama.Text = r.Cells["_nama"].Value.ToString();
                cb_departemen.Text = r.Cells["_id_dep"].Value.ToString();
            }
        }

        private void dgv_karyawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgv_karyawan.Rows[e.RowIndex];
                lblDynamic_Karyawan.Text = r.Cells["_id_karyawan"].Value.ToString();
                tb_nama.Text = r.Cells["_nama"].Value.ToString();
                string id_dept = r.Cells["_id_dep"].Value.ToString();
            }
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                dgv_karyawan.DataSource = null;
                sql = "SELECT * FROM kr_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                dgv_karyawan.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Jabatan_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}

