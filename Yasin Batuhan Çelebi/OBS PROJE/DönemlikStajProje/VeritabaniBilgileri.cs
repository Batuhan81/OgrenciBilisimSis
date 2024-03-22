using System;
using System.Configuration;

namespace DönemlikStajProje
{
	public class VeritabaniBilgileri
	{
		
		public string ServerAdi { get; set; }
		public string DatabaseAdi { get; set; }
		public string UserBilgisi { get; set; }
		public string VtSifre { get; set; }
		public int Port { get; set; }

		public string yeniBağlantıDizesi;
		public void BağlantıDizesiniAyarla(string svad, int port, string dbad,string user ,string sifre)
		{
			// Yeni bağlantı dizesini oluştur
			 yeniBağlantıDizesi = $"Server={svad};Port={port};Database={dbad};Uid={user};Pwd={sifre};";

			// App.config dosyasındaki connection string'i güncelle
			var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
			connectionStringsSection.ConnectionStrings["Context"].ConnectionString = yeniBağlantıDizesi;

			// Değişiklikleri kaydet ve uygula
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("connectionStrings");
		}
	}
}
