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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        OtoparkDBContext db = new OtoparkDBContext();

        private void parkyeriaraTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region ParkYeriAra
            var liste = (from x in db.TBLSatis
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
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.Plaka.Contains(parkyeriaraTxt.Text)).ToList();
            dataGridView1.DataSource = liste;

            tutarLbl.Text = "Toplam Tutar=" + db.TBLSatis.Sum(x => x.Tutar);
            kayıtLbl.Text = "Toplam" + db.TBLSatis.Count() + "kayıt listelendi";
            ortalamaLbl.Text = "ortalama tutar=" + db.TBLSatis.Average(x => x.Tutar);
            maxLbl.Text = "En yüksek tutar=" + db.TBLSatis.Max(x => x.Tutar);
            minLbl.Text = "En düşük tutar=" + db.TBLSatis.Min(x => x.Tutar);

            #endregion
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            TumKayitlar();
        }

        private void TumKayitlar()
        {
            #region KayitGoster
            var liste = (from x in db.TBLSatis
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
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).ToList();
            dataGridView1.DataSource = liste;
            tutarLbl.Text = "Toplam Tutar=" + db.TBLSatis.Sum(x => x.Tutar);
            kayıtLbl.Text = "Toplam" + db.TBLSatis.Count() + "kayıt listelendi";
            ortalamaLbl.Text = "ortalama tutar=" + db.TBLSatis.Average(x => x.Tutar);
            maxLbl.Text = "En yüksek tutar=" + db.TBLSatis.Max(x => x.Tutar);
            minLbl.Text = "En düşük tutar=" + db.TBLSatis.Min(x => x.Tutar);

            #endregion
        }

        private void IDaratxt_TextChanged(object sender, EventArgs e)
        {
            #region IDara
            var liste = (from x in db.TBLSatis
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
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.ID.ToString() == IDaratxt.Text).ToList();
            dataGridView1.DataSource = liste;
            if (IDaratxt.Text == "")
            {
                TumKayitlar();
            }

            #endregion
        }

        private void musteriidaraTxt_TextChanged(object sender, EventArgs e)
        {
            #region MusteriIDAra
            var liste = (from x in db.TBLSatis
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
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.MusteriID.ToString() == musteriidaraTxt.Text).ToList();
            dataGridView1.DataSource = liste;
            if (musteriidaraTxt.Text == "")
            {
                TumKayitlar();
            }

            #endregion
        }

        private void adsoyadaraTxt_TextChanged(object sender, EventArgs e)
        {
            #region AdSoyadAra
            var liste = (from x in db.TBLSatis
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
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.AdiSoyadi.Contains(adsoyadaraTxt.Text)).ToList();
            dataGridView1.DataSource = liste;

            tutarLbl.Text = "Toplam Tutar=" + db.TBLSatis.Sum(x => x.Tutar);
            kayıtLbl.Text = "Toplam" + db.TBLSatis.Count() + "kayıt listelendi";
            ortalamaLbl.Text = "ortalama tutar=" + db.TBLSatis.Average(x => x.Tutar);
            maxLbl.Text = "En yüksek tutar=" + db.TBLSatis.Max(x => x.Tutar);
            minLbl.Text = "En düşük tutar=" + db.TBLSatis.Min(x => x.Tutar);


            #endregion
        }

        private void plakaaraCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region PlakaAra
            var liste = (from x in db.TBLSatis
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
                             y.MarkaAdi,
                             z.seri,
                             w.ParkYerleri,
                             x.Plaka,
                             x.Yil,
                             x.Renk,
                             x.Aciklama,
                             x.saatUcreti,
                             x.Sure,
                             x.Tutar,
                             x.GirisTarihi,
                             x.CikisTarihi
                         }).Where(x => x.Plaka.Contains(plakaaraCb.Text)).ToList();
            dataGridView1.DataSource = liste;

            tutarLbl.Text = "Toplam Tutar=" + db.TBLSatis.Sum(x => x.Tutar);
            kayıtLbl.Text = "Toplam" + db.TBLSatis.Count() + "kayıt listelendi";
            ortalamaLbl.Text = "ortalama tutar=" + db.TBLSatis.Average(x => x.Tutar);
            maxLbl.Text = "En yüksek tutar=" + db.TBLSatis.Max(x => x.Tutar);
            minLbl.Text = "En düşük tutar=" + db.TBLSatis.Min(x => x.Tutar);
            #endregion
        }
    }
}
