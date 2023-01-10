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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otoparkOtomasyonu.Formlar
{
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        OtoparkDBContext db = new OtoparkDBContext();
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }

        void Temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
            }
            pictureBox1.ImageLocation = "";
            tarihDtp.Value = DateTime.Now;
        }
        private void IDTxt_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in db.TBLMusteri
                      where x.ID.ToString() == IDTxt.Text
                      select x;
            foreach (var item in ara)
            {
                adisoyadiTxt.Text = item.AdiSoyadi;
                telefonTxt.Text = item.Telefon;
                adresTxt.Text = item.Adres;
                emailTxt.Text = item.Email;
                pictureBox1.ImageLocation = item.Resim;
                tarihDtp.Value = item.Tarih;
            }
            if (IDTxt.Text == "")
            {
                Temizle();
            }
        }

        private void SecBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            var ekle = new Musteri();
            ekle.AdiSoyadi = adisoyadiTxt.Text;
            ekle.Telefon = telefonTxt.Text;
            ekle.Adres = adresTxt.Text;
            ekle.Email = emailTxt.Text;
            ekle.Resim = pictureBox1.ImageLocation;
            ekle.Tarih = tarihDtp.Value;
            db.TBLMusteri.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();

        }

        private void SilBtn_Click(object sender, EventArgs e) 
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var sil = db.TBLMusteri.FirstOrDefault(x => x.ID == id);
            db.TBLMusteri.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }

        private void GüncelleBtn_Click(object sender, EventArgs e) 
        {
            int id = int.Parse(IDTxt.Text);
            var guncelle = db.TBLMusteri.FirstOrDefault(x => x.ID == id);
            guncelle.AdiSoyadi = adisoyadiTxt.Text;
            guncelle.Telefon = telefonTxt.Text;
            guncelle.Adres = adresTxt.Text;
            guncelle.Email = emailTxt.Text;
            guncelle.Resim = pictureBox1.ImageLocation;
            guncelle.Tarih = tarihDtp.Value;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            dataGridView1.DataSource = db.TBLMusteri.ToList();
        }
      
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            adisoyadiTxt.Text = row.Cells["AdiSoyadi"].Value.ToString();
            telefonTxt.Text = row.Cells["Telefon"].Value.ToString();
            adresTxt.Text = row.Cells["Adres"].Value.ToString();
            emailTxt.Text = row.Cells["Email"].Value.ToString();
            pictureBox1.ImageLocation = row.Cells["Resim"].Value.ToString();
        }
    }
}
