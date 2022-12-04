
namespace OS2___projekt___Ana_Horvat
{
    partial class Main
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
            this.BtnKreirajTajniKljuc = new System.Windows.Forms.Button();
            this.BtnOdaberiOriginalnuDatoteku = new System.Windows.Forms.Button();
            this.TxtOriginalnaDatoteka = new System.Windows.Forms.TextBox();
            this.BtnKriptirajSimetricnimAlgoritmom = new System.Windows.Forms.Button();
            this.TxtKriptiraniTekst = new System.Windows.Forms.TextBox();
            this.BtnDekriptirajSimetricnimAlgoritmom = new System.Windows.Forms.Button();
            this.TxtDekriptiraniAES = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnKreirajTajniKljuc
            // 
            this.BtnKreirajTajniKljuc.Location = new System.Drawing.Point(32, 37);
            this.BtnKreirajTajniKljuc.Name = "BtnKreirajTajniKljuc";
            this.BtnKreirajTajniKljuc.Size = new System.Drawing.Size(93, 23);
            this.BtnKreirajTajniKljuc.TabIndex = 0;
            this.BtnKreirajTajniKljuc.Text = "Kreiraj tajni ključ";
            this.BtnKreirajTajniKljuc.UseVisualStyleBackColor = true;
            this.BtnKreirajTajniKljuc.Click += new System.EventHandler(this.BtnKreirajTajniKljuc_ClickAsync);
            // 
            // BtnOdaberiOriginalnuDatoteku
            // 
            this.BtnOdaberiOriginalnuDatoteku.Location = new System.Drawing.Point(32, 92);
            this.BtnOdaberiOriginalnuDatoteku.Name = "BtnOdaberiOriginalnuDatoteku";
            this.BtnOdaberiOriginalnuDatoteku.Size = new System.Drawing.Size(159, 23);
            this.BtnOdaberiOriginalnuDatoteku.TabIndex = 1;
            this.BtnOdaberiOriginalnuDatoteku.Text = "Odaberi originalnu datoteku";
            this.BtnOdaberiOriginalnuDatoteku.UseVisualStyleBackColor = true;
            this.BtnOdaberiOriginalnuDatoteku.Click += new System.EventHandler(this.BtnOdaberiOriginalnuDatoteku_Click);
            // 
            // TxtOriginalnaDatoteka
            // 
            this.TxtOriginalnaDatoteka.Location = new System.Drawing.Point(32, 131);
            this.TxtOriginalnaDatoteka.Name = "TxtOriginalnaDatoteka";
            this.TxtOriginalnaDatoteka.Size = new System.Drawing.Size(346, 20);
            this.TxtOriginalnaDatoteka.TabIndex = 2;
            this.TxtOriginalnaDatoteka.Text = "Ovdje će se prikazati tekst za kriptiranje.";
            // 
            // BtnKriptirajSimetricnimAlgoritmom
            // 
            this.BtnKriptirajSimetricnimAlgoritmom.Location = new System.Drawing.Point(419, 128);
            this.BtnKriptirajSimetricnimAlgoritmom.Name = "BtnKriptirajSimetricnimAlgoritmom";
            this.BtnKriptirajSimetricnimAlgoritmom.Size = new System.Drawing.Size(182, 23);
            this.BtnKriptirajSimetricnimAlgoritmom.TabIndex = 3;
            this.BtnKriptirajSimetricnimAlgoritmom.Text = "Kriptiraj simetričnim algoritmom";
            this.BtnKriptirajSimetricnimAlgoritmom.UseVisualStyleBackColor = true;
            this.BtnKriptirajSimetricnimAlgoritmom.Click += new System.EventHandler(this.BtnKriptirajSimetricnimAlgoritmom_Click);
            // 
            // TxtKriptiraniTekst
            // 
            this.TxtKriptiraniTekst.Location = new System.Drawing.Point(32, 180);
            this.TxtKriptiraniTekst.Name = "TxtKriptiraniTekst";
            this.TxtKriptiraniTekst.Size = new System.Drawing.Size(346, 20);
            this.TxtKriptiraniTekst.TabIndex = 4;
            this.TxtKriptiraniTekst.Text = "Ovdje će se prikazati kriptirani tekst.";
            // 
            // BtnDekriptirajSimetricnimAlgoritmom
            // 
            this.BtnDekriptirajSimetricnimAlgoritmom.Location = new System.Drawing.Point(419, 177);
            this.BtnDekriptirajSimetricnimAlgoritmom.Name = "BtnDekriptirajSimetricnimAlgoritmom";
            this.BtnDekriptirajSimetricnimAlgoritmom.Size = new System.Drawing.Size(182, 23);
            this.BtnDekriptirajSimetricnimAlgoritmom.TabIndex = 5;
            this.BtnDekriptirajSimetricnimAlgoritmom.Text = "Dekriptiraj simetričnim algoritmom";
            this.BtnDekriptirajSimetricnimAlgoritmom.UseVisualStyleBackColor = true;
            this.BtnDekriptirajSimetricnimAlgoritmom.Click += new System.EventHandler(this.BtnDekriptirajSimetricnimAlgoritmom_Click);
            // 
            // TxtDekriptiraniAES
            // 
            this.TxtDekriptiraniAES.Location = new System.Drawing.Point(32, 229);
            this.TxtDekriptiraniAES.Name = "TxtDekriptiraniAES";
            this.TxtDekriptiraniAES.Size = new System.Drawing.Size(346, 20);
            this.TxtDekriptiraniAES.TabIndex = 6;
            this.TxtDekriptiraniAES.Text = "Ovdje će se prikazati dekriptirani tekst.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDekriptiraniAES);
            this.Controls.Add(this.BtnDekriptirajSimetricnimAlgoritmom);
            this.Controls.Add(this.TxtKriptiraniTekst);
            this.Controls.Add(this.BtnKriptirajSimetricnimAlgoritmom);
            this.Controls.Add(this.TxtOriginalnaDatoteka);
            this.Controls.Add(this.BtnOdaberiOriginalnuDatoteku);
            this.Controls.Add(this.BtnKreirajTajniKljuc);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKreirajTajniKljuc;
        private System.Windows.Forms.Button BtnOdaberiOriginalnuDatoteku;
        private System.Windows.Forms.TextBox TxtOriginalnaDatoteka;
        private System.Windows.Forms.Button BtnKriptirajSimetricnimAlgoritmom;
        private System.Windows.Forms.TextBox TxtKriptiraniTekst;
        private System.Windows.Forms.Button BtnDekriptirajSimetricnimAlgoritmom;
        private System.Windows.Forms.TextBox TxtDekriptiraniAES;
    }
}

