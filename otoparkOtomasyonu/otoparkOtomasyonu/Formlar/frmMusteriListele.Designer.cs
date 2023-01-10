namespace otoparkOtomasyonu.Formlar
{
    partial class frmMusteriListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.adisoyadiTxt = new System.Windows.Forms.TextBox();
            this.telefonTxt = new System.Windows.Forms.TextBox();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.tarihDtp = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.GüncelleBtn = new System.Windows.Forms.Button();
            this.SecBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 221);
            this.dataGridView1.TabIndex = 0;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(103, 252);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(182, 20);
            this.IDTxt.TabIndex = 1;
            this.IDTxt.TextChanged += new System.EventHandler(this.IDTxt_TextChanged);
            // 
            // adisoyadiTxt
            // 
            this.adisoyadiTxt.Location = new System.Drawing.Point(103, 278);
            this.adisoyadiTxt.Name = "adisoyadiTxt";
            this.adisoyadiTxt.Size = new System.Drawing.Size(182, 20);
            this.adisoyadiTxt.TabIndex = 1;
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(103, 304);
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(182, 20);
            this.telefonTxt.TabIndex = 1;
            // 
            // adresTxt
            // 
            this.adresTxt.Location = new System.Drawing.Point(103, 330);
            this.adresTxt.Multiline = true;
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(182, 56);
            this.adresTxt.TabIndex = 1;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(103, 392);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(182, 20);
            this.emailTxt.TabIndex = 1;
            // 
            // tarihDtp
            // 
            this.tarihDtp.Location = new System.Drawing.Point(103, 418);
            this.tarihDtp.Name = "tarihDtp";
            this.tarihDtp.Size = new System.Drawing.Size(182, 20);
            this.tarihDtp.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID.Location = new System.Drawing.Point(60, 255);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 13);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(43, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarih:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(363, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(607, 252);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(110, 42);
            this.EkleBtn.TabIndex = 5;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Location = new System.Drawing.Point(607, 304);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(110, 42);
            this.SilBtn.TabIndex = 5;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = true;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // GüncelleBtn
            // 
            this.GüncelleBtn.Location = new System.Drawing.Point(607, 352);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(110, 42);
            this.GüncelleBtn.TabIndex = 5;
            this.GüncelleBtn.Text = "Güncelle";
            this.GüncelleBtn.UseVisualStyleBackColor = true;
            this.GüncelleBtn.Click += new System.EventHandler(this.GüncelleBtn_Click);
            // 
            // SecBtn
            // 
            this.SecBtn.Location = new System.Drawing.Point(407, 392);
            this.SecBtn.Name = "SecBtn";
            this.SecBtn.Size = new System.Drawing.Size(75, 42);
            this.SecBtn.TabIndex = 5;
            this.SecBtn.Text = "Seç";
            this.SecBtn.UseVisualStyleBackColor = true;
            this.SecBtn.Click += new System.EventHandler(this.SecBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 501);
            this.Controls.Add(this.SecBtn);
            this.Controls.Add(this.GüncelleBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.tarihDtp);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.adresTxt);
            this.Controls.Add(this.telefonTxt);
            this.Controls.Add(this.adisoyadiTxt);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMusteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmMusteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.TextBox adisoyadiTxt;
        private System.Windows.Forms.TextBox telefonTxt;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.DateTimePicker tarihDtp;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button GüncelleBtn;
        private System.Windows.Forms.Button SecBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}