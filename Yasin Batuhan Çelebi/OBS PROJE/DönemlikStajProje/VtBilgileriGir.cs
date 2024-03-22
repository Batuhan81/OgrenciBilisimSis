using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace DönemlikStajProje.Data
{
	public partial class VtBilgileriGir : Form
	{
		public VtBilgileriGir()
		{
			InitializeComponent();
		}

		VeritabaniBilgileri vt = new VeritabaniBilgileri();
		Data.Context c = new Data.Context();

		// VtBilgileriGir formunda
		private void button1_Click(object sender, EventArgs e)
		{
			if (TumTextBoxlarDoluMu(groupBox1))
			{
				// Kullanıcı tarafından girilen bağlantı bilgilerini al
				vt.DatabaseAdi = DbAdi.Text;
				vt.Port = Convert.ToInt32(port.Text);
				vt.VtSifre = VtSifre.Text;
				vt.UserBilgisi = UserAdi.Text;
				vt.ServerAdi = svAdi.Text;

				// Bağlantı dizesini ayarla
				//string svad, int port, string dbad,string user,string sifre
				vt.BağlantıDizesiniAyarla(svAdi.Text, Convert.ToInt32(port.Text), DbAdi.Text, UserAdi.Text, VtSifre.Text);
				c.Database.Connection.ConnectionString = vt.yeniBağlantıDizesi;//Bağlantı Dizesini yenisiyle değiştirdim

				try
				{

					if (!c.Database.Exists()) // Veritabanı yoksa
					{
						c.Database.Create(); // Yeni bir veritabanı oluştur
						MessageBox.Show("Veri Tabanı Oluşturuldu.");
					}
					else
					{
						MessageBox.Show("Girdiğiniz isimde bir veritabanı zaten mevcut.");
					}
					MessageBox.Show("Tekrar Giriş Sayfasına Yönlendirileceksiniz.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Veri Tabanı Oluşturulurken Bir Hata Oluştu. Bilgileri Doğru Girdiğinizden Emin Olunuz.\nHata Mesajı: " + ex.InnerException.Message, "Veri Tabanı Oluşturulamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Tüm Bilgileri Girmeden Bir Veri Tabanı Oluşturamazsınız.");
			}
			this.Close();
		}

		// GroupBox içindeki tüm TextBox'ların dolu olup olmadığını kontrol eden metod
		bool TumTextBoxlarDoluMu(GroupBox groupBox)
		{
			foreach (Control control in groupBox.Controls)
			{
				if (control is TextBox)
				{
					TextBox textBox = (TextBox)control;
					if (string.IsNullOrWhiteSpace(textBox.Text))
					{
						return false; // TextBox'ın içeriği boş veya sadece boşluk karakterlerinden oluşuyorsa false döndür
					}
				}
			}
			return true; // Tüm TextBox'lar dolu ise true döndür
		}
	}
}
