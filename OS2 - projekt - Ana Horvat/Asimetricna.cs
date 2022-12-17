using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OS2___projekt___Ana_Horvat
{
    public partial class Asimetricna : Form
    {
        RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
        string filelines;
        string filename;

        RSAParameters publicKey, privateKey;

        public Asimetricna()
        {
            InitializeComponent();
            asimetricnaKriptografijaToolStripMenuItem1.BackColor = Color.FromArgb(204, 229, 255);
        }

        private void BtnKreirajKljuceve_Click(object sender, EventArgs e)
        {
       
            publicKey = csp.ExportParameters(false);
            string javniString = RSAParametersToString(publicKey);
            File.WriteAllText("javni_kljuc.txt", javniString);

            privateKey = csp.ExportParameters(true);
            string privatniString = RSAParametersToString(privateKey);
            File.WriteAllText("privatni_kljuc.txt", privatniString);

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

        private void BtnKriptirajAsimetricnimAlgoritmom_Click(object sender, EventArgs e)
        {
            try
            {
                string plainText = System.IO.File.ReadAllText(@"C:\Users\38591\Desktop\OS2\OS2 - projekt - Ana Horvat\OS2 - projekt - Ana Horvat\bin\Debug\rsa_originalna.txt");
                string publicKeyFile = System.IO.File.ReadAllText(@"C:\Users\38591\Desktop\OS2\OS2 - projekt - Ana Horvat\OS2 - projekt - Ana Horvat\bin\Debug\javni_kljuc.txt");

                RSAParameters publicKey = StringToRSAParameters(publicKeyFile);

                csp.ImportParameters(publicKey);

                var bytesPlainText = System.Text.Encoding.Unicode.GetBytes(plainText);
                var bytesCypherText = csp.Encrypt(bytesPlainText, false);

                string cypherText = Convert.ToBase64String(bytesCypherText);
                TxtKriptiraniTekst.Text = cypherText;

                File.WriteAllText("rsaCypherText.txt", cypherText);

            }
            catch (CryptographicException)
            {
                MessageBox.Show("The text is too long...");
            }
        }

        private void BtnDekriptirajAsimetricnimAlgoritmom_Click(object sender, EventArgs e)
        {
            try
            {
                string inputCypherTextFile = System.IO.File.ReadAllText(@"C:\Users\38591\Desktop\OS2\OS2 - projekt - Ana Horvat\OS2 - projekt - Ana Horvat\bin\Debug\rsaCypherText.txt");
                string privateKeyFile = System.IO.File.ReadAllText(@"C:\Users\38591\Desktop\OS2\OS2 - projekt - Ana Horvat\OS2 - projekt - Ana Horvat\bin\Debug\privatni_kljuc.txt");

                RSAParameters privateKey = StringToRSAParameters(privateKeyFile);

                csp.ImportParameters(privateKey);

                var bytesCypherText = Convert.FromBase64String(inputCypherTextFile);           
                var bytesPlainText = csp.Decrypt(bytesCypherText, false);

                string originalPlainText = Encoding.Unicode.GetString(bytesPlainText);
                           
                TxtDekriptiraniAES.Text = originalPlainText;
            }
            catch (CryptographicException)
            {
                MessageBox.Show("The key is not valid...");
            }
        }

        private static string RSAParametersToString(RSAParameters parameter)
        {
            var sw = new System.IO.StringWriter();
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, parameter);
            return sw.ToString();
        }

        public static RSAParameters StringToRSAParameters(string key)
        {
            var sr = new System.IO.StringReader(key);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            return (RSAParameters)xs.Deserialize(sr);
        }

        private void simetricnaKriptografijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Simetricna simetricna = new Simetricna();
            simetricna.FormClosed += (s, args) => this.Close();
            simetricna.Show();
        }

        private void izracunSazetkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            IzracunSazetka izracunSazetka = new IzracunSazetka();
            izracunSazetka.FormClosed += (s, args) => this.Close();
            izracunSazetka.Show();
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