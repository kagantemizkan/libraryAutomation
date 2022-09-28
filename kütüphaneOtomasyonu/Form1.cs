using kütüphaneOtomasyonu.Model;
using kütüphaneOtomasyonu.Resources.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneOtomasyonu
{
    public partial class ktpn_giris : Form
    {

        List<Kisi> kisilerim = new List<Kisi>();

        List<Kitap> kitaplarım = new List<Kitap>();

        public ktpn_giris()
        {
            InitializeComponent();
        }

        private void ktpn_giris_Load(object sender, EventArgs e)
        {
            guna2Button1.SendToBack();
            pnl_kayıt.Visible = false;

            kisilerim.Add(new Kisi(1, "Kağan", "Temizkan", DateTime.Now, "RiFLeX", "123456789", "Admin"));
            kisilerim.Add(new Kisi(2, "Mustafa", "Temizkan", DateTime.Now, "Künefeci", "123456789", "Üye"));
            kisilerim.Add(new Kisi(3, "Murat Efe", "Temizkan", DateTime.Now, "Son Konsolcu", "123456789", "Üye"));
            kisilerim.Add(new Kisi(4, "Yıldız", "Temizkan", DateTime.Now, "Ultra Anne", "123456789", "Üye"));
        }

        private void btn_login_Click(object sender, EventArgs e)
        { 
            int id = Convert.ToInt32(txt_id.Text);
            string sifre = txt_sifre.Text;

            bool kontrol = false;

            foreach (Kisi kisi in kisilerim)
            {
                if (id == kisi.getID() && sifre == kisi.getSifre() && kisi.getYetki() == "Admin")
                {
                    // ADMİN SAYFASINA YÖNLENDİR

                    Admin_Sayfası admin_Sayfası = new Admin_Sayfası(kisilerim);

                    this.Hide();
                    admin_Sayfası.Show();
                    kontrol = true;
                    break;



                }
                else if (id == kisi.getID() && sifre == kisi.getSifre() && kisi.getYetki() == "Üye")
                {
                    //ÜYE SAYFASINA YÖNLENDİR

                    Üye_Sayfası üyeSayfası = new Üye_Sayfası();

                    this.Hide();
                    üyeSayfası.Show();
                    kontrol = true;
                    break;

                }
            }

            if (kontrol == false)
            {
                MessageBox.Show("Girdiğiniz Bilgileri Kontrol Ediniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_girisSayfasınaGec_Click(object sender, EventArgs e)
        {
            pnl_kayıt.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnl_kayıt.Visible = true;
        }

        private void btn_kayıtOl_Click(object sender, EventArgs e)
        {
            string isimSoyisim = txt_adSoyadKayıt.Text;
            string sifre = txt_sifreKayıt.Text;
            DateTime kayıtTarihi = DateTime.Now;
            string kullanıcıAdı = txt_adSoyadKayıt.Text;
            string yetki = "Üye";
            Random id = new Random();
            int rand_id = id.Next(0, 200);

   

            string[] adSoyadAyırma = isimSoyisim.Split(' ');

            string isim = adSoyadAyırma[0];
            string soyisim = adSoyadAyırma[1];


            kisilerim.Add(new Kisi(rand_id, isim, soyisim, kayıtTarihi, kullanıcıAdı, sifre, yetki));
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Oluşmuştur." + "\n" + "ID'niz " + rand_id + "'dir.", "Üye Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            pnl_kayıt.Visible = false;
        }
    }
}
