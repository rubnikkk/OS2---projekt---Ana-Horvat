﻿
namespace OS2___projekt___Ana_Horvat
{
    partial class DigitalniPotpis
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
            this.BtnDigitalnoPotpisi = new System.Windows.Forms.Button();
            this.TxtOriginalnaDatoteka = new System.Windows.Forms.TextBox();
            this.BtnOdaberiOriginalnuDatoteku = new System.Windows.Forms.Button();
            this.BtnProvjeriDigitalniPotpis = new System.Windows.Forms.Button();
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
            this.menuStrip1.TabIndex = 10;
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
            // 
            // BtnDigitalnoPotpisi
            // 
            this.BtnDigitalnoPotpisi.Location = new System.Drawing.Point(422, 126);
            this.BtnDigitalnoPotpisi.Name = "BtnDigitalnoPotpisi";
            this.BtnDigitalnoPotpisi.Size = new System.Drawing.Size(179, 23);
            this.BtnDigitalnoPotpisi.TabIndex = 16;
            this.BtnDigitalnoPotpisi.Text = "Digitalno potipši";
            this.BtnDigitalnoPotpisi.UseVisualStyleBackColor = true;
            this.BtnDigitalnoPotpisi.Click += new System.EventHandler(this.BtnDigitalnoPotpisi_Click);
            // 
            // TxtOriginalnaDatoteka
            // 
            this.TxtOriginalnaDatoteka.Location = new System.Drawing.Point(30, 129);
            this.TxtOriginalnaDatoteka.Name = "TxtOriginalnaDatoteka";
            this.TxtOriginalnaDatoteka.Size = new System.Drawing.Size(346, 20);
            this.TxtOriginalnaDatoteka.TabIndex = 15;
            this.TxtOriginalnaDatoteka.Text = "Ovdje će se prikazati sadržaj datoteka za potpisivanje.";
            // 
            // BtnOdaberiOriginalnuDatoteku
            // 
            this.BtnOdaberiOriginalnuDatoteku.Location = new System.Drawing.Point(30, 74);
            this.BtnOdaberiOriginalnuDatoteku.Name = "BtnOdaberiOriginalnuDatoteku";
            this.BtnOdaberiOriginalnuDatoteku.Size = new System.Drawing.Size(179, 23);
            this.BtnOdaberiOriginalnuDatoteku.TabIndex = 14;
            this.BtnOdaberiOriginalnuDatoteku.Text = "Odaberi originalnu datoteku";
            this.BtnOdaberiOriginalnuDatoteku.UseVisualStyleBackColor = true;
            this.BtnOdaberiOriginalnuDatoteku.Click += new System.EventHandler(this.BtnOdaberiOriginalnuDatoteku_Click);
            // 
            // BtnProvjeriDigitalniPotpis
            // 
            this.BtnProvjeriDigitalniPotpis.Location = new System.Drawing.Point(30, 237);
            this.BtnProvjeriDigitalniPotpis.Name = "BtnProvjeriDigitalniPotpis";
            this.BtnProvjeriDigitalniPotpis.Size = new System.Drawing.Size(179, 23);
            this.BtnProvjeriDigitalniPotpis.TabIndex = 17;
            this.BtnProvjeriDigitalniPotpis.Text = "Provjeri digitalni potpis";
            this.BtnProvjeriDigitalniPotpis.UseVisualStyleBackColor = true;
            this.BtnProvjeriDigitalniPotpis.Click += new System.EventHandler(this.BtnProvjeriDigitalniPotpis_Click);
            // 
            // DigitalniPotpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnProvjeriDigitalniPotpis);
            this.Controls.Add(this.BtnDigitalnoPotpisi);
            this.Controls.Add(this.TxtOriginalnaDatoteka);
            this.Controls.Add(this.BtnOdaberiOriginalnuDatoteku);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DigitalniPotpis";
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
        private System.Windows.Forms.Button BtnDigitalnoPotpisi;
        private System.Windows.Forms.TextBox TxtOriginalnaDatoteka;
        private System.Windows.Forms.Button BtnOdaberiOriginalnuDatoteku;
        private System.Windows.Forms.Button BtnProvjeriDigitalniPotpis;
    }
}