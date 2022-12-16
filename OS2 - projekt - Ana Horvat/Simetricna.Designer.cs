
namespace OS2___projekt___Ana_Horvat
{
    partial class Simetricna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simetricnaKriptografijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asimetricnaKriptografijaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izracunSazetkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalniPotpisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnKreirajTajniKljuc
            // 
            this.BtnKreirajTajniKljuc.Location = new System.Drawing.Point(38, 111);
            this.BtnKreirajTajniKljuc.Name = "BtnKreirajTajniKljuc";
            this.BtnKreirajTajniKljuc.Size = new System.Drawing.Size(93, 23);
            this.BtnKreirajTajniKljuc.TabIndex = 0;
            this.BtnKreirajTajniKljuc.Text = "Kreiraj tajni ključ";
            this.BtnKreirajTajniKljuc.UseVisualStyleBackColor = true;
            this.BtnKreirajTajniKljuc.Click += new System.EventHandler(this.BtnKreirajTajniKljuc_ClickAsync);
            // 
            // BtnOdaberiOriginalnuDatoteku
            // 
            this.BtnOdaberiOriginalnuDatoteku.Location = new System.Drawing.Point(38, 166);
            this.BtnOdaberiOriginalnuDatoteku.Name = "BtnOdaberiOriginalnuDatoteku";
            this.BtnOdaberiOriginalnuDatoteku.Size = new System.Drawing.Size(159, 23);
            this.BtnOdaberiOriginalnuDatoteku.TabIndex = 1;
            this.BtnOdaberiOriginalnuDatoteku.Text = "Odaberi originalnu datoteku";
            this.BtnOdaberiOriginalnuDatoteku.UseVisualStyleBackColor = true;
            this.BtnOdaberiOriginalnuDatoteku.Click += new System.EventHandler(this.BtnOdaberiOriginalnuDatoteku_Click);
            // 
            // TxtOriginalnaDatoteka
            // 
            this.TxtOriginalnaDatoteka.Location = new System.Drawing.Point(38, 205);
            this.TxtOriginalnaDatoteka.Name = "TxtOriginalnaDatoteka";
            this.TxtOriginalnaDatoteka.Size = new System.Drawing.Size(346, 20);
            this.TxtOriginalnaDatoteka.TabIndex = 2;
            this.TxtOriginalnaDatoteka.Text = "Ovdje će se prikazati tekst za kriptiranje.";
            // 
            // BtnKriptirajSimetricnimAlgoritmom
            // 
            this.BtnKriptirajSimetricnimAlgoritmom.Location = new System.Drawing.Point(425, 202);
            this.BtnKriptirajSimetricnimAlgoritmom.Name = "BtnKriptirajSimetricnimAlgoritmom";
            this.BtnKriptirajSimetricnimAlgoritmom.Size = new System.Drawing.Size(182, 23);
            this.BtnKriptirajSimetricnimAlgoritmom.TabIndex = 3;
            this.BtnKriptirajSimetricnimAlgoritmom.Text = "Kriptiraj simetričnim algoritmom";
            this.BtnKriptirajSimetricnimAlgoritmom.UseVisualStyleBackColor = true;
            this.BtnKriptirajSimetricnimAlgoritmom.Click += new System.EventHandler(this.BtnKriptirajSimetricnimAlgoritmom_Click);
            // 
            // TxtKriptiraniTekst
            // 
            this.TxtKriptiraniTekst.Location = new System.Drawing.Point(38, 254);
            this.TxtKriptiraniTekst.Name = "TxtKriptiraniTekst";
            this.TxtKriptiraniTekst.Size = new System.Drawing.Size(346, 20);
            this.TxtKriptiraniTekst.TabIndex = 4;
            this.TxtKriptiraniTekst.Text = "Ovdje će se prikazati kriptirani tekst.";
            // 
            // BtnDekriptirajSimetricnimAlgoritmom
            // 
            this.BtnDekriptirajSimetricnimAlgoritmom.Location = new System.Drawing.Point(425, 251);
            this.BtnDekriptirajSimetricnimAlgoritmom.Name = "BtnDekriptirajSimetricnimAlgoritmom";
            this.BtnDekriptirajSimetricnimAlgoritmom.Size = new System.Drawing.Size(182, 23);
            this.BtnDekriptirajSimetricnimAlgoritmom.TabIndex = 5;
            this.BtnDekriptirajSimetricnimAlgoritmom.Text = "Dekriptiraj simetričnim algoritmom";
            this.BtnDekriptirajSimetricnimAlgoritmom.UseVisualStyleBackColor = true;
            this.BtnDekriptirajSimetricnimAlgoritmom.Click += new System.EventHandler(this.BtnDekriptirajSimetricnimAlgoritmom_Click);
            // 
            // TxtDekriptiraniAES
            // 
            this.TxtDekriptiraniAES.Location = new System.Drawing.Point(38, 303);
            this.TxtDekriptiraniAES.Name = "TxtDekriptiraniAES";
            this.TxtDekriptiraniAES.Size = new System.Drawing.Size(346, 20);
            this.TxtDekriptiraniAES.TabIndex = 6;
            this.TxtDekriptiraniAES.Text = "Ovdje će se prikazati dekriptirani tekst.";
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
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simetricnaKriptografijaToolStripMenuItem
            // 
            this.simetricnaKriptografijaToolStripMenuItem.Name = "simetricnaKriptografijaToolStripMenuItem";
            this.simetricnaKriptografijaToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.simetricnaKriptografijaToolStripMenuItem.Text = "Simetrična kriptografija";
            // 
            // asimetricnaKriptografijaToolStripMenuItem1
            // 
            this.asimetricnaKriptografijaToolStripMenuItem1.Name = "asimetricnaKriptografijaToolStripMenuItem1";
            this.asimetricnaKriptografijaToolStripMenuItem1.Size = new System.Drawing.Size(149, 20);
            this.asimetricnaKriptografijaToolStripMenuItem1.Text = "Asimetrična kriptografija";
            this.asimetricnaKriptografijaToolStripMenuItem1.Click += new System.EventHandler(this.asimetricnaKriptografijaToolStripMenuItem1_Click);
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
            // Simetricna
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Simetricna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operacijski sustavi 2 - projekt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simetricnaKriptografijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asimetricnaKriptografijaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izracunSazetkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalniPotpisToolStripMenuItem;
    }
}

