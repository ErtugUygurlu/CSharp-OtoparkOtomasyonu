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
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }

        OtoparkDBContext db = new OtoparkDBContext();

        private void frmSeri_Load(object sender, EventArgs e)
        {
            Listele();
            var comboliste = db.TBLMarka.ToList();
            MarkaCb.DataSource = comboliste;
            MarkaCb.DisplayMember = "MarkaAdi";
            MarkaCb.ValueMember = "ID";
        }

        private void Listele()
        {
            listView1.Items.Clear();
            var liste = from x in db.TBLSeri
                        join y in db.TBLMarka on
                       x.MarkaID equals y.ID
                        select new
                        {
                            x.ID,
                            y.MarkaAdi,
                            x.seri
                        };

            foreach (var item in liste)
            {
                ListViewItem viewItem = new ListViewItem(item.ID.ToString());
                viewItem.SubItems.Add(item.MarkaAdi);
                viewItem.SubItems.Add(item.seri);
                listView1.Items.Add(viewItem);
            }
        }

        void Temizle()
        {
            IDTxt.Text = "";
            SeriTxt.Text = "";
            MarkaCb.Text = "";
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            int markaid = (int)MarkaCb.SelectedValue;
            var ekle = new Seri();
            ekle.MarkaID = markaid;
            ekle.seri = SeriTxt.Text;
            db.TBLSeri.Add(ekle);
            db.SaveChanges();
            Temizle();
            Listele();
            MessageBox.Show("Araca yeni seri eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            ListViewItem SecilenID = listView1.SelectedItems[0];
            int secilenID = int.Parse(SecilenID.SubItems[0].Text);
            var sil = db.TBLSeri.FirstOrDefault(x => x.ID == secilenID);
            db.TBLSeri.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("Araç serisi silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTxt.Text);
            var guncelle = db.TBLSeri.FirstOrDefault(x => x.ID == id);
            guncelle.MarkaID = (int)MarkaCb.SelectedValue;
            guncelle.seri = SeriTxt.Text;
            db.SaveChanges();
            MessageBox.Show("Araç serisi güncellendi.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem secilen = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count > 0)
            {
                IDTxt.Text = secilen.SubItems[0].Text;
                MarkaCb.Text = secilen.SubItems[1].Text;
                SeriTxt.Text = secilen.SubItems[2].Text;
            }
        }
    }
}
