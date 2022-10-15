using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusBiletSatisi
{
    public partial class Islem_Yap : Form
    {
        public Islem_Yap()
        {
            InitializeComponent();
        }

        private void Islem_Yap_Load(object sender, EventArgs e)
        {
            lbl_tarih.Text = DateTime.Now.ToString();
            cmb_islem.SelectedIndex = 0;
            cmb_musteri_cinsiyet.SelectedIndex = 0;
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            Close();
        }
        public int tamam = 0;
        private void btn_kadyet_Click(object sender, EventArgs e)
        {
            if (cmb_islem.SelectedIndex == 2)
            {
                tamam = 2;
                txt_mustari.Text = "Koltuk İptal";
               // cmb_musteri_cinsiyet.SelectedIndex = -1;
                Close();
            }
            else
            {
                if (txt_mustari.Text.Length > 0 && cmb_musteri_cinsiyet.SelectedIndex >= 0 && cmb_islem.SelectedIndex >= 0)
                {
                    tamam = 1;
                    Close();
                }
                else
                {
                    MessageBox.Show("*'lı alanları boş bırakamazsınız.", "Zorunlu Alan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void cmb_islem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
