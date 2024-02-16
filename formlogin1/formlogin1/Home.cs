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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace formlogin1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namaBuku = textBox1.Text.Trim();

            using (SqlConnection connection = new SqlConnection(@"Data Source=CORNELIUSHW\CORNELIUSHW;Initial Catalog=TokoBuku;Integrated Security=True"))
            {
                string query = "SELECT * FROM DataBuku WHERE Nama = @Nama";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nama", namaBuku);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                labelJudulBuku.Text = row.Cells["Nama"].Value.ToString();
                labelPengarang.Text = row.Cells["Pengarang"].Value.ToString();
                labelHarga.Text = row.Cells["Harga"].Value.ToString();



            }
            else
            {
                MessageBox.Show("Pilih buku yang ingin dibeli terlebih dahulu.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxJumlahPembayaran.Text, out double jumlahPembayaran))
            {
                MessageBox.Show("Masukkan jumlah pembayaran yang valid.");
                return;
            }

            if (!double.TryParse(labelHarga.Text, out double hargaBuku))
            {
                MessageBox.Show("Harga buku tidak valid.");
                return;
            }

            if (jumlahPembayaran >= hargaBuku)
            {
                double kembalian = jumlahPembayaran - hargaBuku;
                MessageBox.Show($"Terima kasih telah membeli buku {labelJudulBuku.Text}. Kembalian Anda: {kembalian:C}");



            }
            else
            {
                MessageBox.Show("Maaf, jumlah pembayaran tidak mencukupi.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login back = new Login();
            back.Show();
        }
    }
}
