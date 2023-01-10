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

namespace otoparkOtomasyonu
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }

        private void markaTool_Click(object sender, EventArgs e)
        {
            Formlar.frmmarka marka = new Formlar.frmmarka();
            marka.Show();
        }

        private void markaBtn_Click(object sender, EventArgs e)
        {
            Formlar.frmmarka marka = new Formlar.frmmarka();
            marka.Show();
        }

        private void seriBtn_Click(object sender, EventArgs e)
        {
            Formlar.frmSeri seri = new Formlar.frmSeri();
            seri.Show();
        }

        private void seriTool_Click(object sender, EventArgs e)
        {
            Formlar.frmSeri seri = new Formlar.frmSeri();
            seri.Show();
        }

        private void musterilisteleBtn_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriListele frm = new Formlar.frmMusteriListele();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e) // saat için, ayrıca 5/"araç parkyerleri" kodlardan mantık öğren
        {
            saatToolStripMenuItem.Text = DateTime.Now.ToString();
        }

        private void otoparkyerleriBtn_Click(object sender, EventArgs e)
        {
            Formlar.frmOtoparkYerleri frm = new Formlar.frmOtoparkYerleri();
            frm.Show();
        }

        private void aracotoparkgirisiBtn_Click(object sender, EventArgs e)
        {
            Formlar.frmAracOtoparkGirisi frm = new Formlar.frmAracOtoparkGirisi();
            frm.Show();
        }

        private void aracotoparkcıkısıBtn_Click(object sender, EventArgs e)
        {
            Formlar.frmAracOtoparkCikisi frm = new Formlar.frmAracOtoparkCikisi();
            frm.Show();
        }

        private void satisBtn_Click(object sender, EventArgs e)
        {
            Formlar.frmSatis frm = new Formlar.frmSatis();
            frm.Show();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmSatis sat = new Formlar.frmSatis();
            sat.Show();
        }

        private void otoparkGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmAracOtoparkGirisi frm = new Formlar.frmAracOtoparkGirisi();
            frm.Show();
        }

        private void araçOtoparkÇıkışıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmAracOtoparkCikisi frm = new Formlar.frmAracOtoparkCikisi();
            frm.Show();
        }

        private void otoparkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.frmOtoparkYerleri otopark = new Formlar.frmOtoparkYerleri();
            otopark.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
