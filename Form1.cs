using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrowanie_1
{
    public partial class Form1 : Form
    {
        // Pola do przechowywania klucza i iv
        private byte[] key;
        private byte[] iv;
        public Form1()
        {
            InitializeComponent();
        }



        private void generateButton_Click(object sender, EventArgs e)
        {
            using (SymmetricAlgorithm algorithm = GetSelectedAlgorithm())
            {
                // Generowanie klucza
                algorithm.GenerateKey();
                // Generowanie IV
                algorithm.GenerateIV();

                // Przechowanie klucza i iv
                key = algorithm.Key;
                iv = algorithm.IV;

                // Konwertowanie klucz i IV na stringi w HEX
                string keyHex = BitConverter.ToString(algorithm.Key).Replace("-", "");
                string ivHex = BitConverter.ToString(algorithm.IV).Replace("-", "");

                // Wyświetlanie klucz i IV w textBoxach
                keyBox.Text = keyHex;
                ivBox.Text = ivHex;
            }
        }
        private SymmetricAlgorithm GetSelectedAlgorithm()
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Aes":
                    return Aes.Create();
                case "DES":
                    return DES.Create();
                case "RC2":
                    return RC2.Create();
                case "Rijndael":
                    return Rijndael.Create();
                case "TripleDES":
                    return TripleDES.Create();
                default:
                    throw new ArgumentException("Nieznany algorytm szyfrowania.");
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Aes")
            {
                // Tworzymy obiekt AES     
                using (Aes aes = Aes.Create())
                {
                    byte[] key = HexStringToByteArray(keyBox.Text);
                    byte[] iv = HexStringToByteArray(ivBox.Text);

                    // Ustawiamy klucz i IV
                    aes.Key = key;
                    aes.IV = iv;


                    // Konwertujemy tekst jawny na byte array
                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(asciiBox.Text);

                    // Szyfrujemy tekst jawny
                    byte[] encryptedBytes = aes.CreateEncryptor().TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);

                    // Wyświetlamy zaszyfrowany tekst w postaci ASCII
                    asciiBox.Text = Encoding.ASCII.GetString(encryptedBytes);

                    // Konwertujemy zaszyfrowany tekst na format HEX
                    string encryptedHex = BitConverter.ToString(encryptedBytes).Replace("-", "");

                    // Wyświetlamy zaszyfrowany tekst w postaci HEX
                    hexBox.Text = encryptedHex;
                }               
            }
            else if (comboBox1.SelectedItem.ToString() == "DES")
            {
                using (DES des = DES.Create())
                {
                    des.Key = key;
                    des.IV = iv;

                    // Konwertujemy tekst jawny na byte array
                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(asciiBox.Text);
                    // Szyfrujemy tekst jawny
                    byte[] encryptedBytes = des.CreateEncryptor().TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);
                    // Wyświetlanie zaszyfrowanego tekstu w postaci ASCII
                    asciiBox.Text = Encoding.ASCII.GetString(encryptedBytes);
                    // Konwertowanie zaszyfrowanego tekstu na format HEX
                    string encryptedHex = BitConverter.ToString(encryptedBytes).Replace("-", "");

                    hexBox.Text = encryptedHex;
                }

            }
            else if (comboBox1.SelectedItem.ToString() == "RC2")
            {
                using (RC2 rc2 = RC2.Create())
                {
                    rc2.Key = key;
                    rc2.IV = iv;

                    // Konwertujemy tekst jawny na byte array
                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(asciiBox.Text);
                    // Szyfrujemy tekst jawny
                    byte[] encryptedBytes = rc2.CreateEncryptor().TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);
                    // Wyświetlanie zaszyfrowanego tekstu w postaci ASCII
                    asciiBox.Text = Encoding.ASCII.GetString(encryptedBytes);
                    // Konwertowanie zaszyfrowanego tekstu na format HEX
                    string encryptedHex = BitConverter.ToString(encryptedBytes).Replace("-", "");

                    hexBox.Text = encryptedHex;
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Rijndael")
            {
                using (Rijndael rijndael = Rijndael.Create())
                {
                    rijndael.Key = key;
                    rijndael.IV = iv;

                    // Konwertujemy tekst jawny na byte array
                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(asciiBox.Text);
                    // Szyfrujemy tekst jawny
                    byte[] encryptedBytes = rijndael.CreateEncryptor().TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);
                    // Wyświetlanie zaszyfrowanego tekstu w postaci ASCII
                    asciiBox.Text = Encoding.ASCII.GetString(encryptedBytes);
                    // Konwertowanie zaszyfrowanego tekstu na format HEX
                    string encryptedHex = BitConverter.ToString(encryptedBytes).Replace("-", "");

                    hexBox.Text = encryptedHex;
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "TripleDES")
            {
                using (TripleDES tripleDES = TripleDES.Create())
                {
                    tripleDES.Key = key;
                    tripleDES.IV = iv;

                    // Konwertujemy tekst jawny na byte array
                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(asciiBox.Text);
                    // Szyfrujemy tekst jawny
                    byte[] encryptedBytes = tripleDES.CreateEncryptor().TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);
                    // Wyświetlanie zaszyfrowanego tekstu w postaci ASCII
                    asciiBox.Text = Encoding.ASCII.GetString(encryptedBytes);
                    // Konwertowanie zaszyfrowanego tekstu na format HEX
                    string encryptedHex = BitConverter.ToString(encryptedBytes).Replace("-", "");

                    hexBox.Text = encryptedHex;
                }
            }
            else
            {
                MessageBox.Show("Wybrano niewłaściwy algorytm.");
            }
        }
        private byte[] HexStringToByteArray(string hex)
        {
            int length = hex.Length / 2;
            byte[] bytes = new byte[length];
            for (int i = 0; i < length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Aes")
            {
                using (Aes aes = Aes.Create())
                {

                    // Konwertujemy klucz i IV z HEX na byte array
                    byte[] key = HexStringToByteArray(keyBox.Text);
                    byte[] iv = HexStringToByteArray(ivBox.Text);

                    // Ustawiamy klucz i IV
                    aes.Key = key;
                    aes.IV = iv;

                    // Konwertujemy zaszyfrowany tekst z pola hexBox na byte array
                    byte[] encryptedBytes = HexStringToByteArray(hexBox.Text);

                    // Odszyfrowujemy tekst
                    byte[] decryptedBytes = aes.CreateDecryptor().TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                    // Konwertujemy odszyfrowany tekst na string
                    string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                    // Wyświetlamy odszyfrowany tekst w postaci ASCII
                    asciiBox2.Text = decryptedText;

                    // Wyświetlamy zaszyfrowany tekst z pola hexBox w polu hexBox2 (tak dla zachowania spójności)
                    hexBox2.Text = hexBox.Text;
                }
            } 
            else if (comboBox1.SelectedItem.ToString() == "DES")
            {
                using (DES des = DES.Create())
                {
                    des.Key = key;
                    des.IV = iv;

                    // Konwertujemy zaszyfrowany tekst z pola hexBox na byte Array
                    byte[] encryptedBytes = HexStringToByteArray(hexBox.Text);
                    // Odszyfrowanie tekstu
                    byte[] decryptedBytes = des.CreateDecryptor().TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                    // Konwertujemy odzsyfrowany tekst na string
                    string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                    asciiBox2.Text = decryptedText;
                    hexBox2.Text = hexBox.Text;
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "RC2")
            {
                using (RC2 rc2 = RC2.Create())
                {
                    rc2.Key = key;
                    rc2.IV = iv;

                    // Konwertujemy zaszyfrowany tekst z pola hexBox na byte Array
                    byte[] encryptedBytes = HexStringToByteArray(hexBox.Text);
                    // Odszyfrowanie tekstu
                    byte[] decryptedBytes = rc2.CreateDecryptor().TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                    // Konwertujemy odszyfrowany tekst na string
                    string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                    asciiBox2.Text = decryptedText;
                    hexBox2.Text = hexBox.Text;
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Rijndael")
            {
                using (Rijndael rijndael = Rijndael.Create())
                {
                    rijndael.Key = key;
                    rijndael.IV = iv;

                    // Konwertujemy zaszyfrowany tekst z pola hexBox na byte Array
                    byte[] encryptedBytes = HexStringToByteArray(hexBox.Text);
                    // Odszyfrowanie tekstu
                    byte[] decryptedBytes = rijndael.CreateDecryptor().TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                    // Konwertujemy odszyfrowany tekst na string
                    string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                    asciiBox2.Text = decryptedText;
                    hexBox2.Text = hexBox.Text;
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "TripleDES")
            {
                using (TripleDES tripleDES = TripleDES.Create())
                {
                    tripleDES.Key = key;
                    tripleDES.IV = iv;

                    // Konwertujemy zaszyfrowany tekst z pola hexBox na byte Array
                    byte[] encryptedBytes = HexStringToByteArray(hexBox.Text);
                    // Odszyfrowanie tekstu
                    byte[] decryptedBytes = tripleDES.CreateDecryptor().TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                    // Konwertujemy odszyfrowany tekst na string
                    string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                    asciiBox2.Text = decryptedText;
                    hexBox2.Text = hexBox.Text;
                }
            }
            else
            {
                MessageBox.Show("Wybrano niewłaściwy algorytm.");
            }
        }

        private void encryptTimeButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            encryptButton_Click(sender, e);

            stopwatch.Stop();
            encryptTimeBox.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private void decryptTimeButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            decryptButton_Click(sender, e);

            stopwatch.Stop();
            decryptTimeBox.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() + " ms";
        }
    }
}
