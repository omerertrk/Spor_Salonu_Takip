namespace Spor_Salonu_Takip
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Ara
            // 
            this.btn_Ara.Image = global::Spor_Salonu_Takip.Properties.Resources.ara;
            this.btn_Ara.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Ara.Location = new System.Drawing.Point(425, 12);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(96, 86);
            this.btn_Ara.TabIndex = 4;
            this.btn_Ara.Text = "Kişi Ara";
            this.btn_Ara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Image = global::Spor_Salonu_Takip.Properties.Resources.guncelle;
            this.btn_Guncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guncelle.Location = new System.Drawing.Point(290, 12);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(105, 86);
            this.btn_Guncelle.TabIndex = 3;
            this.btn_Guncelle.Text = "Seçili Kaydı Güncelle";
            this.btn_Guncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Image = global::Spor_Salonu_Takip.Properties.Resources.sil;
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sil.Location = new System.Drawing.Point(146, 12);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(105, 86);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Seçili Kaydı Sil";
            this.btn_Sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Image = global::Spor_Salonu_Takip.Properties.Resources.ekle1;
            this.btn_Ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Ekle.Location = new System.Drawing.Point(12, 12);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(106, 86);
            this.btn_Ekle.TabIndex = 1;
            this.btn_Ekle.Text = "Yeni Kişi Ekle";
            this.btn_Ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Spor_Salonu_Takip.Properties.Resources.bılgi;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(559, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 86);
            this.button1.TabIndex = 5;
            this.button1.Text = "Seçili Kişinin Beden Bilgileri";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Spor Salonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Ara;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

