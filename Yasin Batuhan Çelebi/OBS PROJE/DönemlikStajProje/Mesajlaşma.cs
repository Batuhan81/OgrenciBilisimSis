using DönemlikStajProje.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DönemlikStajProje
{
    public partial class Mesajlaşma : Form
    {
        private Data.Ogrenci _ogr;
        public Mesajlaşma(Data.Ogrenci ogrenci)
        {
            InitializeComponent();
            _ogr = ogrenci;
        }
        Context db = new Context();
        OgrenciMesaj m = new OgrenciMesaj();
        int gönderenID;
        int alanID;
        private void button2_Click(object sender, EventArgs e)
        {
            var ogrenci = db.Ogrenciler.FirstOrDefault(x => x.ogrenciIsim == alan.Text);
            if (ogrenci != null)
            {
                if (mesaj.Text != "")
                {
					alanID = ogrenci.ogrenciId;
					m.ogrenciMesajAlici = alanID;
					m.ogrenciMesajGonderici = gönderenID;
					m.ogrenciMesajMesaj = mesaj.Text;
					m.olusturmaTarihi = DateTime.Now;
					db.ogrenciMesajlar.Add(m);
					db.SaveChanges();
					timer2.Start();
					MessageBox.Show("Mesaj Teslim Edildi");
					mesaj.Text = "";
				}
                else
                {
					timer2.Start();
					MessageBox.Show("Boş mesaj gönderemezsiniz", "Mesaj Gönderilemedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
            else
            {

                timer2.Start();
                MessageBox.Show("Lütfen Bir alıcı seçin","Mesaj Gönderilemedi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        void Ogrenciler()
        {
            // Tüm dersleri veritabanından al
            var tumDersler = db.Ogrenciler.ToList();

            // ComboBox'a ders isimlerini yükle
            foreach (var ders in tumDersler)
            {
                alan.Items.Add(ders.ogrenciIsim);
				if (_ogr.ogrenciIsim != ders.ogrenciIsim)
				{
					KisiAdları.Items.Add(ders.ogrenciIsim + " " + ders.ogrenciSoyad);
				}
			}
        }
        void GelenMesaj()
        {
			var duyurular = db.ogrenciMesajlar.ToList().Select(o => new
			{
				Gönderen_Ad = db.Ogrenciler.FirstOrDefault(og => og.ogrenciId == o.ogrenciMesajGonderici)?.ogrenciIsim,
				Mesaj = o.ogrenciMesajMesaj,
				Gönderildi = o.olusturmaTarihi,
			}).ToList();

			gridMesajlar.DataSource = duyurular;
		}

        private void Mesajlaşma_Load(object sender, EventArgs e)
        {
            GelenMesaj();
            Ogrenciler();
            gönderen.Text = _ogr.ogrenciIsim;
            gönderenID = _ogr.ogrenciId;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
			if (KisiAdları.SelectedIndex != -1)
			{
				secilenKisi = KisiAdları.SelectedItem.ToString();
			}
			else
			{
				KisiAdları.SelectedIndex = 0;
				secilenKisi = KisiAdları.SelectedItem.ToString();
			}
			KisiyeOzel();
		}

		private void KisiAdları_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (KisiAdları.SelectedIndex != -1)
			{
				secilenKisi = KisiAdları.SelectedItem.ToString();
			}
			else
			{
				KisiAdları.SelectedIndex = 0;
				secilenKisi = KisiAdları.SelectedItem.ToString();
			}
			KisiyeOzel();
		}
		string secilenKisi;
		private void KisiyeOzel()
		{
		

			var secilenKisiOgrenci = db.Ogrenciler.FirstOrDefault(og => og.ogrenciIsim + " " + og.ogrenciSoyad == secilenKisi);
			if (secilenKisiOgrenci != null)
			{
				var secilenKisiId = secilenKisiOgrenci.ogrenciId;

				var duyurular = db.ogrenciMesajlar
								.Where(m => m.ogrenciMesajGonderici == secilenKisiId || m.ogrenciMesajAlici == secilenKisiId)
								.Select(o => new
								{
									Gönderen_Ad = db.Ogrenciler.FirstOrDefault(og => og.ogrenciId == o.ogrenciMesajGonderici).ogrenciIsim,
									Mesaj = o.ogrenciMesajMesaj,
									Gönderildi = o.olusturmaTarihi,
								}).ToList();

				gridMesajlar.DataSource = duyurular;
			}
			else
			{
				MessageBox.Show("Seçilen kişi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			timer2.Stop();
			SendKeys.Send("{ESC}");
		}

		private void alan_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
