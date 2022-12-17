
namespace OS2___projekt___Ana_Horvat
{
    partial class IzracunSazetka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzracunSazetka));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simetricnaKriptografijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asimetricnaKriptografijaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izracunSazetkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalniPotpisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOdaberiOriginalnuDatoteku = new System.Windows.Forms.Button();
            this.TxtOriginalnaDatoteka = new System.Windows.Forms.TextBox();
            this.BtnIzracunajSazetak = new System.Windows.Forms.Button();
            this.TxtSazetak = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.TabIndex = 9;
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
            // 
            // digitalniPotpisToolStripMenuItem
            // 
            this.digitalniPotpisToolStripMenuItem.Name = "digitalniPotpisToolStripMenuItem";
            this.digitalniPotpisToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.digitalniPotpisToolStripMenuItem.Text = "Digitalni potpis";
            this.digitalniPotpisToolStripMenuItem.Click += new System.EventHandler(this.digitalniPotpisToolStripMenuItem_Click);
            // 
            // BtnOdaberiOriginalnuDatoteku
            // 
            this.BtnOdaberiOriginalnuDatoteku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BtnOdaberiOriginalnuDatoteku.FlatAppearance.BorderSize = 0;
            this.BtnOdaberiOriginalnuDatoteku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOdaberiOriginalnuDatoteku.Location = new System.Drawing.Point(30, 60);
            this.BtnOdaberiOriginalnuDatoteku.Name = "BtnOdaberiOriginalnuDatoteku";
            this.BtnOdaberiOriginalnuDatoteku.Size = new System.Drawing.Size(159, 49);
            this.BtnOdaberiOriginalnuDatoteku.TabIndex = 11;
            this.BtnOdaberiOriginalnuDatoteku.Text = "Odaberi originalnu datoteku";
            this.BtnOdaberiOriginalnuDatoteku.UseVisualStyleBackColor = false;
            this.BtnOdaberiOriginalnuDatoteku.Click += new System.EventHandler(this.BtnOdaberiOriginalnuDatoteku_Click);
            // 
            // TxtOriginalnaDatoteka
            // 
            this.TxtOriginalnaDatoteka.Location = new System.Drawing.Point(30, 135);
            this.TxtOriginalnaDatoteka.Multiline = true;
            this.TxtOriginalnaDatoteka.Name = "TxtOriginalnaDatoteka";
            this.TxtOriginalnaDatoteka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOriginalnaDatoteka.Size = new System.Drawing.Size(346, 136);
            this.TxtOriginalnaDatoteka.TabIndex = 12;
            this.TxtOriginalnaDatoteka.Text = "Ovdje će se prikazati tekst za izračun sažetka.";
            // 
            // BtnIzracunajSazetak
            // 
            this.BtnIzracunajSazetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BtnIzracunajSazetak.FlatAppearance.BorderSize = 0;
            this.BtnIzracunajSazetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzracunajSazetak.Location = new System.Drawing.Point(30, 298);
            this.BtnIzracunajSazetak.Name = "BtnIzracunajSazetak";
            this.BtnIzracunajSazetak.Size = new System.Drawing.Size(159, 49);
            this.BtnIzracunajSazetak.TabIndex = 13;
            this.BtnIzracunajSazetak.Text = "Izračunaj sažetak";
            this.BtnIzracunajSazetak.UseVisualStyleBackColor = false;
            this.BtnIzracunajSazetak.Click += new System.EventHandler(this.BtnIzracunajSazetak_Click);
            // 
            // TxtSazetak
            // 
            this.TxtSazetak.Location = new System.Drawing.Point(424, 135);
            this.TxtSazetak.Multiline = true;
            this.TxtSazetak.Name = "TxtSazetak";
            this.TxtSazetak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSazetak.Size = new System.Drawing.Size(346, 136);
            this.TxtSazetak.TabIndex = 14;
            this.TxtSazetak.Text = "Ovdje će biti prikazan sažetak.";
            // 
            // IzracunSazetka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtSazetak);
            this.Controls.Add(this.BtnIzracunajSazetak);
            this.Controls.Add(this.TxtOriginalnaDatoteka);
            this.Controls.Add(this.BtnOdaberiOriginalnuDatoteku);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzracunSazetka";
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
        private System.Windows.Forms.Button BtnOdaberiOriginalnuDatoteku;
        private System.Windows.Forms.TextBox TxtOriginalnaDatoteka;
        private System.Windows.Forms.Button BtnIzracunajSazetak;
        private System.Windows.Forms.TextBox TxtSazetak;
    }
}