namespace otoparkOtomasyonu.Formlar
{
    partial class frmmarka
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.MarkaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.silBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Marka});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(501, 216);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(119, 252);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(154, 20);
            this.IDTxt.TabIndex = 1;
            // 
            // MarkaTxt
            // 
            this.MarkaTxt.Location = new System.Drawing.Point(119, 278);
            this.MarkaTxt.Name = "MarkaTxt";
            this.MarkaTxt.Size = new System.Drawing.Size(154, 20);
            this.MarkaTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(354, 250);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(91, 23);
            this.EkleBtn.TabIndex = 3;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka:";
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(354, 285);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(91, 23);
            this.silBtn.TabIndex = 3;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(354, 320);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(91, 23);
            this.guncelleBtn.TabIndex = 3;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 142;
            // 
            // Marka
            // 
            this.Marka.Text = "Marka";
            this.Marka.Width = 354;
            // 
            // frmmarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 367);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MarkaTxt);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.listView1);
            this.Name = "frmmarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Sayfası";
            this.Load += new System.EventHandler(this.frmmarka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.TextBox MarkaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Marka;
    }
}