using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtobusBiletSatisi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyData.DataTable_Yolcular();
            MyData.DataTable_Otobus();

            panel1.Width = 207;

            cmb_otobus.DataSource = MyData.table_otobus;
            cmb_otobus.DisplayMember = "Plaka";

        }

        void DuzenKur()
        {
            DataTable dt = MyData.table_yolcu;
            int say = 0;
            panel1.Controls.Clear();
            int olcu = 41;





            for (int i = 0; i < txt_duzen.Lines.Count(); i++)// textbox satırları arasında
            {
                for (int j = 0; j < txt_duzen.Lines[i].Count(); j++) // bir satırdaki karakterler arasında
                {
                    string satir = txt_duzen.Lines[i]; // bir satırı aldık
                    if (satir[j] == '*') // satırdaki j index'ine denk gelen ifade * ise
                    {
                        Button nesne = new Button();
                        nesne.Width = nesne.Height = 40;
                        nesne.Left = olcu * j;// butonun nerede duracağı
                        nesne.Top = olcu * i; // butonun nerede duracağı


                        // Burada buttonları elips şeklinde yapmak istedim. 
                        // tam istediğim gibi elips olmadı ama daha hoş olduğu gibi geldi. :D Bu sebeple olduğu gibi bıraktım. 
                        GraphicsPath p = new GraphicsPath();
                        p.AddEllipse(1, 1, nesne.Width, nesne.Height);
                        nesne.Region = new Region(p);


                        int id = ++say;
                        nesne.Name = "buton_" + id;
                        string cinsiyet = "";
                        int durum = 0;

                        var results = from DataRow myRow in dt.Rows
                                      where (int)myRow["Koltuk_No"] == id & (string)myRow["Otobus_Plaka"] == cmb_otobus.Text
                                      select new
                                      {
                                          cinsiyet = myRow.Field<string>("Cinsiyet").ToString().Substring(0, 1),
                                          durum = myRow.Field<int>("Durum"),
                                      };
                        try
                        {
                            var resultsList = results.ToList();
                            cinsiyet = resultsList[0].cinsiyet;
                            durum = resultsList[0].durum;
                        }
                        catch (InvalidOperationException) { }
                        catch (ArgumentOutOfRangeException) { }

                        nesne.Text = id.ToString();
                        nesne.BackColor = Color.Tomato;
                        switch (durum)
                        {
                            case 1:
                                nesne.BackColor = Color.GreenYellow;
                                nesne.Text = id.ToString() + " " + cinsiyet;
                                break;
                            case 2:
                                nesne.BackColor = Color.Yellow;
                                nesne.Text = id.ToString() + " " + cinsiyet;
                                break;
                            case 3:
                                nesne.Text = id.ToString();
                                nesne.BackColor = Color.Black;
                                nesne.ForeColor = Color.White;
                                break;
                        }

                        panel1.Controls.Add(nesne);
                        nesne.Click += ButtonClick;
                    }
                }
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            Islem_Yap fr = new Islem_Yap();
            fr.lbl_koltuk_no.Text = btn.Name.Split('_')[1];
            fr.ShowDialog();
            int durum = fr.cmb_islem.SelectedIndex + 1;
            string cinsiyet = fr.cmb_musteri_cinsiyet.Text;
            if (fr.tamam >= 1)
            {
                MyData.DataTable_Yolcular_Insert(
                    Convert.ToInt32(fr.lbl_koltuk_no.Text)
                    , durum
                    , fr.txt_mustari.Text
                    , cinsiyet
                    , Convert.ToDateTime(fr.lbl_tarih.Text)
                    , fr.lbl_gorevli.Text
                    , cmb_otobus.Text);
                btn.BackColor = Color.Tomato;
                switch (durum)
                {
                    case 1:
                        btn.BackColor = Color.GreenYellow;
                        if (cinsiyet == "Erkek") btn.Text += " E"; else btn.Text += " K";
                        break;
                    case 2:
                        btn.BackColor = Color.Yellow;
                        if (cinsiyet == "Erkek") btn.Text += " E"; else btn.Text += " K";
                        break;
                    case 3:
                        btn.BackColor = Color.Black;
                        btn.ForeColor = Color.White;
                        break;
                }

                dgv_update();
            }

        }
        private void dgv_update()
        {
            var results = MyData.table_yolcu.AsEnumerable().Where(myRow => myRow.Field<string>("Otobus_Plaka") == cmb_otobus.Text);
            DataView view = results.AsDataView();
            dataGridView1.DataSource = view;
        }

        private void cmb_otobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_update();
            DuzenKur();
        }

        private void koltukDüzenPatternAlanıGösterGizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_duzen.Visible == false)
                txt_duzen.Visible = true;
            else
                txt_duzen.Visible = false;
        }
    }
}
