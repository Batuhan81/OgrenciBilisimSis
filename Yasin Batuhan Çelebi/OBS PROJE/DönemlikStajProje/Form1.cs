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
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace DönemlikStajProje
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			timer1.Stop();
			timer2.Stop();
			this.Hide();
			Giriş git = new Giriş();
			git.ShowDialog();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			VeritabaniBilgileri vt = new VeritabaniBilgileri();
			Context c = new Context();
			if (!c.Database.Exists())//Vt daha önce oluşturulmadıysa oluşturur
			{
				timer1.Stop();
				timer2.Stop();
				MessageBox.Show("Bu Proje İçin Bir Veritabanın Oluşturulması Gerekiyor Sizi İlgili Sayfaya Yönlendiriyoruz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				VtBilgileriGir git = new VtBilgileriGir();
				git.ShowDialog();
				timer1.Start();
				timer2.Start();
			}
		}
	}
}
