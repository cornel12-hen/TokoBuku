using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formlogin1
{
    public partial class Admin : Form
    {
        private SqlConnection koneksi = new SqlConnection(@"Data Source=CORNELIUSHW\CORNELIUSHW;Initial Catalog=TokoBuku;Integrated Security=True");
        public Admin()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login back = new Login();
            back.Show();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string namaBuku = textBox1.Text;
            string pengarang = textBox2.Text;
            double harga;
            if (!double.TryParse(textBox3.Text, out harga))
            {
                MessageBox.Show("Harga harus berupa angka yang valid.");
                return;
            }

            string query = "UPDATE DataBuku SET Pengarang = @Pengarang, Harga = @Harga WHERE Nama = @Nama";

            using (SqlCommand command = new SqlCommand(query, koneksi))
            {
                command.Parameters.AddWithValue("@Nama", namaBuku);
                command.Parameters.AddWithValue("@Pengarang", pengarang);
                command.Parameters.AddWithValue("@Harga", harga);
                koneksi.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data buku berhasil diupdate.");
                }
                else
                {
                    MessageBox.Show("Gagal melakukan update data buku.");
                }

                koneksi.Close();
            }

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            string namaBuku = textBox1.Text;

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data buku ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM DataBuku WHERE Nama = @Nama";

                using (SqlCommand command = new SqlCommand(query, koneksi))
                {
                    command.Parameters.AddWithValue("@Nama", namaBuku);

                    koneksi.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data buku berhasil dihapus.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data buku.");
                    }

                    koneksi.Close();
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DataBuku";

            using (SqlCommand command = new SqlCommand(query, koneksi))
            {
                koneksi.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox1.Text = reader["Nama"].ToString();
                        textBox2.Text = reader["Pengarang"].ToString();
                        textBox3.Text = reader["Harga"].ToString();
                    }
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader.Read())
                        {
                            textBox6.Text = reader["Nama"].ToString();
                            textBox5.Text = reader["Pengarang"].ToString();
                            textBox4.Text = reader["Harga"].ToString();
                        }
                    }
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader.Read())
                        {
                            if (reader.Read())
                            {
                                textBox12.Text = reader["Nama"].ToString();
                                textBox11.Text = reader["Pengarang"].ToString();
                                textBox10.Text = reader["Harga"].ToString();
                            }
                        }
                    }
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader.Read())
                        {
                            if (reader.Read())
                            {
                                if (reader.Read())
                                {
                                    textBox9.Text = reader["Nama"].ToString();
                                    textBox8.Text = reader["Pengarang"].ToString();
                                    textBox7.Text = reader["Harga"].ToString();
                                }
                            }
                        }
                    }
                }

                koneksi.Close();
            }
        }

        private void btSave2_Click(object sender, EventArgs e)
        {
            string namaBuku = textBox6.Text;
            string pengarang = textBox5.Text;
            double harga;
            if (!double.TryParse(textBox4.Text, out harga))
            {
                MessageBox.Show("Harga harus berupa angka yang valid.");
                return;
            }

            string query = "UPDATE DataBuku SET Pengarang = @Pengarang, Harga = @Harga WHERE Nama = @Nama";

            using (SqlCommand command = new SqlCommand(query, koneksi))
            {
                command.Parameters.AddWithValue("@Nama", namaBuku);
                command.Parameters.AddWithValue("@Pengarang", pengarang);
                command.Parameters.AddWithValue("@Harga", harga);
                koneksi.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data buku berhasil diupdate.");
                }
                else
                {
                    MessageBox.Show("Gagal melakukan update data buku.");
                }

                koneksi.Close();
            }
        }

        private void btDel2_Click(object sender, EventArgs e)
        {
            string namaBuku = textBox6.Text;

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data buku ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM DataBuku WHERE Nama = @Nama";

                using (SqlCommand command = new SqlCommand(query, koneksi))
                {
                    command.Parameters.AddWithValue("@Nama", namaBuku);

                    koneksi.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data buku berhasil dihapus.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data buku.");
                    }

                    koneksi.Close();
                }
            }
        }

        private void btTambahBuku_Click(object sender, EventArgs e)
        {
            TambahBuku formTambahBuku = new TambahBuku();
            formTambahBuku.ShowDialog();
        }

        private void btSave3_Click(object sender, EventArgs e)
        {
            string namaBuku = textBox12.Text;
            string pengarang = textBox11.Text;
            double harga;
            if (!double.TryParse(textBox10.Text, out harga))
            {
                MessageBox.Show("Harga harus berupa angka yang valid.");
                return;
            }

            string query = "UPDATE DataBuku SET Pengarang = @Pengarang, Harga = @Harga WHERE Nama = @Nama";

            using (SqlCommand command = new SqlCommand(query, koneksi))
            {
                command.Parameters.AddWithValue("@Nama", namaBuku);
                command.Parameters.AddWithValue("@Pengarang", pengarang);
                command.Parameters.AddWithValue("@Harga", harga);
                koneksi.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data buku berhasil diupdate.");
                }
                else
                {
                    MessageBox.Show("Gagal melakukan update data buku.");
                }

                koneksi.Close();
            }
        }

        private void btDel3_Click(object sender, EventArgs e)
        {
            string namaBuku = textBox12.Text;

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data buku ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM DataBuku WHERE Nama = @Nama";

                using (SqlCommand command = new SqlCommand(query, koneksi))
                {
                    command.Parameters.AddWithValue("@Nama", namaBuku);

                    koneksi.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data buku berhasil dihapus.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data buku.");
                    }

                    koneksi.Close();
                }
            }
        }

        private void btSave4_Click(object sender, EventArgs e)
        {
            string namaBuku = textBox9.Text;
            string pengarang = textBox8.Text;
            double harga;
            if (!double.TryParse(textBox7.Text, out harga))
            {
                MessageBox.Show("Harga harus berupa angka yang valid.");
                return;
            }

            string query = "UPDATE DataBuku SET Pengarang = @Pengarang, Harga = @Harga WHERE Nama = @Nama";

            using (SqlCommand command = new SqlCommand(query, koneksi))
            {
                command.Parameters.AddWithValue("@Nama", namaBuku);
                command.Parameters.AddWithValue("@Pengarang", pengarang);
                command.Parameters.AddWithValue("@Harga", harga);
                koneksi.Open();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data buku berhasil diupdate.");
                }
                else
                {
                    MessageBox.Show("Gagal melakukan update data buku.");
                }

                koneksi.Close();
            }
        }

        private void btDel4_Click(object sender, EventArgs e)
        {
            string namaBuku = textBox9.Text;

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data buku ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM DataBuku WHERE Nama = @Nama";

                using (SqlCommand command = new SqlCommand(query, koneksi))
                {
                    command.Parameters.AddWithValue("@Nama", namaBuku);

                    koneksi.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data buku berhasil dihapus.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data buku.");
                    }

                    koneksi.Close();
                }
            }
        }
    }
}
