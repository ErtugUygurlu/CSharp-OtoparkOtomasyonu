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
    public partial class frmmarka : Form
    {
        public frmmarka()
        {
            InitializeComponent();
        }

        OtoparkDBContext db = new OtoparkDBContext();

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            var ekle = new Marka();
            ekle.MarkaAdi = MarkaTxt.Text;
            db.TBLMarka.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Araç markası eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }

        void Temizle()
        {
            IDTxt.Text = "";
            MarkaTxt.Text = "";
        }

        private void frmmarka_Load(object sender, EventArgs e)
        {
            MarkaListele();
        }

        private void MarkaListele()
        {
            listView1.Items.Clear();
            var markalistesi = db.TBLMarka.ToList();
            for (int i = 0; i < markalistesi.Count; i++)
            {
                ListViewItem ekle = new ListViewItem(markalistesi[i].ID.ToString());
                ekle.SubItems.Add(markalistesi[i].MarkaAdi);
                listView1.Items.Add(ekle);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count > 0)
            {
                IDTxt.Text = secilen.SubItems[0].Text;
                MarkaTxt.Text = secilen.SubItems[1].Text;
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {

            ListViewItem SecilenID = listView1.SelectedItems[0];
            int secilenID = int.Parse(SecilenID.SubItems[0].Text);
            var sil = db.TBLMarka.FirstOrDefault(x => x.ID == secilenID);
            db.TBLMarka.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Araç markası silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTxt.Text);
            var guncelle = db.TBLMarka.FirstOrDefault(x => x.ID == id);
            guncelle.MarkaAdi = MarkaTxt.Text;
            db.SaveChanges();
            MessageBox.Show("Araç markası güncellendi.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarkaListele();
            Temizle();
        }
    }
}
