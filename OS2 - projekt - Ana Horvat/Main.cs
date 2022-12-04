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
    public partial class Main : Form
    {
        string filelines;
        string filename;
        byte[] tajniKljuc;
        byte[] iv;
        byte[] kriptirano;
        byte[] hashTajniKljuc;
        byte[] hashIv;
        byte[] hashKriptirano;
        public Main()
        {
            InitializeComponent();
        }

        private void BtnKreirajTajniKljuc_ClickAsync(object sender, EventArgs e)
        {
            using (Aes myAes = Aes.Create())
            {
                tajniKljuc = myAes.Key;
                File.WriteAllText("tajni_kljuc.txt", Encoding.Default.GetString(tajniKljuc));
                hashTajniKljuc = GetFileHash("tajni_kljuc.txt");

                iv = myAes.IV;
                File.WriteAllText("iv.txt", Encoding.Default.GetString(iv));
                hashIv = GetFileHash("iv.txt");
            }
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

        private void BtnKriptirajSimetricnimAlgoritmom_Click(object sender, EventArgs e)
        {

            if (Provjera())
            {
                string tekst = System.IO.File.ReadAllText(@"C:\Users\38591\Desktop\OS2\OS2 - projekt - Ana Horvat\OS2 - projekt - Ana Horvat\bin\Debug\originalna_datoteka.txt");

                kriptirano = EncryptStringToBytes_Aes(tekst, tajniKljuc, iv);

                File.WriteAllText("kriptirani_aes.txt", String.Concat(kriptirano));
                hashKriptirano = GetFileHash("kriptirani_aes.txt");

                TxtKriptiraniTekst.Text = String.Concat(kriptirano);
            }
            else
            {
                MessageBox.Show("Došlo je do namjerne promjene sadržaja datoteka, pokušajte ponovno...");
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
            if (Provjera() && hashKriptirano.SequenceEqual(GetFileHash("kriptirani_aes.txt")))
            {
                TxtDekriptiraniAES.Text = DecryptStringFromBytes_Aes(kriptirano, tajniKljuc, iv);
            }
            else
            {
                MessageBox.Show("Došlo je do namjerne promjene sadržaja datoteka, pokušajte ponovno...");
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

        private bool Provjera ()
        {
            bool ispravno = true;

            if (!hashTajniKljuc.SequenceEqual(GetFileHash("tajni_kljuc.txt")))
            {
                ispravno = false;
            }

            if (!hashIv.SequenceEqual(GetFileHash("iv.txt")))
            {
                ispravno = false;
            }
        
            return ispravno;
        }
    }
}
