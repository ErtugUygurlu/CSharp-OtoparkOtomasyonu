namespace otoparkOtomasyonu.Formlar
{
    partial class frmSeri
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
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.MarkaCb = new System.Windows.Forms.ComboBox();
            this.SD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SeriTxt = new System.Windows.Forms.TextBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Serii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(75, 23);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(240, 20);
            this.IDTxt.TabIndex = 2;
            // 
            // MarkaCb
            // 
            this.MarkaCb.FormattingEnabled = true;
            this.MarkaCb.Location = new System.Drawing.Point(75, 56);
            this.MarkaCb.Name = "MarkaCb";
            this.MarkaCb.Size = new System.Drawing.Size(240, 21);
            this.MarkaCb.TabIndex = 3;
            // 
            // SD
            // 
            this.SD.AutoSize = true;
            this.SD.Location = new System.Drawing.Point(34, 26);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(21, 13);
            this.SD.TabIndex = 4;
            this.SD.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seri:";
            // 
            // SeriTxt
            // 
            this.SeriTxt.Location = new System.Drawing.Point(75, 90);
            this.SeriTxt.Name = "SeriTxt";
            this.SeriTxt.Size = new System.Drawing.Size(240, 20);
            this.SeriTxt.TabIndex = 2;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(33, 137);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(90, 43);
            this.ekleBtn.TabIndex = 5;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(225, 137);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(90, 43);
            this.guncelleBtn.TabIndex = 5;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(129, 137);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(90, 43);
            this.silBtn.TabIndex = 5;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 142;
            // 
            // Marka
            // 
            this.Marka.Text = "Marka";
            this.Marka.Width = 164;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Marka,
            this.Serii});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 202);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(528, 165);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            //this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Serii
            // 
            this.Serii.Text = "Seri";
            this.Serii.Width = 205;
            // 
            // frmSeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 367);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SD);
            this.Controls.Add(this.MarkaCb);
            this.Controls.Add(this.SeriTxt);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.listView1);
            this.Name = "frmSeri";
            this.Text = "frmSeri";
            this.Load += new System.EventHandler(this.frmSeri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.ComboBox MarkaCb;
        private System.Windows.Forms.Label SD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SeriTxt;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Serii;
    }
}