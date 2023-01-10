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
    public partial class frmAracOtoparkGirisi : Form
    {
        public frmAracOtoparkGirisi()
        {
            InitializeComponent();
        }

        OtoparkDBContext db = new OtoparkDBContext();

        private void frmAracOtoparkGirisi_Load(object sender, EventArgs e)
        {
            var markagetir = db.TBLMarka.ToList();
            markaCb.DataSource = markagetir;
            markaCb.DisplayMember = "MarkaAdi";
            markaCb.ValueMember = "ID";

            ParkYeriYenile();
        }

        private void ParkYeriYenile()
        {
            var parkyerigetir = db.TBLAracParkYerleri.Where(x => x.Durumu == "BOŞ").ToList();
            parkyeriCb.DataSource = parkyerigetir;
            parkyeriCb.DisplayMember = "ParkYerleri";
            parkyeriCb.ValueMember = "ID";
        }

        private void markaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var serigetir = db.TBLSeri.Where(x => x.MarkaID == (int)markaCb.SelectedValue).ToList();
                seriCb.DataSource = serigetir;
                seriCb.DisplayMember = "Seri";
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
            seriCb.DisplayMember = "Seri";
            seriCb.ValueMember = "ID";
        }

        private void musteriIDTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var MusteriGetir = db.TBLMusteri.Where(x => x.ID.ToString() == musteriIDTxt.Text).ToList();
                foreach (var item in MusteriGetir)
                {
                    adsoyadTxt.Text = item.AdiSoyadi;
                    telefonTxt.Text = item.Telefon;
                }
                if (musteriIDTxt.Text == "")
                {
                    adsoyadTxt.Text = "";
                    telefonTxt.Text = "";
                }
            }
            catch (Exception)
            {


            }

        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            var ekle = new AracParkBilgileri();
            ekle.MusteriID = int.Parse(musteriIDTxt.Text);
            ekle.AdiSoyadi = adsoyadTxt.Text;
            ekle.Telefon = telefonTxt.Text;
            ekle.MarkaID = (int)markaCb.SelectedValue;
            ekle.SeriID = (int)markaCb.SelectedValue;
            ekle.Plaka = plakaTxt.Text;
            ekle.Yil = yilTxt.Text;
            ekle.Renk = renkTxt.Text;
            ekle.ParkYeriID = (int)parkyeriCb.SelectedValue;
            ekle.Aciklama = aciklamaTxt.Text;
            ekle.GirisTarihi = DateTime.Now;
            db.TBLAracParkBilgileri.Add(ekle);
            db.SaveChanges();

            var parkyeridoldur = db.TBLAracParkYerleri.FirstOrDefault(x => x.ID == (int)parkyeriCb.SelectedValue);
            parkyeridoldur.Durumu = "DOLU";
            db.SaveChanges();
            MessageBox.Show("Kayıt işlemi başarılı.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TemizleBtn.PerformClick();
            ParkYeriYenile();
        }
    }
}
