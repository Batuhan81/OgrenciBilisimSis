using DönemlikStajProje.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DönemlikStajProje
{
	public partial class Ogrenci_Paneli : Form
	{
		private Data.Ogrenci _ogr;
		public Ogrenci_Paneli(Data.Ogrenci ogr)
		{
			InitializeComponent();
			_ogr = ogr;
		}
		private Image ResizeImage(Image image, int width, int height)
		{
			Bitmap boyutlandır = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(boyutlandır))
			{
				graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
				graphics.DrawImage(image, 0, 0, width, height);
			}
			return boyutlandır;
		}
		private void Ogrenci_Paneli_Load(object sender, EventArgs e)
		{
			int bolumId = _ogr.ogrenciBolum;
			string filePath = _ogr.OgrenciFotoYolu;
			ad.Text = _ogr.ogrenciIsim;
			var bolum = db.Bolumler.FirstOrDefault(b => b.bolumId == bolumId);
			txtbölüm.Text = bolum.bolumIsim;
			Soyad.Text = _ogr.ogrenciSoyad;
			EPosta.Text = _ogr.ogrenciEposta;
			Ogr_No.Text = _ogr.ogrenciNo.ToString();

			checkBox1.Checked = true;
			Image originalImage = Image.FromFile(filePath);

			// PictureBox'ın boyutlarını al
			int pictureBoxWidth = pictureBox1.Width;
			int pictureBoxHeight = pictureBox1.Height;

			// Resmi PictureBox'ın boyutlarına uygun olarak ölçekle
			Image boyutlandır = ResizeImage(originalImage, pictureBoxWidth, pictureBoxHeight);

			// PictureBox'a ölçeklenmiş resmi ata
			pictureBox1.Image = boyutlandır;
			ID.Text = _ogr.ogrenciId.ToString();
			timer1.Start();
			MessageBox.Show(_ogr.ogrenciIsim + " " + _ogr.ogrenciSoyad.ToUpper(), "Sisteme Tekrar Hoşgeldiniz");
		}

		private void sınavSonuçlarıToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Notlarım git = new Notlarım(_ogr.ogrenciIsim);
			git.Show();
		}

		private void okulBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OkulBİlgileri git = new OkulBİlgileri();
			git.Show();
		}
		private void Boyutlandır(OpenFileDialog fileDialog)
		{
			// Resim uzantısını ve dosya yolunu göster
			uzantı.Visible = true;
			uzantı.Text = fileDialog.FileName;
			string filePath = fileDialog.FileName;
			// Resmi dosyadan yükle
			Image originalImage = Image.FromFile(filePath);

			// PictureBox'ın boyutlarını al
			int pictureBoxWidth = pictureBox1.Width;
			int pictureBoxHeight = pictureBox1.Height;

			// Resmi PictureBox'ın boyutlarına uygun olarak ölçekle
			Image boyutlandır = ResizeImage(originalImage, pictureBoxWidth, pictureBoxHeight);

			// PictureBox'a ölçeklenmiş resmi ata
			pictureBox1.Image = boyutlandır;
		}
		Data.Context db = new Data.Context();
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "PNG Dosyaları (*.png)|*.png|JPG Dosyaları (*.jpg)|*.jpg|Tüm Dosyalar (*.png, *.jpg)|*.png;*.jpg";
			fileDialog.FilterIndex = 1;
			fileDialog.RestoreDirectory = true;//En son nerede hangi klasör açık bırakıldıysa oradan devam ediyor tekrar açılınca
			fileDialog.CheckFileExists = true;//dosyanın olup olmadığını kontrol eder.dosya eğer yoksa hata mesajı verir
			fileDialog.Title = "Dosya Seçiniz";//Açılan pencerenin adını buna çevirir.
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				// Seçilen fotoğrafı PictureBox'ta göster
				pictureBox1.Image = Image.FromFile(fileDialog.FileName);

				Boyutlandır(fileDialog);
			}
			_ogr.OgrenciFotoYolu = uzantı.Text;
			db.SaveChanges();
			uzantı.Visible = false;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Giriş git = new Giriş();
			this.Close();
			git.Show();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			indirelecekDosyaAd = "Ders Programı";
			indir(indirelecekDosyaAd);
		}


		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			indirelecekDosyaAd = "Sınav Tarihleri";
			indir(indirelecekDosyaAd);
		}


		string indirelecekDosyaAd;
		private void sınavTarihleriToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			indirelecekDosyaAd = "Sınav Tarihleri";
			indir(indirelecekDosyaAd);
		}

		public void dersProgramıToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			indirelecekDosyaAd = "Ders Programı";
			indir(indirelecekDosyaAd);
		}

		private void duyuruEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Duyuru_Listele git = new Duyuru_Listele();
			git.Show();
		}
		Kullanıcı k = new Kullanıcı();
		private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			k.Ad = ad.Text;
			k.Soyad = Soyad.Text;
			k.Yetki = "Öğrenci";
			k.Id = ID.Text;
			ŞifreDeğiştir git = new ŞifreDeğiştir(k);
			git.Show();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Stop();
			SendKeys.Send("{ESC}");
		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

			indirelecekDosyaAd = "Akademik Takvim";
			indir(indirelecekDosyaAd);
		}

		public static void indir(string İndirilecekdosya)
		{
			Data.Context db = new Data.Context();
			try
			{
				var dersProgramiDuyurular = db.Duyurular.FirstOrDefault(d => d.duyuruBaslik == İndirilecekdosya && d.duyuruBelgeYolu != null && d.duyuruAktifmi == true); // aktif durumu 1 olanları al
				if (dersProgramiDuyurular != null && dersProgramiDuyurular.duyuruAktifmi == true)
				{
					string dosyaYolu = dersProgramiDuyurular.duyuruBelgeYolu;
					SaveFileDialog saveDialog = new SaveFileDialog();
					saveDialog.FileName = Path.GetFileName(dosyaYolu); // İndirilen dosyanın adını ayarlayın
					saveDialog.Filter = "Tüm Dosyalar (*.*)|*.*"; // Tüm dosya türlerini filtreleyin

					if (saveDialog.ShowDialog() == DialogResult.OK)
					{
						// Dosyayı indirme işlemi
						File.Copy(dosyaYolu, saveDialog.FileName, true);
						MessageBox.Show("Dosya başarıyla indirildi!");
					}
				}
				else
				{
					MessageBox.Show(İndirilecekdosya+" Henüz Belli Değil Lütfen Beklemede Kalınız!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Dosya indirme sırasında bir hata oluştu: " + ex.Message);
			}
		}

		private void akademikTakvimToolStripMenuItem_Click(object sender, EventArgs e)
		{
			indirelecekDosyaAd = "Akademik Takvim";
			indir(indirelecekDosyaAd);
		}


		private void mesajlaşmaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Data.Ogrenci ogr = db.Ogrenciler.FirstOrDefault(x => x.ogrenciIsim == ad.Text);
			Mesajlaşma git = new Mesajlaşma(ogr);
			git.Show();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				linklergroup.Visible = true;
			}
			else
			{
				linklergroup.Visible = false;
			}
		}
	}
}
