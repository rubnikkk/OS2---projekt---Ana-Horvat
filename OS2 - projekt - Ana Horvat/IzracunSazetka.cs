﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace OS2___projekt___Ana_Horvat
{
    public partial class IzracunSazetka : Form
    {
        string filename, filelines, originalFilePath;

        public IzracunSazetka()
        {
            InitializeComponent();
            izracunSazetkaToolStripMenuItem.BackColor = Color.FromArgb(204, 229, 255);
        }

        private void BtnOdaberiOriginalnuDatoteku_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Odaberite originalnu datoteku",
                Filter = "TXT file |*.txt"
            };
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                filelines = String.Concat(File.ReadAllLines(filename));
                originalFilePath = Path.GetFullPath(filename);
                TxtOriginalnaDatoteka.Text = filelines;
            }
        }

        public static string Hash (string plainText)
        {
            SHA256Managed managed = new SHA256Managed();
            StringBuilder hash = new StringBuilder();

            byte[] computeHash = managed.ComputeHash(Encoding.UTF8.GetBytes(plainText));

            foreach (byte b in computeHash)
            {
                hash.Append(b.ToString("x2"));
            }

            return hash.ToString();
        }

        private void BtnIzracunajSazetak_Click(object sender, EventArgs e)
        {
            string inputFile = System.IO.File.ReadAllText(originalFilePath);
            string hash = Hash(inputFile);
            
            File.WriteAllText("sazetak.txt", hash);

            TxtSazetak.Text = hash;
        }

        private void simetricnaKriptografijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Simetricna simetricna = new Simetricna();
            simetricna.FormClosed += (s, args) => this.Close();
            simetricna.Show();
        }

        private void asimetricnaKriptografijaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Asimetricna asimetricna = new Asimetricna();
            asimetricna.FormClosed += (s, args) => this.Close();
            asimetricna.Show();
        }

        private void digitalniPotpisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DigitalniPotpis digitalniPotpis = new DigitalniPotpis();
            digitalniPotpis.FormClosed += (s, args) => this.Close();
            digitalniPotpis.Show();
        }

    }
}