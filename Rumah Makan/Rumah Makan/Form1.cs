namespace Rumah_Makan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
        // Variabel untuk menyimpan hasil perhitungan
        private decimal totalHarga = 0;
        private decimal potonganHarga = 0;
        private decimal totalBayar = 0;
        private decimal grandTotal = 0;



        private void Fo_Load(object sender, EventArgs e)
        {
            jm.Items.Add("Cake");
            jm.Items.Add("Drink");
            nm.Items.Clear();
        }

        private void jm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jm.Text == "Cake")
            {
                nm.SelectedIndexChanged -= nm_SelectedIndexChanged;
                nm.Items.Clear();
                nm.Text = "";
                nm.Items.Add("Brulee Cake");
                nm.Items.Add("Cromboloni");
                nm.Items.Add("Korean Cream Cake");
                nm.Items.Add("Mochi Crunch Cake");
                nm.SelectedIndexChanged += nm_SelectedIndexChanged;
            }

            else if (jm.Text == "Drink")
            {
                nm.SelectedIndexChanged -= nm_SelectedIndexChanged;
                nm.Items.Clear();
                nm.Text = "";
                nm.Items.Add("Dalgona Coffe");
                nm.Items.Add("Squash Yakult");
                nm.Items.Add("Magic Water");
                nm.Items.Add("Matcha Cream Cloud");
                nm.SelectedIndexChanged += nm_SelectedIndexChanged;
            }
        }

        private void nm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nm.Text == "Brulee Cake")
                harga.Text = "25000";

            else if (nm.Text == "Cromboloni")
                harga.Text = "20000";

            else if (nm.Text == "Korean Cream Cake")
                harga.Text = "35000";

            else if (nm.Text == "Mochi Crunch Cake")
                harga.Text = "25000";

            else if (nm.Text == "Dalgona Coffe")
                harga.Text = "10000";

            else if (nm.Text == "Squash Yakult")
                harga.Text = "15000";

            else if (nm.Text == "Magic Water")
                harga.Text = "18000";

            else if (nm.Text == "Matcha Cream Cloud")
                harga.Text = "14000";

            // Hitung total setelah harga berubah
            HitungTotal();
        }

        // Method untuk menghitung total, diskon, dan total bayar
        private void HitungTotal()
        {
            try
            {
                // Ambil harga
                decimal hargaSatuan = 0;
                decimal.TryParse(harga.Text, out hargaSatuan);

                // Ambil jumlah
                int jml = 0;
                int.TryParse(jumlah.Text, out jml);

                // Hitung total harga
                totalHarga = hargaSatuan * jml;

                // Hitung diskon
                if (totalHarga >= 50000)
                    potonganHarga = 10000;
                else
                    potonganHarga = 0;

                // Hitung total bayar
                totalBayar = totalHarga - potonganHarga;

                // Tampilkan hasil
                th.Text = totalHarga.ToString("N0");
                disk.Text = potonganHarga.ToString("N0");
                tb.Text = totalBayar.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Event saat jumlah berubah
        private void jumlah_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        // Tombol ORDER (button1)
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nno.Text))
            {
                MessageBox.Show("Please fill the Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(jm.Text))
            {
                MessageBox.Show("Please select Types!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(nm.Text))
            {
                MessageBox.Show("Please select Drink/Cake!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(jumlah.Text) || jumlah.Text == "0")
            {
                MessageBox.Show("Please fill Amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hitung total
            HitungTotal();

            // Tampilkan NOTA pesanan
            string pesan = "==== DETAIL ORDER ====\n\n" +
             $"NAME: {nno.Text}\n" +
             $"TYPES: {jm.Text}\n" +
             $"MENU: {nm.Text}\n" +
             $"PRICE: Rp {harga.Text}\n" +
             $"AMOUNT: {jumlah.Text}\n\n" +
             "-------------------------\n" +
             $"TOTAL PRICE: Rp {totalHarga:N0}\n" +
             $"DISCOUNT: Rp {potonganHarga:N0}\n" +
             "-------------------------\n" +
             $"TOTAL PAYMENT: Rp {totalBayar:N0}";

            MessageBox.Show(pesan, "Konfirmasi Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Tombol CANCEL (button2)
        private void
            bton2_Click(object sender, EventArgs e)
        {
            nno.Text = "";
            jm.Text = "";
            jm.Items.Clear();
            nm.Items.Clear();
            nm.Text = "";
            harga.Text = "";
            jumlah.Text = "";
            th.Text = "";
            disk.Text = "";
            tb.Text = "";

            totalHarga = 0;
            potonganHarga = 0;
            totalBayar = 0;
        }

        private void nno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}