using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cagri_Merkezi_Uygulamasi
{
    public partial class frmCagriMerkezi : Form
    {
        public frmCagriMerkezi()
        {
            InitializeComponent();
        }

        Musteri musteri = new Musteri();
        //İki bireysel iki ticari olmak üzere odrt adet müşteri temsilcisi tanımladık
        MusteriTemsilcisi ticari_1 = new MusteriTemsilcisi();
        MusteriTemsilcisi ticari_2 = new MusteriTemsilcisi();
        MusteriTemsilcisi bireysel_1 = new MusteriTemsilcisi();
        MusteriTemsilcisi bireysel_2 = new MusteriTemsilcisi();

        private void btnKayıtlar_Click(object sender, EventArgs e)
        {
            
            musteri.MusteriNo = 10;
            ticari_1.CagriEkle(musteri.MusteriNo);

            musteri.MusteriNo = 15;
            ticari_2.CagriEkle(musteri.MusteriNo);
            
            musteri.MusteriNo = 20;
            bireysel_1.CagriEkle(musteri.MusteriNo);
            
            musteri.MusteriNo = 25;
            bireysel_2.CagriEkle(musteri.MusteriNo);

            MessageBox.Show("Varsayılan Kayıtlar Başarıyla Yüklendi");

        }

        private void btnCagriOlustur_Click(object sender, EventArgs e)
        {
            musteri.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
            if(txtMusteriTuru.Text.ToString() == "Bireysel")
            {
                if(bireysel_1.sira > bireysel_2.sira)
                {
                    bireysel_2.CagriEkle(musteri.MusteriNo);
                    
                }
                else
                {
                    bireysel_1.CagriEkle(musteri.MusteriNo);
                }
                MessageBox.Show("Çağrı Başarıyla Eklendi");
            }
            else if (txtMusteriTuru.Text.ToString() == "Ticari")
            {
                if(ticari_1.sira > ticari_2.sira)
                {
                    ticari_2.CagriEkle(musteri.MusteriNo);
                }
                else
                {
                    ticari_1.CagriEkle(musteri.MusteriNo);
                    
                }
                MessageBox.Show("Çağrı Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Hata: Lütfen Müşteri Türünüzü Belirtildiği Şekilde Yazın!!! ");
            }
            
            txtMusteriNo.Clear();
            txtMusteriNo.Focus();
            txtMusteriTuru.Clear();
        }

        private void btnSiralaArama_Click(object sender, EventArgs e)
        {
            listBireyselMT_1.Rows.Clear();
            listBireyselMT_2.Rows.Clear();
            listTicariMT_1.Rows.Clear();
            listTicariMT_2.Rows.Clear();

            listBireyselMT_1.ColumnCount = 2;
            listBireyselMT_1.Columns[0].Name = "Sıra";
            listBireyselMT_1.Columns[1].Name = "Müşteri Numarası";

            listBireyselMT_2.ColumnCount = 2;
            listBireyselMT_2.Columns[0].Name = "Sıra";
            listBireyselMT_2.Columns[1].Name = "Müşteri Numarası";

            listTicariMT_1.ColumnCount = 2;
            listTicariMT_1.Columns[0].Name = "Sıra";
            listTicariMT_1.Columns[1].Name = "Müşteri Numarası";

            listTicariMT_2.ColumnCount = 2;
            listTicariMT_2.Columns[0].Name = "Sıra";
            listTicariMT_2.Columns[1].Name = "Müşteri Numarası";

            Musteri temp = bireysel_1.ilkMusteri;
            int kacinci = 1;
            while (temp != null)
            {
                listBireyselMT_1.Rows.Add(kacinci,bireysel_1.CagriYazdir(temp)); 
                temp = temp.sonrakiMusteri;
                kacinci++;
            }
            kacinci = 1;
            temp = bireysel_2.ilkMusteri;
            while (temp != null)
            {
                listBireyselMT_2.Rows.Add(kacinci, bireysel_1.CagriYazdir(temp));
                temp = temp.sonrakiMusteri; 
                kacinci++;
            }
            kacinci = 1;
            temp = ticari_1.ilkMusteri;
            while (temp!=null)
            {
                listTicariMT_1.Rows.Add(kacinci, bireysel_1.CagriYazdir(temp));
                temp = temp.sonrakiMusteri;
                kacinci++;
            }
            kacinci = 1;
            temp = ticari_2.ilkMusteri;
            while (temp!=null)
            {
                listTicariMT_2.Rows.Add(kacinci, bireysel_1.CagriYazdir(temp));
                temp = temp.sonrakiMusteri;
                kacinci++;
            }
            

            
        }

        private void btnSiralaNo_Click(object sender, EventArgs e)
        {
            listBireyselMT_1.Rows.Clear();
            listBireyselMT_2.Rows.Clear();
            listTicariMT_1.Rows.Clear();
            listTicariMT_2.Rows.Clear();

            listBireyselMT_1.ColumnCount = 2;
            listBireyselMT_1.Columns[0].Name = "Sıra";
            listBireyselMT_1.Columns[1].Name = "Müşteri Numarası";

            listBireyselMT_2.ColumnCount = 2;
            listBireyselMT_2.Columns[0].Name = "Sıra";
            listBireyselMT_2.Columns[1].Name = "Müşteri Numarası";

            listTicariMT_1.ColumnCount = 2;
            listTicariMT_1.Columns[0].Name = "Sıra";
            listTicariMT_1.Columns[1].Name = "Müşteri Numarası";

            listTicariMT_2.ColumnCount = 2;
            listTicariMT_2.Columns[0].Name = "Sıra";
            listTicariMT_2.Columns[1].Name = "Müşteri Numarası";

            Musteri curr = bireysel_1.ilkMusteri;
            int kacinci = 1;
            while (curr != null)
            {
                listBireyselMT_1.Rows.Add(kacinci,bireysel_1.CagriSirala(curr));
                curr = curr.sonrakiMusteri;
                kacinci++;
            }
            curr = bireysel_2.ilkMusteri;
            kacinci = 1;
            while (curr != null)
            {
                listBireyselMT_2.Rows.Add(kacinci, bireysel_2.CagriSirala(curr));
                curr = curr.sonrakiMusteri;
                kacinci++;
            }
            curr = ticari_1.ilkMusteri;
            kacinci = 1;
            while (curr != null)
            {
                listTicariMT_1.Rows.Add(kacinci, ticari_1.CagriSirala(curr));
                curr = curr.sonrakiMusteri;
                kacinci++;
            }
            curr = ticari_2.ilkMusteri;
            kacinci = 1;
            while (curr != null)
            {
                listTicariMT_2.Rows.Add(kacinci, ticari_2.CagriSirala(curr));
                curr = curr.sonrakiMusteri;
                kacinci++;
            }
        }

        private void btnHattaBagla_Click(object sender, EventArgs e)
        {
            int MusteriNo = Convert.ToInt32(txtMusteriNoGir.Text);

            if (bireysel_1.CagriBaslat(MusteriNo))
            {
                MessageBox.Show("Görüşme Bilgileri"+Environment.NewLine+"Müşteri Temsilcisi: Bireysel Müşteri Temsilcisi 1"+Environment.NewLine+"Müşteri Numarası: "+MusteriNo+Environment.NewLine);
            }
            else if (bireysel_2.CagriBaslat(MusteriNo))
            {
                MessageBox.Show("Görüşme Bilgileri" + Environment.NewLine + "Müşteri Temsilcisi: Bireysel Müşteri Temsilcisi 2" + Environment.NewLine + "Müşteri Numarası: " + MusteriNo + Environment.NewLine);
            }
            else if (ticari_1.CagriBaslat(MusteriNo))
            {
                MessageBox.Show("Görüşme Bilgileri" + Environment.NewLine + "Müşteri Temsilcisi: Ticari Müşteri Temsilcisi 1" + Environment.NewLine + "Müşteri Numarası: " + MusteriNo + Environment.NewLine);
            }
            else if (ticari_2.CagriBaslat(MusteriNo))
            {
                MessageBox.Show("Görüşme Bilgileri" + Environment.NewLine + "Müşteri Temsilcisi: Ticari Müşteri Temsilcisi 2" + Environment.NewLine + "Müşteri Numarası: " + MusteriNo + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Hata: Bu numaraya ait bir müşteri bulunamadı!!!");
            }

            txtMusteriNoGir.Clear();
        }
    }
}
