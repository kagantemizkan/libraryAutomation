using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphaneOtomasyonu.Resources.Model
{
    public class Kisi
    {
        public int id;
        public string isim;
        public string soyisim;
        public DateTime kayıtTarihi;
        public string kullanıcıAdı;
        public string sifre;
        public string yetki;

        public Kisi()
        {
                
        }

        public Kisi(int id, string isim, string soyisim, DateTime kayıtTarihi, string kullanıcıAdı, string sifre, string yetki)
        {
            this.id = id;   
            this.isim = isim;
            this.soyisim = soyisim;
            this.kayıtTarihi = kayıtTarihi;
            this.kullanıcıAdı = kullanıcıAdı;
            this.sifre = sifre;
            this.yetki = yetki;
        }

        //

        public void setID(int id)
        {
            this.id = id;
        }

        public int getID()
        {
            return this.id;
        }

        //

        public void setİsim(string isim)
        {
            this.isim = isim;
        }

        public string getİsim()
        {
            return this.isim;
        }

        //

        public void setSoyİsim(string soyisim)
        {
            this.soyisim = soyisim;
        }

        public string getSoyİsim()
        {
            return this.soyisim;
        }

        //

        public void setKayıtTarihi(DateTime kayıtTarihi)
        {
            this.kayıtTarihi = kayıtTarihi;
        }

        public DateTime getKayıtTarihi()
        {
            return this.kayıtTarihi;
        }

        //

        public void setKullanıcıAdı(string kullanıcıAdı)
        {
            this.kullanıcıAdı = kullanıcıAdı;
        }

        public string getKullanıcıAdı()
        {
            return this.kullanıcıAdı;
        }

        //

        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }

        public string getSifre()
        {
            return this.sifre;
        }

        //

        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }

        public string getYetki()
        {
            return this.yetki;
        }

        //

        public override string ToString()
        {
            return "İsim - Soyisim: " + this.isim + "" + this.soyisim;
        }
    }
}
