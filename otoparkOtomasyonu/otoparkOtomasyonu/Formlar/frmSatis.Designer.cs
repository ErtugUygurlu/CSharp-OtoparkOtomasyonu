namespace otoparkOtomasyonu.Formlar
{
    partial class frmSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.parkyeriaraTxt = new System.Windows.Forms.ComboBox();
            this.plakaaraCb = new System.Windows.Forms.ComboBox();
            this.adsoyadaraTxt = new System.Windows.Forms.TextBox();
            this.musteriidaraTxt = new System.Windows.Forms.TextBox();
            this.IDaratxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tutarLbl = new System.Windows.Forms.Label();
            this.kayıtLbl = new System.Windows.Forms.Label();
            this.ortalamaLbl = new System.Windows.Forms.Label();
            this.maxLbl = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 377);
            this.dataGridView1.TabIndex = 0;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // parkyeriaraTxt
            // 
            this.parkyeriaraTxt.FormattingEnabled = true;
            this.parkyeriaraTxt.Location = new System.Drawing.Point(674, 33);
            this.parkyeriaraTxt.Name = "parkyeriaraTxt";
            this.parkyeriaraTxt.Size = new System.Drawing.Size(121, 21);
            this.parkyeriaraTxt.TabIndex = 11;
            this.parkyeriaraTxt.SelectedIndexChanged += new System.EventHandler(this.parkyeriaraTxt_SelectedIndexChanged);
            // 
            // plakaaraCb
            // 
            this.plakaaraCb.FormattingEnabled = true;
            this.plakaaraCb.Location = new System.Drawing.Point(495, 33);
            this.plakaaraCb.Name = "plakaaraCb";
            this.plakaaraCb.Size = new System.Drawing.Size(121, 21);
            this.plakaaraCb.TabIndex = 12;
            this.plakaaraCb.SelectedIndexChanged += new System.EventHandler(this.plakaaraCb_SelectedIndexChanged);
            // 
            // adsoyadaraTxt
            // 
            this.adsoyadaraTxt.Location = new System.Drawing.Point(337, 34);
            this.adsoyadaraTxt.Name = "adsoyadaraTxt";
            this.adsoyadaraTxt.Size = new System.Drawing.Size(100, 20);
            this.adsoyadaraTxt.TabIndex = 8;
            this.adsoyadaraTxt.TextChanged += new System.EventHandler(this.adsoyadaraTxt_TextChanged);
            // 
            // musteriidaraTxt
            // 
            this.musteriidaraTxt.Location = new System.Drawing.Point(179, 34);
            this.musteriidaraTxt.Name = "musteriidaraTxt";
            this.musteriidaraTxt.Size = new System.Drawing.Size(100, 20);
            this.musteriidaraTxt.TabIndex = 9;
            this.musteriidaraTxt.TextChanged += new System.EventHandler(this.musteriidaraTxt_TextChanged);
            // 
            // IDaratxt
            // 
            this.IDaratxt.Location = new System.Drawing.Point(21, 34);
            this.IDaratxt.Name = "IDaratxt";
            this.IDaratxt.Size = new System.Drawing.Size(100, 20);
            this.IDaratxt.TabIndex = 10;
            this.IDaratxt.TextChanged += new System.EventHandler(this.IDaratxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Park Yeri Ara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plaka Ara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ad Soyad Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Müşteri ID Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Ara";
            // 
            // tutarLbl
            // 
            this.tutarLbl.AutoSize = true;
            this.tutarLbl.Location = new System.Drawing.Point(57, 494);
            this.tutarLbl.Name = "tutarLbl";
            this.tutarLbl.Size = new System.Drawing.Size(35, 13);
            this.tutarLbl.TabIndex = 13;
            this.tutarLbl.Text = "label6";
            // 
            // kayıtLbl
            // 
            this.kayıtLbl.AutoSize = true;
            this.kayıtLbl.Location = new System.Drawing.Point(57, 538);
            this.kayıtLbl.Name = "kayıtLbl";
            this.kayıtLbl.Size = new System.Drawing.Size(35, 13);
            this.kayıtLbl.TabIndex = 13;
            this.kayıtLbl.Text = "label6";
            // 
            // ortalamaLbl
            // 
            this.ortalamaLbl.AutoSize = true;
            this.ortalamaLbl.Location = new System.Drawing.Point(57, 587);
            this.ortalamaLbl.Name = "ortalamaLbl";
            this.ortalamaLbl.Size = new System.Drawing.Size(35, 13);
            this.ortalamaLbl.TabIndex = 13;
            this.ortalamaLbl.Text = "label6";
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.Location = new System.Drawing.Point(513, 494);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(35, 13);
            this.maxLbl.TabIndex = 13;
            this.maxLbl.Text = "label6";
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.Location = new System.Drawing.Point(513, 538);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(35, 13);
            this.minLbl.TabIndex = 13;
            this.minLbl.Text = "label6";
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 654);
            this.Controls.Add(this.ortalamaLbl);
            this.Controls.Add(this.minLbl);
            this.Controls.Add(this.kayıtLbl);
            this.Controls.Add(this.maxLbl);
            this.Controls.Add(this.tutarLbl);
            this.Controls.Add(this.parkyeriaraTxt);
            this.Controls.Add(this.plakaaraCb);
            this.Controls.Add(this.adsoyadaraTxt);
            this.Controls.Add(this.musteriidaraTxt);
            this.Controls.Add(this.IDaratxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox parkyeriaraTxt;
        private System.Windows.Forms.ComboBox plakaaraCb;
        private System.Windows.Forms.TextBox adsoyadaraTxt;
        private System.Windows.Forms.TextBox musteriidaraTxt;
        private System.Windows.Forms.TextBox IDaratxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tutarLbl;
        private System.Windows.Forms.Label kayıtLbl;
        private System.Windows.Forms.Label ortalamaLbl;
        private System.Windows.Forms.Label maxLbl;
        private System.Windows.Forms.Label minLbl;
    }
}