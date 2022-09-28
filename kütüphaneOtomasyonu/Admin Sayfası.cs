using kütüphaneOtomasyonu.Model;
using kütüphaneOtomasyonu.Resources.Model;
using System;
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
    public partial class Admin_Sayfası : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarım;

        bool sidebarExpand;


        public Admin_Sayfası(List<Kisi> kisilerim1)
        {
            InitializeComponent();
            this.kisilerim = kisilerim1;
        }

        //

        public void textleriBoşalt()
        {
            txt_id.Text = string.Empty;
            txt_isim.Text = string.Empty;
            txt_soyisim.Text = string.Empty;
            txt_kayıtTarihi.Text = string.Empty;
            txt_kullanıcıAdı.Text = string.Empty;
            txt_sifre.Text = string.Empty;
            txt_yetki.Text = string.Empty;
        } // TextBox nesnesindeki textleri temizler.

        public void textleriDoldur()
        {
            txt_id.Text = datagrid_kisiler.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = datagrid_kisiler.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = datagrid_kisiler.CurrentRow.Cells[2].Value.ToString();
            txt_kayıtTarihi.Text = datagrid_kisiler.CurrentRow.Cells[3].Value.ToString();
            txt_kullanıcıAdı.Text = datagrid_kisiler.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = datagrid_kisiler.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = datagrid_kisiler.CurrentRow.Cells[6].Value.ToString();
        } // TextBox nesnesindeki textleri DataGrid nesnesinden çekerek doldurur.

        //


        //

        private void datagrid_kisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();
        } //DataGrid nesnesinin seçili Row'unu TextBox nesnelerine yazdırır.

        //


        //

        private void Admin_Sayfası_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
                datagrid_kisiler.Rows.Add(kisi.getID(), kisi.getİsim(), kisi.getSoyİsim(), kisi.getKayıtTarihi(), kisi.getKullanıcıAdı(), kisi.getSifre(), kisi.getYetki());


                group_kitapİslem.Visible = false;
            }
        } //Admin sayfası yüklenince önceden tanımlanmış kişileri DataGrid nesnesine doldurur.

        //

        //

        private void btn_çıkış_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Uygulamayı kapatmak için tuş.

        //


        //

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            DateTime kayıtTarihi = DateTime.Parse(txt_kayıtTarihi.Text);
            string kullanıcıAdı = txt_kullanıcıAdı.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            datagrid_kisiler.Rows.Add(id, isim, soyisim, kayıtTarihi, kullanıcıAdı, sifre, yetki);

            textleriBoşalt();
        } // DataGrid nesnesine TextBox nesnesinden verileri çeker.

        //


        //

        private void btn_sil_Click(object sender, EventArgs e)
        {
            datagrid_kisiler.Rows.Remove(datagrid_kisiler.CurrentRow);

            textleriBoşalt();
        } // DataGrid nesnesinin seçili Row'unu siler.

        //
       

        //

        private void btn_güncelle_Click(object sender, EventArgs e)
        {   
            int id = Convert.ToInt32(txt_id.Text);
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            DateTime kayıtTarihi = DateTime.Parse(txt_kayıtTarihi.Text);
            string kullanıcıAdı = txt_kullanıcıAdı.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            datagrid_kisiler.Rows.Remove(datagrid_kisiler.CurrentRow);   
            datagrid_kisiler.Rows.Add(id, isim, soyisim, kayıtTarihi, kullanıcıAdı, sifre, yetki);

            textleriBoşalt();
        }  // TextBox'daki güncellemeleri Datagrid nesnesine aktarır.

        //

            
        //

        private void sidebar_timer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar_admin.Width -= 10;

                if (sidebar_admin.Width == sidebar_admin.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebar_timer.Stop();
                }
            }
            else
            {
                sidebar_admin.Width += 10;
                if (sidebar_admin.Width == sidebar_admin.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebar_timer.Stop();
                }
            }

        } 
        //


        //

        private void btn_menuAdmin_Click(object sender, EventArgs e)
        {
            sidebar_timer.Start();
        } // SideBar nesnesinin açılmasını tetikler.

        //


        //

        private void btn_kitapİslem_Click(object sender, EventArgs e)
        {
            group_kitapİslem.Visible = true;
            datagrid_kisiler.Visible = false;
            datagrid_kitap.Visible = true;
        }

        private void btn_uyeİslem_Click(object sender, EventArgs e)
        {
            group_kitapİslem.Visible = false;
            datagrid_kisiler.Visible = true;
            datagrid_kitap.Visible = false;
        }
    }
}
