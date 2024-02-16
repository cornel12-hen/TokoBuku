namespace formlogin1
{
    partial class Home
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            labelHarga = new Label();
            labelPengarang = new Label();
            labelJudulBuku = new Label();
            textBoxJumlahPembayaran = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button5 = new Button();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bebas Neue", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(656, 151);
            label1.Name = "label1";
            label1.Size = new Size(296, 58);
            label1.TabIndex = 0;
            label1.Text = "Pembelian Buku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 401);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 15;
            label2.Text = "Cari Buku :";
            // 
            // button1
            // 
            button1.Location = new Point(284, 458);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 28;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 398);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 39);
            textBox1.TabIndex = 41;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(734, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(725, 277);
            dataGridView1.TabIndex = 42;
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(306, 886);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(0, 32);
            labelHarga.TabIndex = 46;
            // 
            // labelPengarang
            // 
            labelPengarang.AutoSize = true;
            labelPengarang.Location = new Point(306, 820);
            labelPengarang.Name = "labelPengarang";
            labelPengarang.Size = new Size(0, 32);
            labelPengarang.TabIndex = 45;
            // 
            // labelJudulBuku
            // 
            labelJudulBuku.AutoSize = true;
            labelJudulBuku.Location = new Point(306, 752);
            labelJudulBuku.Name = "labelJudulBuku";
            labelJudulBuku.Size = new Size(0, 32);
            labelJudulBuku.TabIndex = 44;
            // 
            // textBoxJumlahPembayaran
            // 
            textBoxJumlahPembayaran.Location = new Point(1125, 788);
            textBoxJumlahPembayaran.Name = "textBoxJumlahPembayaran";
            textBoxJumlahPembayaran.Size = new Size(301, 39);
            textBoxJumlahPembayaran.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(728, 788);
            label3.Name = "label3";
            label3.Size = new Size(369, 32);
            label3.TabIndex = 50;
            label3.Text = "Masukkan Nominal Pembayaran :";
            // 
            // button3
            // 
            button3.Location = new Point(1021, 624);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 51;
            button3.Text = "Beli";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(955, 856);
            button4.Name = "button4";
            button4.Size = new Size(292, 46);
            button4.TabIndex = 52;
            button4.Text = "Konfirmasi Pembelian";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 886);
            label4.Name = "label4";
            label4.Size = new Size(166, 32);
            label4.TabIndex = 55;
            label4.Text = "Harga         :   ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 820);
            label5.Name = "label5";
            label5.Size = new Size(146, 32);
            label5.TabIndex = 54;
            label5.Text = "Pengarang  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 752);
            label6.Name = "label6";
            label6.Size = new Size(146, 32);
            label6.TabIndex = 53;
            label6.Text = "Judul          :";
            // 
            // button5
            // 
            button5.BackgroundImage = TokoBuku.Properties.Resources.icons8_wrong_100;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatAppearance.BorderSize = 0;
            button5.Location = new Point(1404, 36);
            button5.Name = "button5";
            button5.Size = new Size(55, 46);
            button5.TabIndex = 56;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = TokoBuku.Properties.Resources.icons8_back_1002;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(46, 36);
            button2.Name = "button2";
            button2.Size = new Size(55, 46);
            button2.TabIndex = 57;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = TokoBuku.Properties.Resources.icons8_book_100;
            pictureBox4.Location = new Point(750, 36);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(102, 100);
            pictureBox4.TabIndex = 58;
            pictureBox4.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1637, 882);
            Controls.Add(pictureBox4);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(textBoxJumlahPembayaran);
            Controls.Add(labelHarga);
            Controls.Add(labelPengarang);
            Controls.Add(labelJudulBuku);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label labelHarga;
        private Label labelPengarang;
        private Label labelJudulBuku;
        private TextBox textBoxJumlahPembayaran;
        private Label label3;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button5;
        private Button button2;
        private PictureBox pictureBox4;
    }
}