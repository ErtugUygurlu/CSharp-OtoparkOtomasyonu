using otoparkOtomasyonu.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otoparkOtomasyonu.Formlar
{
    public partial class frmAracOtoparkCikisi : Form
    {
        public frmAracOtoparkCikisi()
        {
            InitializeComponent();
        }
        OtoparkDBContext db = new OtoparkDBContext();

        void UcretHesapla()
        {
            try
            {
                cikisLbl.Text = DateTime.Now.ToString();
                TimeSpan fark;
                fark = DateTime.Parse(cikisLbl.Text) - DateTime.Parse(girisLbl.Text);
                decimal saatucreti = 0, sure = 0, tutar = 0;
                surelbl.Text = fark.TotalHours.ToString("0.00");
                saatucreti = decimal.Parse(saatucretiCb.Text);
                sure = decimal.Parse(surelbl.Text);
                tutar = sure * saatucreti;
                ucretlbl.Text = tutar.ToString("0.00");
            }
            catch (Exception)
            {


            }
        }
        private void frmAracOtoparkCikisi_Load(object sender, EventArgs e)

        {
            saatucretiCb.SelectedIndex = 0;
            var plakagetir = db.TBLAracParkBilgileri.ToList();
            foreach (var item in plakagetir)
            {
                plakaaraCb.Items.Add(item.Plaka);
            }
            Yenile();
            var markagetir = db.TBLMarka.ToList();
            markaCb.DataSource = markagetir;
            markaCb.DisplayMember = "MarkaAdi";
            markaCb.ValueMember = "ID";
        }

        private void Yenile()
        {
            var bosparkyerleri = db.TBLAracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            parkyeriCb.DataSource = bosparkyerleri;
            parkyeriCb.DisplayMember = "ParkYerleri";
            parkyeriCb.ValueMember = "ID";
            var doluparkyerleri = db.TBLAracParkYerleri.Where(x => x.Durumu == "DOLU").ToList();

            foreach (var item in doluparkyerleri)
            {
                parkyeriaraCb.Items.Add(item.ParkYerleri);
            }
        }

        private void markaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var serigetir = db.TBLSeri.Where(x => x.MarkaID == (int)markaCb.SelectedValue).ToList();
                seriCb.DataSource = serigetir;
                seriCb.DisplayMember = "seri";
                seriCb.ValueMember = "ID";
            }
            catch (Exception)
            {


            }
        }

        private void markaCb_ValueMemberChanged(object sender, EventArgs e)
        {
            var serigetir = db.TBLSeri.Where(x => x.MarkaID == (int)markaCb.SelectedValue).ToList();
            seriCb.DataSource = serigetir;
            seriCb.DisplayMember = "seri";
            seriCb.ValueMember = "ID";
        }

        private void IDaratxt_TextChanged(object sender, EventArgs e)
        {
            if (IDaratxt.Text == "")
            {
                foreach (Control item in bilgiPnl.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            #region ID_ara
            var IDara = (from x in db.TBLAracParkBilgileri
                         join y in db.TBLMarka on
                       x.MarkaID equals y.ID
                         join z in db.TBLSeri on x.SeriID equals z.ID
                         join w in db.TBLAracParkYerleri on x.ParkYeriID equals w.ID
                         select new
                         {
                             x.ID,
                             x.MusteriID,
                             x.AdiSoyadi,
                             x.Telefon,
                             x.Plaka,
                             x.Renk,
                             x.Aciklama,
                             x.GirisTarihi,
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri
                         }).Where(ara => ara.ID.ToString() == IDaratxt.Text).ToList();

            foreach (var item in IDara)
            {
                idTxt.Text = item.ID.ToString();
                musteriidTxt.Text = item.MusteriID.ToString();
                adsoyadTxt.Text = item.AdiSoyadi;
                telefonTxt.Text = item.Telefon;
                markaCb.Text = item.MarkaAdi;
                seriCb.Text = item.seri;
                plakaTxt.Text = item.Plaka;
                renkTxt.Text = item.Renk;
                parkyeriCb.Text = item.ParkYerleri;
                aciklamaTxt.Text = item.Aciklama;
                girisLbl.Text = item.GirisTarihi.ToString();
                UcretHesapla();

            }
            #endregion
        }

        private void musteriidTxt_TextChanged(object sender, EventArgs e)
        {


            #region MusteriID_ara
            var MusteriIDara = (from x in db.TBLAracParkBilgileri
                                join y in db.TBLMarka on
                              x.MarkaID equals y.ID
                                join z in db.TBLSeri on x.SeriID equals z.ID
                                join w in db.TBLAracParkYerleri on x.ParkYeriID equals w.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdiSoyadi,
                                    x.Telefon,
                                    x.Plaka,
                                    x.Renk,
                                    x.Aciklama,
                                    x.GirisTarihi,
                                    y.MarkaAdi,
                                    z.seri,
                                    w.ParkYerleri
                                }).Where(ara => ara.MarkaAdi.ToString() == IDaratxt.Text).ToList();

            foreach (var item in MusteriIDara)
            {
                idTxt.Text = item.ID.ToString();
                musteriidTxt.Text = item.MusteriID.ToString();
                adsoyadTxt.Text = item.AdiSoyadi;
                telefonTxt.Text = item.Telefon;
                markaCb.Text = item.MarkaAdi;
                seriCb.Text = item.seri;
                plakaTxt.Text = item.Plaka;
                renkTxt.Text = item.Renk;
                parkyeriCb.Text = item.ParkYerleri;
                aciklamaTxt.Text = item.Aciklama;
                girisLbl.Text = item.GirisTarihi.ToString();
                UcretHesapla();

            }
            #endregion

        }

        private void adsoyadaraTxt_TextChanged(object sender, EventArgs e)
        {
            if (adsoyadaraTxt.Text == "")
            {
                foreach (Control item in bilgiPnl.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }


            #region Adsoyad_ara
            var AdSoyadara = (from x in db.TBLAracParkBilgileri
                              join y in db.TBLMarka on
                            x.MarkaID equals y.ID
                              join z in db.TBLSeri on x.SeriID equals z.ID
                              join w in db.TBLAracParkYerleri on x.ParkYeriID equals w.ID
                              select new
                              {
                                  x.ID,
                                  x.MusteriID,
                                  x.AdiSoyadi,
                                  x.Telefon,
                                  x.Plaka,
                                  x.Renk,
                                  x.Aciklama,
                                  x.GirisTarihi,
                                  y.MarkaAdi,
                                  z.seri,
                                  w.ParkYerleri
                              }).Where(ara => ara.AdiSoyadi.ToString() == adsoyadaraTxt.Text).ToList();

            foreach (var item in AdSoyadara)
            {
                idTxt.Text = item.ID.ToString();
                musteriidTxt.Text = item.MusteriID.ToString();
                adsoyadTxt.Text = item.AdiSoyadi;
                telefonTxt.Text = item.Telefon;
                markaCb.Text = item.MarkaAdi;
                seriCb.Text = item.seri;
                plakaTxt.Text = item.Plaka;
                renkTxt.Text = item.Renk;
                parkyeriCb.Text = item.ParkYerleri;
                aciklamaTxt.Text = item.Aciklama;
                girisLbl.Text = item.GirisTarihi.ToString();
                UcretHesapla();

            }
            #endregion
        }

        private void plakaaraCb_SelectedIndexChanged(object sender, EventArgs e)
        {

            #region Plaka_ara
            var Plakaara = (from x in db.TBLAracParkBilgileri
                            join y in db.TBLMarka on
                          x.MarkaID equals y.ID
                            join z in db.TBLSeri on x.SeriID equals z.ID
                            join w in db.TBLAracParkYerleri on x.ParkYeriID equals w.ID
                            select new
                            {
                                x.ID,
                                x.MusteriID,
                                x.AdiSoyadi,
                                x.Telefon,
                                x.Plaka,
                                x.Renk,
                                x.Aciklama,
                                x.GirisTarihi,
                                y.MarkaAdi,
                                z.seri,
                                w.ParkYerleri
                            }).Where(ara => ara.Plaka.ToString() == plakaaraCb.Text).ToList();

            foreach (var item in Plakaara)
            {
                idTxt.Text = item.ID.ToString();
                musteriidTxt.Text = item.MusteriID.ToString();
                adsoyadTxt.Text = item.AdiSoyadi;
                telefonTxt.Text = item.Telefon;
                markaCb.Text = item.MarkaAdi;
                seriCb.Text = item.seri;
                plakaTxt.Text = item.Plaka;
                renkTxt.Text = item.Renk;
                parkyeriCb.Text = item.ParkYerleri;
                aciklamaTxt.Text = item.Aciklama;
                girisLbl.Text = item.GirisTarihi.ToString();
                UcretHesapla();

            }
            #endregion
        }

        private void parkyeriaraCb_SelectedIndexChanged(object sender, EventArgs e)
        {

            #region PlakaYeri_ara
            var Plakayeriara = (from x in db.TBLAracParkBilgileri
                                join y in db.TBLMarka on
                              x.MarkaID equals y.ID
                                join z in db.TBLSeri on x.SeriID equals z.ID
                                join w in db.TBLAracParkYerleri on x.ParkYeriID equals w.ID
                                select new
                                {
                                    x.ID,
                                    x.MusteriID,
                                    x.AdiSoyadi,
                                    x.Telefon,
                                    x.Plaka,
                                    x.Renk,
                                    x.Aciklama,
                                    x.GirisTarihi,
                                    y.MarkaAdi,
                                    z.seri,
                                    w.ParkYerleri
                                }).Where(ara => ara.ParkYerleri.ToString() == parkyeriaraCb.Text).ToList();

            foreach (var item in Plakayeriara)
            {
                idTxt.Text = item.ID.ToString();
                musteriidTxt.Text = item.MusteriID.ToString();
                adsoyadTxt.Text = item.AdiSoyadi;
                telefonTxt.Text = item.Telefon;
                markaCb.Text = item.MarkaAdi;
                seriCb.Text = item.seri;
                plakaTxt.Text = item.Plaka;
                renkTxt.Text = item.Renk;
                parkyeriCb.Text = item.ParkYerleri;
                aciklamaTxt.Text = item.Aciklama;
                girisLbl.Text = item.GirisTarihi.ToString();
                UcretHesapla();

            }
            #endregion
        }

        private void plakaaraCb_TextChanged(object sender, EventArgs e)
        {
            if (plakaaraCb.Text == "")
            {
                foreach (Control item in bilgiPnl.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void parkyeriaraCb_TextChanged(object sender, EventArgs e)
        {
            if (parkyeriaraCb.Text == "")
            {
                foreach (Control item in bilgiPnl.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void parkyeriguncelleBtn_Click(object sender, EventArgs e)
        {
            var DoluParkYeriDegistir = db.TBLAracParkYerleri.FirstOrDefault(x => x.ParkYerleri == parkyeriaraCb.Text);
            DoluParkYeriDegistir.Durumu = "BOŞ";
            db.SaveChanges();
            var BosParkYeriDegistir = db.TBLAracParkYerleri.FirstOrDefault(x => x.ParkYerleri == parkyeriCb.Text);
            BosParkYeriDegistir.Durumu = "DOLU";
            db.SaveChanges();
            var aracparkyeridegistir = db.TBLAracParkBilgileri.FirstOrDefault(x => x.Plaka == plakaTxt.Text);
            aracparkyeridegistir.ParkYeriID = (int)parkyeriCb.SelectedValue;
            db.SaveChanges();
            MessageBox.Show("Araç park yeri güncellendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            parkyeriaraCb.Items.Clear();
            Yenile();
            temizleBtn.PerformClick();
            surelbl.Text = "0.00";
            ucretlbl.Text = "0.00";
            girisLbl.Text = DateTime.Now.ToString();
            cikisLbl.Text = DateTime.Now.ToString();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            #region sil
            KayıtSil();
            #endregion
            MessageBox.Show("Araç park yeri silindi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            parkyeriaraCb.Items.Clear();
            Yenile();
            temizleBtn.PerformClick();
            surelbl.Text = "0.00";
            ucretlbl.Text = "0.00";
            girisLbl.Text = DateTime.Now.ToString();
            cikisLbl.Text = DateTime.Now.ToString();
        }

        private void KayıtSil()
        {
            var sil = db.TBLAracParkBilgileri.FirstOrDefault(x => x.Plaka == plakaTxt.Text);
            db.TBLAracParkBilgileri.Remove(sil);
            db.SaveChanges();

            var aracparkyeribosalt = db.TBLAracParkYerleri.FirstOrDefault(x => x.ParkYerleri == parkyeriCb.Text);
            aracparkyeribosalt.Durumu = "BOŞ";
            db.SaveChanges();
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            foreach (Control item in aramaPnl.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in bilgiPnl.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    if (item != saatucretiCb)
                    {
                        item.Text = "";
                    }
                }
            }
            surelbl.Text = "0.00";
            ucretlbl.Text = "0.00";
            girisLbl.Text = DateTime.Now.ToString();
            cikisLbl.Text = DateTime.Now.ToString();
        }

        private void araccikisBtn_Click(object sender, EventArgs e)
        {
            #region araccikisi
            var ekle = new Satis();
            ekle.ID = int.Parse(idTxt.Text);
            ekle.MusteriID = int.Parse(musteriidTxt.Text);
            ekle.AdiSoyadi = adsoyadTxt.Text;
            ekle.Telefon = telefonTxt.Text;
            ekle.MarkaID = (int)markaCb.SelectedValue;
            ekle.SeriID = (int)seriCb.SelectedValue;
            ekle.Plaka = plakaTxt.Text;
            ekle.Yil = "Belirtilmedi.";
            ekle.Renk = renkTxt.Text;
            ekle.ParkYeriID = int.Parse(parkyeriaraCb.ValueMember);
            ekle.saatUcreti = decimal.Parse(saatucretiCb.Text);
            ekle.Sure = decimal.Parse(surelbl.Text);
            ekle.Tutar = decimal.Parse(ucretlbl.Text);
            ekle.Aciklama = aciklamaTxt.Text;
            ekle.GirisTarihi = DateTime.Parse(girisLbl.Text);
            ekle.CikisTarihi = DateTime.Parse(cikisLbl.Text);
            db.TBLSatis.Add(ekle);
            db.SaveChanges();
            KayıtSil();

            #endregion
            MessageBox.Show("Araç otopark çıkışı yapıldı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            parkyeriaraCb.Items.Clear();
            Yenile();
            temizleBtn.PerformClick();
            KayıtSil();
            surelbl.Text = "0.00";
            ucretlbl.Text = "0.00";
            girisLbl.Text = DateTime.Now.ToString();
            cikisLbl.Text = DateTime.Now.ToString();

        }

        private void saatucretiCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcretHesapla();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            var guncelle = db.TBLAracParkBilgileri.FirstOrDefault(x => x.ID.ToString() == idTxt.Text);
            guncelle.MarkaID = (int)markaCb.SelectedValue;
            guncelle.SeriID = (int)seriCb.SelectedValue;
            guncelle.Plaka = plakaTxt.Text;
            guncelle.Renk = renkTxt.Text;
            guncelle.Aciklama = aciklamaTxt.Text;
            db.SaveChanges();
            MessageBox.Show("Araç park bilgileri güncellendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Yenile();
            temizleBtn.PerformClick();
            surelbl.Text = "0.00";
            ucretlbl.Text = "0.00";
            girisLbl.Text = DateTime.Now.ToString();
            cikisLbl.Text = DateTime.Now.ToString();
        }

        private void musteriidaraTxt_TextChanged(object sender, EventArgs e)
        {
            if (musteriidaraTxt.Text == "")
            {
                foreach (Control item in bilgiPnl.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            #region MusteriID_ara
            var MusteeriIDara = (from x in db.TBLAracParkBilgileri
                                 join y in db.TBLMarka on
                               x.MarkaID equals y.ID
                                 join z in db.TBLSeri on x.SeriID equals z.ID
                                 join w in db.TBLAracParkYerleri on x.ParkYeriID equals w.ID
                                 select new
                                 {
                                     x.ID,
                                     x.MusteriID,
                                     x.AdiSoyadi,
                                     x.Telefon,
                                     x.Plaka,
                                     x.Renk,
                                     x.Aciklama,
                                     x.GirisTarihi,
                                     y.MarkaAdi,
                                     z.seri,
                                     w.ParkYerleri
                                 }).Where(ara => ara.MusteriID.ToString() == musteriidaraTxt.Text).ToList();

            foreach (var item in MusteeriIDara)
            {
                idTxt.Text = item.ID.ToString();
                musteriidTxt.Text = item.MusteriID.ToString();
                adsoyadTxt.Text = item.AdiSoyadi;
                telefonTxt.Text = item.Telefon;
                markaCb.Text = item.MarkaAdi;
                seriCb.Text = item.seri;
                plakaTxt.Text = item.Plaka;
                renkTxt.Text = item.Renk;
                parkyeriCb.Text = item.ParkYerleri;
                aciklamaTxt.Text = item.Aciklama;
                girisLbl.Text = item.GirisTarihi.ToString();
                UcretHesapla();

            }
            #endregion

        }
    }
}
