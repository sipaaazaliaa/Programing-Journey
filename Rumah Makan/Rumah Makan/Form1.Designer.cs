namespace Rumah_Makan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            jm = new ComboBox();
            nm = new ComboBox();
            harga = new TextBox();
            jumlah = new TextBox();
            button1 = new Button();
            button2 = new Button();
            nno = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            th = new TextBox();
            label7 = new Label();
            disk = new TextBox();
            label8 = new Label();
            tb = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 120);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 177);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 1;
            label2.Text = "Types";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 225);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 2;
            label3.Text = "Menu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 270);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 316);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 4;
            label5.Text = "Amount";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(187, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // jm
            // 
            jm.DropDownStyle = ComboBoxStyle.DropDownList;
            jm.FormattingEnabled = true;
            jm.Location = new Point(187, 174);
            jm.Name = "jm";
            jm.Size = new Size(245, 33);
            jm.TabIndex = 6;
            jm.SelectedIndexChanged += jm_SelectedIndexChanged;
            // 
            // nm
            // 
            nm.DropDownStyle = ComboBoxStyle.DropDownList;
            nm.FormattingEnabled = true;
            nm.Location = new Point(187, 219);
            nm.Name = "nm";
            nm.Size = new Size(245, 33);
            nm.TabIndex = 7;
            nm.SelectedIndexChanged += nm_SelectedIndexChanged;
            // 
            // harga
            // 
            harga.Location = new Point(187, 262);
            harga.Name = "harga";
            harga.Size = new Size(245, 31);
            harga.TabIndex = 8;
            // 
            // jumlah
            // 
            jumlah.Location = new Point(187, 310);
            jumlah.Name = "jumlah";
            jumlah.Size = new Size(245, 31);
            jumlah.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(161, 376);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(290, 376);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += bton2_Click;
            // 
            // nno
            // 
            nno.Location = new Point(381, 39);
            nno.Name = "nno";
            nno.Size = new Size(130, 31);
            nno.TabIndex = 13;
            nno.TextChanged += nno_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(316, 42);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 12;
            label6.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MistyRose;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(542, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 168);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // th
            // 
            th.Location = new Point(631, 262);
            th.Name = "th";
            th.Size = new Size(130, 31);
            th.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(498, 262);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 15;
            label7.Text = "Total price";
            // 
            // disk
            // 
            disk.Location = new Point(631, 305);
            disk.Name = "disk";
            disk.Size = new Size(130, 31);
            disk.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(498, 308);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 17;
            label8.Text = "Discount";
            // 
            // tb
            // 
            tb.Location = new Point(631, 355);
            tb.Name = "tb";
            tb.Size = new Size(130, 31);
            tb.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(498, 361);
            label9.Name = "label9";
            label9.Size = new Size(124, 25);
            label9.TabIndex = 19;
            label9.Text = "Total payment";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(911, 450);
            Controls.Add(tb);
            Controls.Add(label9);
            Controls.Add(disk);
            Controls.Add(label8);
            Controls.Add(th);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(nno);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(jumlah);
            Controls.Add(harga);
            Controls.Add(nm);
            Controls.Add(jm);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bakery cashier";
            Load += Fo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private ComboBox jm;
        private ComboBox nm;
        private TextBox harga;
        private TextBox jumlah;
        private Button button1;
        private Button button2;
        private TextBox nno;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox th;
        private Label label7;
        private TextBox disk;
        private Label label8;
        private TextBox tb;
        private Label label9;
    }
}
