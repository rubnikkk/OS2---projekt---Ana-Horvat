
namespace OS2___projekt___Ana_Horvat
{
    partial class Asimetricna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simetricnaKriptografijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asimetricnaKriptografijaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izracunSazetkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalniPotpisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtDekriptiraniAES = new System.Windows.Forms.TextBox();
            this.BtnDekriptirajAsimetricnimAlgoritmom = new System.Windows.Forms.Button();
            this.TxtKriptiraniTekst = new System.Windows.Forms.TextBox();
            this.BtnKriptirajAsimetricnimAlgoritmom = new System.Windows.Forms.Button();
            this.TxtOriginalnaDatoteka = new System.Windows.Forms.TextBox();
            this.BtnOdaberiOriginalnuDatoteku = new System.Windows.Forms.Button();
            this.BtnKreirajKljuceve = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simetricnaKriptografijaToolStripMenuItem,
            this.asimetricnaKriptografijaToolStripMenuItem1,
            this.izracunSazetkaToolStripMenuItem,
            this.digitalniPotpisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simetricnaKriptografijaToolStripMenuItem
            // 
            this.simetricnaKriptografijaToolStripMenuItem.Name = "simetricnaKriptografijaToolStripMenuItem";
            this.simetricnaKriptografijaToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.simetricnaKriptografijaToolStripMenuItem.Text = "Simetrična kriptografija";
            this.simetricnaKriptografijaToolStripMenuItem.Click += new System.EventHandler(this.simetricnaKriptografijaToolStripMenuItem_Click);
            // 
            // asimetricnaKriptografijaToolStripMenuItem1
            // 
            this.asimetricnaKriptografijaToolStripMenuItem1.Name = "asimetricnaKriptografijaToolStripMenuItem1";
            this.asimetricnaKriptografijaToolStripMenuItem1.Size = new System.Drawing.Size(149, 20);
            this.asimetricnaKriptografijaToolStripMenuItem1.Text = "Asimetrična kriptografija";
            // 
            // izracunSazetkaToolStripMenuItem
            // 
            this.izracunSazetkaToolStripMenuItem.Name = "izracunSazetkaToolStripMenuItem";
            this.izracunSazetkaToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.izracunSazetkaToolStripMenuItem.Text = "Izračun sažetka";
            this.izracunSazetkaToolStripMenuItem.Click += new System.EventHandler(this.izracunSazetkaToolStripMenuItem_Click);
            // 
            // digitalniPotpisToolStripMenuItem
            // 
            this.digitalniPotpisToolStripMenuItem.Name = "digitalniPotpisToolStripMenuItem";
            this.digitalniPotpisToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.digitalniPotpisToolStripMenuItem.Text = "Digitalni potpis";
            this.digitalniPotpisToolStripMenuItem.Click += new System.EventHandler(this.digitalniPotpisToolStripMenuItem_Click);
            // 
            // TxtDekriptiraniAES
            // 
            this.TxtDekriptiraniAES.Location = new System.Drawing.Point(34, 299);
            this.TxtDekriptiraniAES.Name = "TxtDekriptiraniAES";
            this.TxtDekriptiraniAES.Size = new System.Drawing.Size(346, 20);
            this.TxtDekriptiraniAES.TabIndex = 15;
            this.TxtDekriptiraniAES.Text = "Ovdje će se prikazati dekriptirani tekst.";
            // 
            // BtnDekriptirajAsimetricnimAlgoritmom
            // 
            this.BtnDekriptirajAsimetricnimAlgoritmom.Location = new System.Drawing.Point(421, 247);
            this.BtnDekriptirajAsimetricnimAlgoritmom.Name = "BtnDekriptirajAsimetricnimAlgoritmom";
            this.BtnDekriptirajAsimetricnimAlgoritmom.Size = new System.Drawing.Size(182, 23);
            this.BtnDekriptirajAsimetricnimAlgoritmom.TabIndex = 14;
            this.BtnDekriptirajAsimetricnimAlgoritmom.Text = "Dekriptiraj asimetričnim algoritmom";
            this.BtnDekriptirajAsimetricnimAlgoritmom.UseVisualStyleBackColor = true;
            this.BtnDekriptirajAsimetricnimAlgoritmom.Click += new System.EventHandler(this.BtnDekriptirajAsimetricnimAlgoritmom_Click);
            // 
            // TxtKriptiraniTekst
            // 
            this.TxtKriptiraniTekst.Location = new System.Drawing.Point(34, 250);
            this.TxtKriptiraniTekst.Name = "TxtKriptiraniTekst";
            this.TxtKriptiraniTekst.Size = new System.Drawing.Size(346, 20);
            this.TxtKriptiraniTekst.TabIndex = 13;
            this.TxtKriptiraniTekst.Text = "Ovdje će se prikazati kriptirani tekst.";
            // 
            // BtnKriptirajAsimetricnimAlgoritmom
            // 
            this.BtnKriptirajAsimetricnimAlgoritmom.Location = new System.Drawing.Point(421, 198);
            this.BtnKriptirajAsimetricnimAlgoritmom.Name = "BtnKriptirajAsimetricnimAlgoritmom";
            this.BtnKriptirajAsimetricnimAlgoritmom.Size = new System.Drawing.Size(182, 23);
            this.BtnKriptirajAsimetricnimAlgoritmom.TabIndex = 12;
            this.BtnKriptirajAsimetricnimAlgoritmom.Text = "Kriptiraj asimetričnim algoritmom";
            this.BtnKriptirajAsimetricnimAlgoritmom.UseVisualStyleBackColor = true;
            this.BtnKriptirajAsimetricnimAlgoritmom.Click += new System.EventHandler(this.BtnKriptirajAsimetricnimAlgoritmom_Click);
            // 
            // TxtOriginalnaDatoteka
            // 
            this.TxtOriginalnaDatoteka.Location = new System.Drawing.Point(34, 201);
            this.TxtOriginalnaDatoteka.Name = "TxtOriginalnaDatoteka";
            this.TxtOriginalnaDatoteka.Size = new System.Drawing.Size(346, 20);
            this.TxtOriginalnaDatoteka.TabIndex = 11;
            this.TxtOriginalnaDatoteka.Text = "Ovdje će se prikazati tekst za kriptiranje.";
            // 
            // BtnOdaberiOriginalnuDatoteku
            // 
            this.BtnOdaberiOriginalnuDatoteku.Location = new System.Drawing.Point(34, 153);
            this.BtnOdaberiOriginalnuDatoteku.Name = "BtnOdaberiOriginalnuDatoteku";
            this.BtnOdaberiOriginalnuDatoteku.Size = new System.Drawing.Size(179, 23);
            this.BtnOdaberiOriginalnuDatoteku.TabIndex = 10;
            this.BtnOdaberiOriginalnuDatoteku.Text = "Odaberi originalnu datoteku";
            this.BtnOdaberiOriginalnuDatoteku.UseVisualStyleBackColor = true;
            this.BtnOdaberiOriginalnuDatoteku.Click += new System.EventHandler(this.BtnOdaberiOriginalnuDatoteku_Click);
            // 
            // BtnKreirajKljuceve
            // 
            this.BtnKreirajKljuceve.Location = new System.Drawing.Point(34, 107);
            this.BtnKreirajKljuceve.Name = "BtnKreirajKljuceve";
            this.BtnKreirajKljuceve.Size = new System.Drawing.Size(179, 23);
            this.BtnKreirajKljuceve.TabIndex = 9;
            this.BtnKreirajKljuceve.Text = "Kreiraj javni i privatni ključ";
            this.BtnKreirajKljuceve.UseVisualStyleBackColor = true;
            this.BtnKreirajKljuceve.Click += new System.EventHandler(this.BtnKreirajKljuceve_Click);
            // 
            // Asimetricna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDekriptiraniAES);
            this.Controls.Add(this.BtnDekriptirajAsimetricnimAlgoritmom);
            this.Controls.Add(this.TxtKriptiraniTekst);
            this.Controls.Add(this.BtnKriptirajAsimetricnimAlgoritmom);
            this.Controls.Add(this.TxtOriginalnaDatoteka);
            this.Controls.Add(this.BtnOdaberiOriginalnuDatoteku);
            this.Controls.Add(this.BtnKreirajKljuceve);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Asimetricna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operacijski sustavi 2 - projekt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simetricnaKriptografijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asimetricnaKriptografijaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izracunSazetkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalniPotpisToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtDekriptiraniAES;
        private System.Windows.Forms.Button BtnDekriptirajAsimetricnimAlgoritmom;
        private System.Windows.Forms.TextBox TxtKriptiraniTekst;
        private System.Windows.Forms.Button BtnKriptirajAsimetricnimAlgoritmom;
        private System.Windows.Forms.TextBox TxtOriginalnaDatoteka;
        private System.Windows.Forms.Button BtnOdaberiOriginalnuDatoteku;
        private System.Windows.Forms.Button BtnKreirajKljuceve;
    }
}