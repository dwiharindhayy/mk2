namespace reservasi_hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnpesan_Click(object sender, EventArgs e)
        {
            // ?? Validasi input
            if (string.IsNullOrWhiteSpace(tbnama.Text))
            {
                MessageBox.Show("Nama wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbnama.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbemail.Text))
            {
                MessageBox.Show("Email wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbemail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbnomor.Text))
            {
                MessageBox.Show("Nomor HP wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbnomor.Focus();
                return;
            }
            if (cbtipe.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih tipe kamar terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbtipe.Focus();
                return;
            }
            if (!rbwallet.Checked && !rbtransfer.Checked && !rbcash.Checked)
            {
                MessageBox.Show("Pilih metode pembayaran!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nama = tbnama.Text;
            string email = tbemail.Text;
            string nomor = tbnomor.Text;
            string tipeKamar = cbtipe.SelectedItem != null ? cbtipe.SelectedItem.ToString() : "-";
            DateTime checkin = tpcheckin.Value;
            DateTime checkout = tpcheckout.Value;

            string metodePembayaran = "";
            if (rbwallet.Checked) metodePembayaran = "e-Wallet";
            else if (rbtransfer.Checked) metodePembayaran = "Transfer";
            else if (rbcash.Checked) metodePembayaran = "Cash";

            // Hitung lama inap
            int lamaInap = (checkout - checkin).Days;
            if (lamaInap <= 0) lamaInap = 1; // minimal 1 malam

            // Harga per malam
            int hargaPerMalam = 0;
            if (tipeKamar == "Single") hargaPerMalam = 300000;
            else if (tipeKamar == "Double") hargaPerMalam = 500000;
            else if (tipeKamar == "Suite") hargaPerMalam = 1000000;

            int total = hargaPerMalam * lamaInap;
            tbtotal.Text = total.ToString("Rp #,###");

            // Generate nomor kamar random
            Random rnd = new Random();
            int lantai = rnd.Next(1, 6); // lantai 1-5
            int nomorKamar = rnd.Next(100, 999); // nomor kamar 100-999
            string kamar = $"{lantai}-{nomorKamar}";

            // Struk
            string struk = "===== STRUK RESERVASI HOTEL =====\r\n";
            struk += $"Nama Tamu       : {nama}\r\n";
            struk += $"Email           : {email}\r\n";
            struk += $"Nomor HP        : {nomor}\r\n";
            struk += $"Tipe Kamar      : {tipeKamar}\r\n";
            struk += $"Nomor Kamar     : {kamar}\r\n";
            struk += $"Check-in        : {checkin:dd/MM/yyyy}\r\n";
            struk += $"Check-out       : {checkout:dd/MM/yyyy}\r\n";
            struk += $"Metode Bayar    : {metodePembayaran}\r\n";
            struk += $"Lama Inap       : {lamaInap} malam\r\n";
            struk += $"Total Harga     : {total.ToString("Rp #,###")}\r\n";
            struk += "=================================\r\n";
            struk += "   Terima kasih atas reservasi Anda!\r\n";

            tbstruk.Text = struk; // tampilkan ke textbox multiline
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            tbnama.Clear();
            tbemail.Clear();
            tbnomor.Clear();
            cbtipe.SelectedIndex = -1;
            rbwallet.Checked = false;
            rbtransfer.Checked = false;
            rbcash.Checked = false;
            tbtotal.Clear();
            tbstruk.Clear();
            tpcheckin.Value = DateTime.Now;
            tpcheckout.Value = DateTime.Now;
        }
    }
}
