using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ssi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int minAlphabets = (int)numericUpDownMinAlphabets.Value;
            int maxAlphabets = (int)numericUpDownMaxAlphabets.Value;
            int minNumbers = (int)numericUpDownMinNumbers.Value;
            int maxNumbers = (int)numericUpDownMaxNumbers.Value;
            int minSpecials = (int)numericUpDownMinSpecials.Value;
            int maxSpecials = (int)numericUpDownMaxSpecials.Value;
            int totalLength = (int)numericUpDownTotalLength.Value;
            int numPasswords = (int)numericUpDownNumPasswords.Value;
            int separatorInterval = (int)numericUpDownSeparatorInterval.Value;

            List<string> passwords = GeneratePasswords(minAlphabets, maxAlphabets, minNumbers, maxNumbers, minSpecials, maxSpecials, totalLength, numPasswords, separatorInterval);
            SavePasswords(passwords);
            DisplayPasswords(passwords);
        }

        private List<string> GeneratePasswords(int minAlphabets, int maxAlphabets, int minNumbers, int maxNumbers, int minSpecials, int maxSpecials, int totalLength, int numPasswords, int separatorInterval)
        {
            List<string> passwords = new List<string>();

            for (int i = 0; i < numPasswords; i++)
            {
                string password = GeneratePassword(minAlphabets, maxAlphabets, minNumbers, maxNumbers, minSpecials, maxSpecials, totalLength, separatorInterval);
                passwords.Add(password);
            }

            return passwords;
        }

        private string GeneratePassword(int minAlphabets, int maxAlphabets, int minNumbers, int maxNumbers, int minSpecials, int maxSpecials, int totalLength, int separatorInterval)
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string specials = "!@#$%^&*()_-+=<>?";

            for (int i = 0; i < totalLength; i++)
            {
                char nextChar;
                if (password.Length < minAlphabets)
                {
                    nextChar = alphabets[random.Next(alphabets.Length)];
                }
                else if (password.Length < minAlphabets + minNumbers)
                {
                    nextChar = numbers[random.Next(numbers.Length)];
                }
                else if (password.Length < minAlphabets + minNumbers + minSpecials)
                {
                    nextChar = specials[random.Next(specials.Length)];
                }
                else
                {
                    int choice = random.Next(3);
                    if (choice == 0)
                    {
                        nextChar = alphabets[random.Next(alphabets.Length)];
                    }
                    else if (choice == 1)
                    {
                        nextChar = numbers[random.Next(numbers.Length)];
                    }
                    else
                    {
                        nextChar = specials[random.Next(specials.Length)];
                    }
                }
                password.Append(nextChar);

                if (separatorInterval > 0 && (i + 1) % separatorInterval == 0 && i != totalLength - 1)
                {
                    password.Append('-');
                }
            }

            return password.ToString();
        }

        private void SavePasswords(List<string> passwords)
        {
            string fileName = DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var password in passwords)
                {
                    string encryptedPassword = EncryptPassword(password, fileName);
                    writer.WriteLine(encryptedPassword);
                }
            }
        }

        private string EncryptPassword(string password, string key)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(data);
        }

        private void DisplayPasswords(List<string> passwords)
        {
            listBoxPasswords.Items.Clear();
            foreach (var password in passwords)
            {
                listBoxPasswords.Items.Add(password);
            }
        }
        private void listBoxPasswords_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxPasswords.SelectedItem != null)
            {
                string selectedText = listBoxPasswords.SelectedItem.ToString();

                Clipboard.SetText(selectedText);
                MessageBox.Show("Copiata !");
            }
        }
    }
}
