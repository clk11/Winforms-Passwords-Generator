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
            int numPasswords = (int)numericUpDownNumPasswords.Value;
            int separatorInterval = (int)numericUpDownSeparatorInterval.Value;
            int passwordLength = (int)numericUpDownPasswordLength.Value; 
            bool separators = separatorInterval > 0;

            int totalMinCharacters = minAlphabets + minNumbers + minSpecials;
            int totalMaxCharacters = maxAlphabets + maxNumbers + maxSpecials;

            if (totalMinCharacters > passwordLength)
            {
                MessageBox.Show("Numarul total minim de caractere depaseste lungimea specificata a parolei.");
                return;
            }

            if (totalMaxCharacters < passwordLength)
            {
                MessageBox.Show("Numarul total maxim de caractere este mai mic decât lungimea specificats a parolei.");
                return;
            }

            List<string> passwords = GeneratePasswords(
                minAlphabets,
                maxAlphabets,
                minNumbers,
                maxNumbers,
                minSpecials,
                maxSpecials,
                passwordLength,
                numPasswords,
                separators,
                separatorInterval
            );

            DisplayPasswords(passwords);
        }

        private void DisplayPasswords(List<string> passwords)
        {
            listBoxPasswords.Items.Clear();
            foreach (var password in passwords)
                listBoxPasswords.Items.Add(password);
        }

        private List<string> GeneratePasswords(
            int minAlphabetic,
            int maxAlphabetic,
            int minNumeric,
            int maxNumeric,
            int minSpecial,
            int maxSpecial,
            int totalCharacters,
            int numPasswords,
            bool separators,
            int separatorInterval
        )
        {
            List<string> passwords = new List<string>();

            for (int i = 0; i < numPasswords; i++)
            {
                string password = GeneratePassword(
                    minAlphabetic,
                    maxAlphabetic,
                    minNumeric,
                    maxNumeric,
                    minSpecial,
                    maxSpecial,
                    totalCharacters,
                    separators,
                    separatorInterval
                );
                passwords.Add(password);
            }

            return passwords;
        }

        private string GeneratePassword(
            int minAlphabetic,
            int maxAlphabetic,
            int minNumeric,
            int maxNumeric,
            int minSpecial,
            int maxSpecial,
            int totalCharacters,
            bool separators,
            int separatorInterval
        )
        {
            Random random = new Random();
            List<char> passwordChars = new List<char>();
            List<char> sequences = GetSequences();

            int alphabetCount = random.Next(minAlphabetic, maxAlphabetic + 1);
            int numberCount = random.Next(minNumeric, maxNumeric + 1);
            int specialCount = random.Next(minSpecial, maxSpecial + 1);

            while (passwordChars.Count < alphabetCount)
            {
                char c = sequences[random.Next(sequences.Count)];
                if (char.IsLetter(c))
                    passwordChars.Add(c);
            }

            while (passwordChars.Count < alphabetCount + numberCount)
            {
                char c = sequences[random.Next(sequences.Count)];
                if (char.IsDigit(c))
                    passwordChars.Add(c);
            }

            while (passwordChars.Count < alphabetCount + numberCount + specialCount)
            {
                char c = sequences[random.Next(sequences.Count)];
                if (!char.IsLetterOrDigit(c))
                    passwordChars.Add(c);
            }

            while (passwordChars.Count > alphabetCount + numberCount + specialCount)
            {
                passwordChars.RemoveAt(passwordChars.Count - 1);
            }

            while (passwordChars.Count < totalCharacters)
            {
                char nextChar = sequences[random.Next(sequences.Count)];
                passwordChars.Add(nextChar);
            }

            passwordChars = Shuffle(passwordChars, random);

            if (separators)
            {
                for (int i = separatorInterval; i < passwordChars.Count; i += separatorInterval + 1)
                {
                    passwordChars.Insert(i, '-');
                }
            }

            return new string(passwordChars.ToArray());
        }

        private List<char> GetSequences()
        {
            LFSR lfsr = new LFSR();
            return lfsr.GetSequences();
        }

        private static List<char> Shuffle(List<char> list, Random random)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                (list[n], list[k]) = (list[k], list[n]);
            }
            return list;
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
