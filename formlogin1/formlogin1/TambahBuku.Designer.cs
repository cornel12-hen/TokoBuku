namespace formlogin1
{
    partial class TambahBuku
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
            pictureBox4 = new PictureBox();
            button6 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btSave = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = TokoBuku.Properties.Resources.icons8_book_100;
            pictureBox4.Location = new Point(310, 41);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(102, 100);
            pictureBox4.TabIndex = 69;
            pictureBox4.TabStop = false;
            // 
            // button6
            // 
            button6.BackgroundImage = TokoBuku.Properties.Resources.icons8_back_1002;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatAppearance.BorderSize = 0;
            button6.Location = new Point(37, 41);
            button6.Name = "button6";
            button6.Size = new Size(55, 46);
            button6.TabIndex = 68;
            button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = TokoBuku.Properties.Resources.icons8_wrong_100;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(624, 41);
            button2.Name = "button2";
            button2.Size = new Size(55, 46);
            button2.TabIndex = 67;
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bebas Neue", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(239, 157);
            label1.Name = "label1";
            label1.Size = new Size(246, 58);
            label1.TabIndex = 66;
            label1.Text = "Tambah Buku";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(340, 453);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 76;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(340, 387);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 75;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 319);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 74;
            // 
            // btSave
            // 
            btSave.Location = new Point(287, 542);
            btSave.Name = "btSave";
            btSave.Size = new Size(150, 46);
            btSave.TabIndex = 73;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 453);
            label4.Name = "label4";
            label4.Size = new Size(166, 32);
            label4.TabIndex = 72;
            label4.Text = "Harga         :   ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 387);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 71;
            label3.Text = "Pengarang  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 319);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 70;
            label2.Text = "Judul          :";
            // 
            // TambahBuku
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(711, 670);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahBuku";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private Button button6;
        private Button button2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btSave;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}