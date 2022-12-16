using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace OS2___projekt___Ana_Horvat
{
    public partial class DigitalniPotpis : Form
    {
        string filename;
        string filelines;
        public DigitalniPotpis()
        {
            InitializeComponent();
            digitalniPotpisToolStripMenuItem.BackColor = Color.FromArgb(204, 229, 255);
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

        private void izracunSazetkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            IzracunSazetka izracunSazetka = new IzracunSazetka();
            izracunSazetka.FormClosed += (s, args) => this.Close();
            izracunSazetka.Show();
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
                TxtOriginalnaDatoteka.Text = filelines;
            }
        }

        private void BtnDigitalnoPotpisi_Click(object sender, EventArgs e)
        {
            string inputFile = System.IO.File.ReadAllText(@"C:\Users\38591\Desktop\OS2\OS2 - projekt - Ana Horvat\OS2 - projekt - Ana Horvat\bin\Debug\datoteka.txt");            
            string inputKeyFile = System.IO.File.ReadAllText(@"C:\Users\38591\Desktop\OS2\OS2 - projekt - Ana Horvat\OS2 - projekt - Ana Horvat\bin\Debug\javni_kljuc.txt");
            RSAParameters inputKey = StringToRSAParameters(inputKeyFile);

            string hash = Hash(inputFile);
            File.WriteAllText("hash_digitalni.txt", hash);

            string hashEncrypted = EncryptText(hash, inputKey);
            File.WriteAllText("hashEncrypted.txt", hashEncrypted);           
        }

        public static RSAParameters StringToRSAParameters(string key)
        {
            var sr = new System.IO.StringReader(key);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            return (RSAParameters)xs.Deserialize(sr);
        }

        public static string Hash(string plainText)
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

        public static string EncryptText(string plainText, RSAParameters publicKey)
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();

            csp.ImportParameters(publicKey);

            var bytesPlainText = System.Text.Encoding.Unicode.GetBytes(plainText);
            var bytesCypherText = csp.Encrypt(bytesPlainText, false);

            return Convert.ToBase64String(bytesCypherText);
        }

        public static string DecryptText(string cypherText, RSAParameters privateKey)
        {

            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();

            csp.ImportParameters(privateKey);

            var bytesCypherText = Convert.FromBase64String(cypherText);
            var bytesPlainText = csp.Decrypt(bytesCypherText, false);

            return Encoding.Unicode.GetString(bytesPlainText);
        }

        private void BtnProvjeriDigitalniPotpis_Click(object sender, EventArgs e)
        {
            string inputFile = System.IO.File.ReadAllText(@"C:\Users\38591\Desktop\OS2\OS2 - projekt - Ana Horvat\OS2 - projekt - Ana Horvat\bin\Debug\datoteka.txt");
            string inputKeyFile = System.IO.File.ReadAllText(@"C:\Users\38591\Desktop\OS2\OS2 - projekt - Ana Horvat\OS2 - projekt - Ana Horvat\bin\Debug\privatni_kljuc.txt");
            RSAParameters inputKey = StringToRSAParameters(inputKeyFile);

            string inputSignature = System.IO.File.ReadAllText(@"C:\Users\38591\Desktop\OS2\OS2 - projekt - Ana Horvat\OS2 - projekt - Ana Horvat\bin\Debug\hashEncrypted.txt");

            string decryptedHash = DecryptText(inputSignature, inputKey);
            string hash = Hash(inputFile);

            if (decryptedHash == hash)
            {
                MessageBox.Show("Potpis je valjan!");
            }
            else
            {
                MessageBox.Show("Potpis nije valjan!");
            }
        }
    }
}
