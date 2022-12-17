using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace OS2___projekt___Ana_Horvat
{
    public partial class Simetricna : Form
    {
        string filelines, filename, originalFilePath;
        byte[] secretKey, iv, cypher, hashSecretKey, hashIv, hashCypher;

        public Simetricna()
        {
            InitializeComponent();
            simetricnaKriptografijaToolStripMenuItem.BackColor = Color.FromArgb(204,229,255);
        }

        private void BtnKreirajTajniKljuc_ClickAsync(object sender, EventArgs e)
        {
            using (Aes myAes = Aes.Create())
            {
                secretKey = myAes.Key;
                File.WriteAllText("tajni_kljuc.txt", Encoding.Default.GetString(secretKey));
                hashSecretKey = GetFileHash("tajni_kljuc.txt");

                iv = myAes.IV;
                File.WriteAllText("iv.txt", Encoding.Default.GetString(iv));
                hashIv = GetFileHash("iv.txt");
            }

            MessageBox.Show("Ključevi su kreirani!");
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
                originalFilePath = Path.GetFullPath(filename);
                filelines = String.Concat(File.ReadAllLines(filename));
                TxtOriginalnaDatoteka.Text = filelines;
            }
        }

        private void BtnKriptirajSimetricnimAlgoritmom_Click(object sender, EventArgs e)
        {
         
            if (Check())
            {
                string text = System.IO.File.ReadAllText(originalFilePath);

                cypher = EncryptStringToBytes_Aes(text, secretKey, iv);

                File.WriteAllText("kriptirani_aes.txt", String.Concat(cypher));
                hashCypher = GetFileHash("kriptirani_aes.txt");

                TxtKriptiraniTekst.Text = String.Concat(cypher);
            }
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {

            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        private void BtnDekriptirajSimetricnimAlgoritmom_Click(object sender, EventArgs e)
        {
            if (Check() && hashCypher.SequenceEqual(GetFileHash("kriptirani_aes.txt")))
            {
                TxtDekriptiraniAES.Text = DecryptStringFromBytes_Aes(cypher, secretKey, iv);
            }
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        private byte[] GetFileHash(string fileName)
        {
            HashAlgorithm sha1 = HashAlgorithm.Create();
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                return sha1.ComputeHash(stream);
        }

        private bool Check()
        {
            bool ok = true;

            if (!hashSecretKey.SequenceEqual(GetFileHash("tajni_kljuc.txt")))
            {
                ok = false;
                MessageBox.Show("Došlo je do promjene sadržaja datoteke tajni_kljuc.txt!");
            }

            if (!hashIv.SequenceEqual(GetFileHash("iv.txt")))
            {
                ok = false;
                MessageBox.Show("Došlo je do promjene sadržaja datoteke iv.txt!");
            }

            return ok;
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

        private void digitalniPotpisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DigitalniPotpis digitalniPotpis = new DigitalniPotpis();
            digitalniPotpis.FormClosed += (s, args) => this.Close();
            digitalniPotpis.Show();
        }
    }
}