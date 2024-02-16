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
    public partial class TambahBuku : Form
    {
        public TambahBuku()
        {
            InitializeComponent();
        }

        private SqlConnection koneksi = new SqlConnection(@"Data Source=CORNELIUSHW\CORNELIUSHW;Initial Catalog=TokoBuku;Integrated Security=True");

        private void btSave_Click(object sender, EventArgs e)
        {
            string namaBuku = textBox1.Text;
            string pengarang = textBox2.Text;
            double harga = Convert.ToDouble(textBox3.Text);

            // Query SQL untuk menambahkan buku baru
            string query = "INSERT INTO DataBuku (Nama, Pengarang, Harga) VALUES (@Nama, @Pengarang, @Harga)";

            using (SqlCommand command = new SqlCommand(query, koneksi))
            {
                command.Parameters.AddWithValue("@Nama", namaBuku);
                command.Parameters.AddWithValue("@Pengarang", pengarang);
                command.Parameters.AddWithValue("@Harga", harga);

                koneksi.Open();
                int rowsAffected = command.ExecuteNonQuery();
                koneksi.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Buku berhasil ditambahkan.");
                    this.Close(); // Tutup form setelah buku berhasil ditambahkan
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan buku.");
                }
            }
        }
    }
}
