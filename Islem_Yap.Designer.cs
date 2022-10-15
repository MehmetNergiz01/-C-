namespace OtobusBiletSatisi
{
    partial class Islem_Yap
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mustari = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_koltuk_no = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.lbl_gorevli = new System.Windows.Forms.Label();
            this.cmb_musteri_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_kadyet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_islem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Yapan :";
            // 
            // txt_mustari
            // 
            this.txt_mustari.Location = new System.Drawing.Point(142, 68);
            this.txt_mustari.Name = "txt_mustari";
            this.txt_mustari.Size = new System.Drawing.Size(100, 20);
            this.txt_mustari.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koltuk No :";
            // 
            // lbl_koltuk_no
            // 
            this.lbl_koltuk_no.AutoSize = true;
            this.lbl_koltuk_no.Location = new System.Drawing.Point(142, 9);
            this.lbl_koltuk_no.Name = "lbl_koltuk_no";
            this.lbl_koltuk_no.Size = new System.Drawing.Size(16, 13);
            this.lbl_koltuk_no.TabIndex = 4;
            this.lbl_koltuk_no.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "İşlem Tarihi :";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(142, 27);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(16, 13);
            this.lbl_tarih.TabIndex = 6;
            this.lbl_tarih.Text = "...";
            // 
            // lbl_gorevli
            // 
            this.lbl_gorevli.AutoSize = true;
            this.lbl_gorevli.Location = new System.Drawing.Point(142, 49);
            this.lbl_gorevli.Name = "lbl_gorevli";
            this.lbl_gorevli.Size = new System.Drawing.Size(78, 13);
            this.lbl_gorevli.TabIndex = 7;
            this.lbl_gorevli.Text = "Mehmet Nergiz";
            // 
            // cmb_musteri_cinsiyet
            // 
            this.cmb_musteri_cinsiyet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_musteri_cinsiyet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_musteri_cinsiyet.FormattingEnabled = true;
            this.cmb_musteri_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_musteri_cinsiyet.Location = new System.Drawing.Point(142, 94);
            this.cmb_musteri_cinsiyet.Name = "cmb_musteri_cinsiyet";
            this.cmb_musteri_cinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmb_musteri_cinsiyet.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yolcu Ad Soyad * :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Yolcu Cinsiyet * :";
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Tomato;
            this.btn_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptal.Location = new System.Drawing.Point(40, 168);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(99, 48);
            this.btn_iptal.TabIndex = 11;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_kadyet
            // 
            this.btn_kadyet.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_kadyet.Location = new System.Drawing.Point(144, 168);
            this.btn_kadyet.Name = "btn_kadyet";
            this.btn_kadyet.Size = new System.Drawing.Size(99, 48);
            this.btn_kadyet.TabIndex = 12;
            this.btn_kadyet.Text = "Kaydet";
            this.btn_kadyet.UseVisualStyleBackColor = false;
            this.btn_kadyet.Click += new System.EventHandler(this.btn_kadyet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Yapılacak İşlem * : ";
            // 
            // cmb_islem
            // 
            this.cmb_islem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_islem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_islem.FormattingEnabled = true;
            this.cmb_islem.Items.AddRange(new object[] {
            "Rezerve",
            "Satış",
            "Kullanılamaz"});
            this.cmb_islem.Location = new System.Drawing.Point(142, 121);
            this.cmb_islem.Name = "cmb_islem";
            this.cmb_islem.Size = new System.Drawing.Size(121, 21);
            this.cmb_islem.TabIndex = 13;
            this.cmb_islem.SelectedIndexChanged += new System.EventHandler(this.cmb_islem_SelectedIndexChanged);
            // 
            // Islem_Yap
            // 
            this.AcceptButton = this.btn_kadyet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_iptal;
            this.ClientSize = new System.Drawing.Size(283, 236);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_islem);
            this.Controls.Add(this.btn_kadyet);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_musteri_cinsiyet);
            this.Controls.Add(this.lbl_gorevli);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_koltuk_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mustari);
            this.Controls.Add(this.label1);
            this.Name = "Islem_Yap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Islem_Yap";
            this.Load += new System.EventHandler(this.Islem_Yap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_kadyet;
        public System.Windows.Forms.TextBox txt_mustari;
        public System.Windows.Forms.Label lbl_koltuk_no;
        public System.Windows.Forms.Label lbl_tarih;
        public System.Windows.Forms.Label lbl_gorevli;
        public System.Windows.Forms.ComboBox cmb_musteri_cinsiyet;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmb_islem;
    }
}