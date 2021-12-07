
namespace OgrenciSinavKayitSistemi
{
    partial class FrmGiriş
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.MtxSifre = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtbGiris = new System.Windows.Forms.Button();
            this.MtxOgrenciNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.MtxSifre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtbGiris);
            this.panel1.Controls.Add(this.MtxOgrenciNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 401);
            this.panel1.TabIndex = 5;
            // 
            // MtxSifre
            // 
            this.MtxSifre.Location = new System.Drawing.Point(231, 153);
            this.MtxSifre.Mask = "000000000";
            this.MtxSifre.Name = "MtxSifre";
            this.MtxSifre.Size = new System.Drawing.Size(160, 30);
            this.MtxSifre.TabIndex = 9;
            this.MtxSifre.ValidatingType = typeof(int);
            this.MtxSifre.TextChanged += new System.EventHandler(this.ogretmen_giris);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Öğrenci Şifre :    ";
            // 
            // BtbGiris
            // 
            this.BtbGiris.Location = new System.Drawing.Point(107, 252);
            this.BtbGiris.Name = "BtbGiris";
            this.BtbGiris.Size = new System.Drawing.Size(266, 68);
            this.BtbGiris.TabIndex = 7;
            this.BtbGiris.Text = "Giriş Yap";
            this.BtbGiris.UseVisualStyleBackColor = true;
            // 
            // MtxOgrenciNo
            // 
            this.MtxOgrenciNo.Location = new System.Drawing.Point(231, 80);
            this.MtxOgrenciNo.Mask = "000000000";
            this.MtxOgrenciNo.Name = "MtxOgrenciNo";
            this.MtxOgrenciNo.Size = new System.Drawing.Size(160, 30);
            this.MtxOgrenciNo.TabIndex = 6;
            this.MtxOgrenciNo.ValidatingType = typeof(int);
            this.MtxOgrenciNo.TextChanged += new System.EventHandler(this.ogretmen_giris);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci No :    ";
            // 
            // FrmGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(498, 425);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiriş";
            this.Text = "Öğrenci Girişi ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox MtxSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtbGiris;
        private System.Windows.Forms.MaskedTextBox MtxOgrenciNo;
        private System.Windows.Forms.Label label1;
    }
}

