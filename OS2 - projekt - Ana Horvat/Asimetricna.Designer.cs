
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asimetricna));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.TxtDekriptiraniAES.Location = new System.Drawing.Point(6, 83);
            this.TxtDekriptiraniAES.Multiline = true;
            this.TxtDekriptiraniAES.Name = "TxtDekriptiraniAES";
            this.TxtDekriptiraniAES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDekriptiraniAES.Size = new System.Drawing.Size(330, 132);
            this.TxtDekriptiraniAES.TabIndex = 15;
            this.TxtDekriptiraniAES.Text = "Ovdje će se prikazati dekriptirani tekst.";
            // 
            // BtnDekriptirajAsimetricnimAlgoritmom
            // 
            this.BtnDekriptirajAsimetricnimAlgoritmom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BtnDekriptirajAsimetricnimAlgoritmom.FlatAppearance.BorderSize = 0;
            this.BtnDekriptirajAsimetricnimAlgoritmom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDekriptirajAsimetricnimAlgoritmom.Location = new System.Drawing.Point(6, 19);
            this.BtnDekriptirajAsimetricnimAlgoritmom.Name = "BtnDekriptirajAsimetricnimAlgoritmom";
            this.BtnDekriptirajAsimetricnimAlgoritmom.Size = new System.Drawing.Size(173, 43);
            this.BtnDekriptirajAsimetricnimAlgoritmom.TabIndex = 14;
            this.BtnDekriptirajAsimetricnimAlgoritmom.Text = "Dekriptiraj asimetričnim algoritmom";
            this.BtnDekriptirajAsimetricnimAlgoritmom.UseVisualStyleBackColor = false;
            this.BtnDekriptirajAsimetricnimAlgoritmom.Click += new System.EventHandler(this.BtnDekriptirajAsimetricnimAlgoritmom_Click);
            // 
            // TxtKriptiraniTekst
            // 
            this.TxtKriptiraniTekst.Location = new System.Drawing.Point(6, 83);
            this.TxtKriptiraniTekst.Multiline = true;
            this.TxtKriptiraniTekst.Name = "TxtKriptiraniTekst";
            this.TxtKriptiraniTekst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtKriptiraniTekst.Size = new System.Drawing.Size(330, 132);
            this.TxtKriptiraniTekst.TabIndex = 13;
            this.TxtKriptiraniTekst.Text = "Ovdje će se prikazati kriptirani tekst.";
            // 
            // BtnKriptirajAsimetricnimAlgoritmom
            // 
            this.BtnKriptirajAsimetricnimAlgoritmom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BtnKriptirajAsimetricnimAlgoritmom.FlatAppearance.BorderSize = 0;
            this.BtnKriptirajAsimetricnimAlgoritmom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKriptirajAsimetricnimAlgoritmom.Location = new System.Drawing.Point(6, 19);
            this.BtnKriptirajAsimetricnimAlgoritmom.Name = "BtnKriptirajAsimetricnimAlgoritmom";
            this.BtnKriptirajAsimetricnimAlgoritmom.Size = new System.Drawing.Size(170, 43);
            this.BtnKriptirajAsimetricnimAlgoritmom.TabIndex = 12;
            this.BtnKriptirajAsimetricnimAlgoritmom.Text = "Kriptiraj asimetričnim \r\nalgoritmom";
            this.BtnKriptirajAsimetricnimAlgoritmom.UseVisualStyleBackColor = false;
            this.BtnKriptirajAsimetricnimAlgoritmom.Click += new System.EventHandler(this.BtnKriptirajAsimetricnimAlgoritmom_Click);
            // 
            // TxtOriginalnaDatoteka
            // 
            this.TxtOriginalnaDatoteka.Location = new System.Drawing.Point(240, 60);
            this.TxtOriginalnaDatoteka.Multiline = true;
            this.TxtOriginalnaDatoteka.Name = "TxtOriginalnaDatoteka";
            this.TxtOriginalnaDatoteka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOriginalnaDatoteka.Size = new System.Drawing.Size(527, 101);
            this.TxtOriginalnaDatoteka.TabIndex = 11;
            this.TxtOriginalnaDatoteka.Text = "Ovdje će se prikazati tekst za kriptiranje.";
            // 
            // BtnOdaberiOriginalnuDatoteku
            // 
            this.BtnOdaberiOriginalnuDatoteku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BtnOdaberiOriginalnuDatoteku.FlatAppearance.BorderSize = 0;
            this.BtnOdaberiOriginalnuDatoteku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOdaberiOriginalnuDatoteku.Location = new System.Drawing.Point(30, 119);
            this.BtnOdaberiOriginalnuDatoteku.Name = "BtnOdaberiOriginalnuDatoteku";
            this.BtnOdaberiOriginalnuDatoteku.Size = new System.Drawing.Size(159, 40);
            this.BtnOdaberiOriginalnuDatoteku.TabIndex = 10;
            this.BtnOdaberiOriginalnuDatoteku.Text = "Odaberi originalnu datoteku";
            this.BtnOdaberiOriginalnuDatoteku.UseVisualStyleBackColor = false;
            this.BtnOdaberiOriginalnuDatoteku.Click += new System.EventHandler(this.BtnOdaberiOriginalnuDatoteku_Click);
            // 
            // BtnKreirajKljuceve
            // 
            this.BtnKreirajKljuceve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BtnKreirajKljuceve.FlatAppearance.BorderSize = 0;
            this.BtnKreirajKljuceve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKreirajKljuceve.Location = new System.Drawing.Point(30, 60);
            this.BtnKreirajKljuceve.Name = "BtnKreirajKljuceve";
            this.BtnKreirajKljuceve.Size = new System.Drawing.Size(159, 40);
            this.BtnKreirajKljuceve.TabIndex = 9;
            this.BtnKreirajKljuceve.Text = "Kreiraj javni i privatni ključ";
            this.BtnKreirajKljuceve.UseVisualStyleBackColor = false;
            this.BtnKreirajKljuceve.Click += new System.EventHandler(this.BtnKreirajKljuceve_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnKriptirajAsimetricnimAlgoritmom);
            this.groupBox1.Controls.Add(this.TxtKriptiraniTekst);
            this.groupBox1.Location = new System.Drawing.Point(30, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 221);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kriptiranje";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDekriptirajAsimetricnimAlgoritmom);
            this.groupBox2.Controls.Add(this.TxtDekriptiraniAES);
            this.groupBox2.Location = new System.Drawing.Point(425, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 221);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dekriptiranje";
            // 
            // Asimetricna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtOriginalnaDatoteka);
            this.Controls.Add(this.BtnOdaberiOriginalnuDatoteku);
            this.Controls.Add(this.BtnKreirajKljuceve);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Asimetricna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operacijski sustavi 2 - projekt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}