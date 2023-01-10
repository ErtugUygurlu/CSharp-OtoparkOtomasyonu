namespace otoparkOtomasyonu
{
    partial class anaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaSayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otoparkGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçOtoparkÇıkışıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaTool = new System.Windows.Forms.ToolStripMenuItem();
            this.seriTool = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otoparkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.satisBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.seriBtn = new System.Windows.Forms.Button();
            this.markaBtn = new System.Windows.Forms.Button();
            this.otoparkyerleriBtn = new System.Windows.Forms.Button();
            this.aracotoparkcıkısıBtn = new System.Windows.Forms.Button();
            this.aracotoparkgirisiBtn = new System.Windows.Forms.Button();
            this.musterilisteleBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçlarToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.otoparkToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.saatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otoparkGirişiToolStripMenuItem,
            this.araçOtoparkÇıkışıToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.araçlarToolStripMenuItem.Text = "Araç İşlemleri";
            // 
            // otoparkGirişiToolStripMenuItem
            // 
            this.otoparkGirişiToolStripMenuItem.Name = "otoparkGirişiToolStripMenuItem";
            this.otoparkGirişiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otoparkGirişiToolStripMenuItem.Text = "Araç Otopark Girişi";
            this.otoparkGirişiToolStripMenuItem.Click += new System.EventHandler(this.otoparkGirişiToolStripMenuItem_Click);
            // 
            // araçOtoparkÇıkışıToolStripMenuItem
            // 
            this.araçOtoparkÇıkışıToolStripMenuItem.Name = "araçOtoparkÇıkışıToolStripMenuItem";
            this.araçOtoparkÇıkışıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.araçOtoparkÇıkışıToolStripMenuItem.Text = "Araç Otopark Çıkışı";
            this.araçOtoparkÇıkışıToolStripMenuItem.Click += new System.EventHandler(this.araçOtoparkÇıkışıToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaTool,
            this.seriTool});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // markaTool
            // 
            this.markaTool.Name = "markaTool";
            this.markaTool.Size = new System.Drawing.Size(107, 22);
            this.markaTool.Text = "Marka";
            this.markaTool.Click += new System.EventHandler(this.markaTool_Click);
            // 
            // seriTool
            // 
            this.seriTool.Name = "seriTool";
            this.seriTool.Size = new System.Drawing.Size(107, 22);
            this.seriTool.Text = "Seri";
            this.seriTool.Click += new System.EventHandler(this.seriTool_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.satışToolStripMenuItem.Text = "Satış";
            this.satışToolStripMenuItem.Click += new System.EventHandler(this.satışToolStripMenuItem_Click);
            // 
            // otoparkToolStripMenuItem
            // 
            this.otoparkToolStripMenuItem.Name = "otoparkToolStripMenuItem";
            this.otoparkToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.otoparkToolStripMenuItem.Text = "Otopark";
            this.otoparkToolStripMenuItem.Click += new System.EventHandler(this.otoparkToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // saatToolStripMenuItem
            // 
            this.saatToolStripMenuItem.Name = "saatToolStripMenuItem";
            this.saatToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.saatToolStripMenuItem.Text = "Saat";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.satisBtn);
            this.panel1.Controls.Add(this.seriBtn);
            this.panel1.Controls.Add(this.markaBtn);
            this.panel1.Controls.Add(this.otoparkyerleriBtn);
            this.panel1.Controls.Add(this.aracotoparkcıkısıBtn);
            this.panel1.Controls.Add(this.aracotoparkgirisiBtn);
            this.panel1.Controls.Add(this.musterilisteleBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 93);
            this.panel1.TabIndex = 1;
            // 
            // satisBtn
            // 
            this.satisBtn.FlatAppearance.BorderSize = 0;
            this.satisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.satisBtn.ImageKey = "Custom-Icon-Design-Pretty-Office-11-Sale.ico";
            this.satisBtn.ImageList = this.ımageList1;
            this.satisBtn.Location = new System.Drawing.Point(718, 14);
            this.satisBtn.Name = "satisBtn";
            this.satisBtn.Size = new System.Drawing.Size(152, 64);
            this.satisBtn.TabIndex = 2;
            this.satisBtn.Text = "Satış";
            this.satisBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.satisBtn.UseVisualStyleBackColor = true;
            this.satisBtn.Click += new System.EventHandler(this.satisBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Aha-Soft-Software-Reports.ico");
            this.ımageList1.Images.SetKeyName(1, "Iconshock-Real-Vista-Business-Brand.ico");
            this.ımageList1.Images.SetKeyName(2, "Custom-Icon-Design-Pretty-Office-11-Sale.ico");
            this.ımageList1.Images.SetKeyName(3, "Icons8-Windows-8-Household-Garage.ico");
            this.ımageList1.Images.SetKeyName(4, "Yohproject-Cute-Cancel.ico");
            this.ımageList1.Images.SetKeyName(5, "Custom-Icon-Design-Flatastic-9-Login (1).ico");
            this.ımageList1.Images.SetKeyName(6, "Itzikgur-My-Seven-Travel-BMV (1).ico");
            this.ımageList1.Images.SetKeyName(7, "Itzikgur-My-Seven-Travel-BMV.ico");
            this.ımageList1.Images.SetKeyName(8, "Webalys-Kameleon.pics-Checklist.ico");
            this.ımageList1.Images.SetKeyName(9, "Oxygen-Icons.org-Oxygen-Actions-list-add-user.ico");
            // 
            // seriBtn
            // 
            this.seriBtn.FlatAppearance.BorderSize = 0;
            this.seriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seriBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.seriBtn.ImageKey = "Aha-Soft-Software-Reports.ico";
            this.seriBtn.ImageList = this.ımageList1;
            this.seriBtn.Location = new System.Drawing.Point(1064, 14);
            this.seriBtn.Name = "seriBtn";
            this.seriBtn.Size = new System.Drawing.Size(152, 64);
            this.seriBtn.TabIndex = 2;
            this.seriBtn.Text = "Seri";
            this.seriBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.seriBtn.UseVisualStyleBackColor = true;
            this.seriBtn.Click += new System.EventHandler(this.seriBtn_Click);
            // 
            // markaBtn
            // 
            this.markaBtn.FlatAppearance.BorderSize = 0;
            this.markaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.markaBtn.ImageKey = "Iconshock-Real-Vista-Business-Brand.ico";
            this.markaBtn.ImageList = this.ımageList1;
            this.markaBtn.Location = new System.Drawing.Point(891, 14);
            this.markaBtn.Name = "markaBtn";
            this.markaBtn.Size = new System.Drawing.Size(152, 64);
            this.markaBtn.TabIndex = 2;
            this.markaBtn.Text = "Marka";
            this.markaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.markaBtn.UseVisualStyleBackColor = true;
            this.markaBtn.Click += new System.EventHandler(this.markaBtn_Click);
            // 
            // otoparkyerleriBtn
            // 
            this.otoparkyerleriBtn.FlatAppearance.BorderSize = 0;
            this.otoparkyerleriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otoparkyerleriBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.otoparkyerleriBtn.ImageKey = "Icons8-Windows-8-Household-Garage.ico";
            this.otoparkyerleriBtn.ImageList = this.ımageList1;
            this.otoparkyerleriBtn.Location = new System.Drawing.Point(545, 14);
            this.otoparkyerleriBtn.Name = "otoparkyerleriBtn";
            this.otoparkyerleriBtn.Size = new System.Drawing.Size(152, 64);
            this.otoparkyerleriBtn.TabIndex = 2;
            this.otoparkyerleriBtn.Text = "Otopark Yerleri";
            this.otoparkyerleriBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.otoparkyerleriBtn.UseVisualStyleBackColor = true;
            this.otoparkyerleriBtn.Click += new System.EventHandler(this.otoparkyerleriBtn_Click);
            // 
            // aracotoparkcıkısıBtn
            // 
            this.aracotoparkcıkısıBtn.FlatAppearance.BorderSize = 0;
            this.aracotoparkcıkısıBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aracotoparkcıkısıBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aracotoparkcıkısıBtn.ImageKey = "Yohproject-Cute-Cancel.ico";
            this.aracotoparkcıkısıBtn.ImageList = this.ımageList1;
            this.aracotoparkcıkısıBtn.Location = new System.Drawing.Point(372, 14);
            this.aracotoparkcıkısıBtn.Name = "aracotoparkcıkısıBtn";
            this.aracotoparkcıkısıBtn.Size = new System.Drawing.Size(152, 64);
            this.aracotoparkcıkısıBtn.TabIndex = 2;
            this.aracotoparkcıkısıBtn.Text = "Araç Otopark Çıkışı";
            this.aracotoparkcıkısıBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aracotoparkcıkısıBtn.UseVisualStyleBackColor = true;
            this.aracotoparkcıkısıBtn.Click += new System.EventHandler(this.aracotoparkcıkısıBtn_Click);
            // 
            // aracotoparkgirisiBtn
            // 
            this.aracotoparkgirisiBtn.FlatAppearance.BorderSize = 0;
            this.aracotoparkgirisiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aracotoparkgirisiBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aracotoparkgirisiBtn.ImageKey = "Itzikgur-My-Seven-Travel-BMV.ico";
            this.aracotoparkgirisiBtn.ImageList = this.ımageList1;
            this.aracotoparkgirisiBtn.Location = new System.Drawing.Point(199, 14);
            this.aracotoparkgirisiBtn.Name = "aracotoparkgirisiBtn";
            this.aracotoparkgirisiBtn.Size = new System.Drawing.Size(152, 64);
            this.aracotoparkgirisiBtn.TabIndex = 2;
            this.aracotoparkgirisiBtn.Text = "Araç Otopark Girişi";
            this.aracotoparkgirisiBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aracotoparkgirisiBtn.UseVisualStyleBackColor = true;
            this.aracotoparkgirisiBtn.Click += new System.EventHandler(this.aracotoparkgirisiBtn_Click);
            // 
            // musterilisteleBtn
            // 
            this.musterilisteleBtn.FlatAppearance.BorderSize = 0;
            this.musterilisteleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musterilisteleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.musterilisteleBtn.ImageKey = "Webalys-Kameleon.pics-Checklist.ico";
            this.musterilisteleBtn.ImageList = this.ımageList1;
            this.musterilisteleBtn.Location = new System.Drawing.Point(26, 14);
            this.musterilisteleBtn.Name = "musterilisteleBtn";
            this.musterilisteleBtn.Size = new System.Drawing.Size(152, 64);
            this.musterilisteleBtn.TabIndex = 2;
            this.musterilisteleBtn.Text = "Müşteri Ekle ve Listele";
            this.musterilisteleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musterilisteleBtn.UseVisualStyleBackColor = true;
            this.musterilisteleBtn.Click += new System.EventHandler(this.musterilisteleBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1245, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 647);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "anaSayfa";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoparkGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçOtoparkÇıkışıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaTool;
        private System.Windows.Forms.ToolStripMenuItem seriTool;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoparkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button satisBtn;
        private System.Windows.Forms.Button seriBtn;
        private System.Windows.Forms.Button markaBtn;
        private System.Windows.Forms.Button otoparkyerleriBtn;
        private System.Windows.Forms.Button aracotoparkcıkısıBtn;
        private System.Windows.Forms.Button aracotoparkgirisiBtn;
        private System.Windows.Forms.Button musterilisteleBtn;
        private System.Windows.Forms.ToolStripMenuItem saatToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

