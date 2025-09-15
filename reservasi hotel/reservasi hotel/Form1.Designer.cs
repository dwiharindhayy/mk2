namespace reservasi_hotel
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
            label1 = new Label();
            tbnama = new TextBox();
            tbemail = new TextBox();
            tbnomor = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            rbcash = new RadioButton();
            rbtransfer = new RadioButton();
            rbwallet = new RadioButton();
            groupBox3 = new GroupBox();
            tpcheckout = new DateTimePicker();
            tpcheckin = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cbtipe = new ComboBox();
            label8 = new Label();
            tbtotal = new TextBox();
            btnpesan = new Button();
            btnreset = new Button();
            groupBox4 = new GroupBox();
            tbstruk = new TextBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 26);
            label1.Name = "label1";
            label1.Size = new Size(204, 39);
            label1.TabIndex = 0;
            label1.Text = "Reservasi Hotel";
            // 
            // tbnama
            // 
            tbnama.Location = new Point(139, 25);
            tbnama.Name = "tbnama";
            tbnama.Size = new Size(175, 23);
            tbnama.TabIndex = 1;
            tbnama.TextChanged += textBox1_TextChanged;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(139, 53);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(175, 23);
            tbemail.TabIndex = 2;
            // 
            // tbnomor
            // 
            tbnomor.Location = new Point(139, 81);
            tbnomor.Name = "tbnomor";
            tbnomor.Size = new Size(175, 23);
            tbnomor.TabIndex = 3;
            tbnomor.TextChanged += textBox3_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbnama);
            groupBox1.Controls.Add(tbnomor);
            groupBox1.Controls.Add(tbemail);
            groupBox1.Location = new Point(61, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 120);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informasi Tamu";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 87);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 9;
            label4.Text = "Nomor HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 59);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 8;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 27);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 7;
            label2.Text = "Nama Lengkap ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbcash);
            groupBox2.Controls.Add(rbtransfer);
            groupBox2.Controls.Add(rbwallet);
            groupBox2.Location = new Point(492, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 120);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Metode Pembayaran";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // rbcash
            // 
            rbcash.AutoSize = true;
            rbcash.Location = new Point(16, 83);
            rbcash.Name = "rbcash";
            rbcash.Size = new Size(61, 21);
            rbcash.TabIndex = 8;
            rbcash.TabStop = true;
            rbcash.Text = "Cash";
            rbcash.UseVisualStyleBackColor = true;
            // 
            // rbtransfer
            // 
            rbtransfer.AutoSize = true;
            rbtransfer.Location = new Point(16, 55);
            rbtransfer.Name = "rbtransfer";
            rbtransfer.Size = new Size(83, 21);
            rbtransfer.TabIndex = 7;
            rbtransfer.TabStop = true;
            rbtransfer.Text = "Transfer";
            rbtransfer.UseVisualStyleBackColor = true;
            // 
            // rbwallet
            // 
            rbwallet.AutoSize = true;
            rbwallet.Location = new Point(16, 27);
            rbwallet.Name = "rbwallet";
            rbwallet.Size = new Size(81, 21);
            rbwallet.TabIndex = 6;
            rbwallet.TabStop = true;
            rbwallet.Text = "e-Wallet";
            rbwallet.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tpcheckout);
            groupBox3.Controls.Add(tpcheckin);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(cbtipe);
            groupBox3.Location = new Point(61, 196);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(335, 127);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detail Reservasi";
            // 
            // tpcheckout
            // 
            tpcheckout.Location = new Point(138, 79);
            tpcheckout.Name = "tpcheckout";
            tpcheckout.Size = new Size(175, 23);
            tpcheckout.TabIndex = 10;
            // 
            // tpcheckin
            // 
            tpcheckin.Location = new Point(138, 51);
            tpcheckin.Name = "tpcheckin";
            tpcheckin.Size = new Size(175, 23);
            tpcheckin.TabIndex = 7;
            tpcheckin.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 83);
            label7.Name = "label7";
            label7.Size = new Size(72, 17);
            label7.TabIndex = 9;
            label7.Text = "Check-out";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 54);
            label6.Name = "label6";
            label6.Size = new Size(63, 17);
            label6.TabIndex = 8;
            label6.Text = "Check-in";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 29);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 7;
            label5.Text = "Tipe Kamar";
            // 
            // cbtipe
            // 
            cbtipe.FormattingEnabled = true;
            cbtipe.Items.AddRange(new object[] { "Single", "Double", "Suite" });
            cbtipe.Location = new Point(139, 22);
            cbtipe.Name = "cbtipe";
            cbtipe.Size = new Size(175, 25);
            cbtipe.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 25);
            label8.Name = "label8";
            label8.Size = new Size(83, 17);
            label8.TabIndex = 7;
            label8.Text = "Total Harga";
            // 
            // tbtotal
            // 
            tbtotal.Location = new Point(118, 22);
            tbtotal.Name = "tbtotal";
            tbtotal.Size = new Size(172, 23);
            tbtotal.TabIndex = 7;
            // 
            // btnpesan
            // 
            btnpesan.Location = new Point(118, 54);
            btnpesan.Name = "btnpesan";
            btnpesan.Size = new Size(83, 25);
            btnpesan.TabIndex = 7;
            btnpesan.Text = "Pesan";
            btnpesan.UseVisualStyleBackColor = true;
            btnpesan.Click += btnpesan_Click;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(207, 54);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(83, 25);
            btnreset.TabIndex = 11;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnreset);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(btnpesan);
            groupBox4.Controls.Add(tbtotal);
            groupBox4.Location = new Point(492, 196);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(299, 127);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ringkasan Pesanan";
            // 
            // tbstruk
            // 
            tbstruk.Location = new Point(61, 365);
            tbstruk.Multiline = true;
            tbstruk.Name = "tbstruk";
            tbstruk.ReadOnly = true;
            tbstruk.ScrollBars = ScrollBars.Vertical;
            tbstruk.Size = new Size(730, 115);
            tbstruk.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(61, 345);
            label9.Name = "label9";
            label9.Size = new Size(192, 17);
            label9.TabIndex = 9;
            label9.Text = "Struk Pembayaran Reservasi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(851, 492);
            Controls.Add(label9);
            Controls.Add(tbstruk);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "Form1";
            Text = "Pesan";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbnama;
        private TextBox tbemail;
        private TextBox tbnomor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbtransfer;
        private RadioButton rbwallet;
        private RadioButton rbcash;
        private GroupBox groupBox3;
        private ComboBox cbtipe;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker tpcheckin;
        private DateTimePicker tpcheckout;
        private Button btnpesan;
        private TextBox tbtotal;
        private Label label8;
        private Button btnreset;
        private GroupBox groupBox4;
        private TextBox tbstruk;
        private Label label9;
    }
}
