using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphaneOtomasyonu.Model
{
    internal class Kitap
    {
        public int kitapID;
        public string kitapİsmi;
        public string kitapYazar;
        public string kitapDili;
        public string yayınEvi;
        public string tür;
        public string adet;
        public string sayfaSayısı;
        public int basımYılı;

            
            public Kitap(int kitapID, string kitapİsmi, string kitapYazar, string kitapDili, string yayınEvi, string tür, string adet, string sayfaSayısı, int basımYılı)
            {
                this.kitapID = kitapID;
                this.kitapİsmi = kitapİsmi;
                this.kitapYazar = kitapYazar;
                this.kitapDili = kitapDili;
                this.yayınEvi = yayınEvi;
                this.tür = tür;
                this.adet = adet;
                this.sayfaSayısı = sayfaSayısı;
                this.basımYılı = basımYılı;
            }
            
            //
            
            public void setKitapID(int kitapID)
            {
                this.kitapID = kitapID;
            }


            public int getKitapID()
            {
                return this.kitapID;
            }

            //


            //

            public void setKitapİsmi(string kitapİsmi)
            {
                this.kitapİsmi = kitapİsmi;
            }

            public string getKitapİsmi()
            {
                return this.kitapİsmi;
            }

            //


            //

            public void setKitapYazar(string kitapYazar)
            {
                this.kitapYazar = kitapYazar;
            }

            
            public string getKitapYazar()
            {
                return this.kitapYazar;
            }

            //    


            //
            
            public void setKitapDili(string kitapDili)
            {
                this.kitapDili = kitapDili;
            }

            public string getKitapDili()
            {
                return this.kitapDili;
            }

            //    


            //
            
            public void setYayınEvi(string yayınEvi)
            {
                this.yayınEvi = yayınEvi;
            }

            public string getYayınEvi()
            {
                return this.yayınEvi;
            }

            //


            //
            public void setTür(string tür)
            {
                this.tür = tür;
            }

            public string getTür()
            {
                return this.tür;
            }
            //


            //

            public void setAdet(string adet)
            {
                this.adet = adet;
            }

            public string getAdet()
            {
                return this.adet;
            }
            
            //


            //

            public void setSayfaSayısı(string sayfaSayısı)
            {
                this.sayfaSayısı = sayfaSayısı;
            }

            public string getSayfaSayısı()
            {
                return this.sayfaSayısı;
            }

            //
        

            //
            
            public void setBasımYılı(int basımYılı)
            {
                this.basımYılı = basımYılı;
            }

            public int getBasımYılı()
            {
                return this.basımYılı;
            }

            //
    }
}
