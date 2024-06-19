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
            bool separators = separatorInterval > 0;

            int totalLength = maxAlphabets + maxNumbers + maxSpecials;

            List<string> passwords = GeneratePasswords(minAlphabets, maxAlphabets, minNumbers, maxNumbers, minSpecials, maxSpecials, totalLength, numPasswords, separators, separatorInterval);
            
            DisplayPasswords(passwords);
        }

        private void DisplayPasswords(List<string> passwords)
        {
            listBoxPasswords.Items.Clear();
            foreach (var password in passwords)
            {
                listBoxPasswords.Items.Add(password);
            }
        }

        private List<string> GeneratePasswords(int minAlphabetic, int maxAlphabetic, int minNumeric, int maxNumeric, int minSpecial, int maxSpecial, int totalCharacters, int numPasswords, bool separators, int separatorInterval)
        {
            List<string> passwords = new List<string>();

            for (int i = 0; i < numPasswords; i++)
            {
                string password = GeneratePassword(minAlphabetic, maxAlphabetic, minNumeric, maxNumeric, minSpecial, maxSpecial, totalCharacters, separators, separatorInterval);
                passwords.Add(password);
            }

            return passwords;
        }

        private static string GeneratePassword(int minAlphabetic, int maxAlphabetic, int minNumeric, int maxNumeric, int minSpecial, int maxSpecial, int totalCharacters, bool separators, int separatorInterval)
        {
            LFSR lfsr = new LFSR();
            List<char> sequences = lfsr.GetSequences();

            Random random = new Random();
            List<char> passwordChars = new List<char>();

            int alphabeticCount = random.Next(minAlphabetic, maxAlphabetic + 1);
            AddRandomCharacters(passwordChars, sequences, alphabeticCount, 'A', 'Z', 'a', 'z');

            int numericCount = random.Next(minNumeric, maxNumeric + 1);
            AddRandomCharacters(passwordChars, sequences, numericCount, '0', '9');

            int specialCount = random.Next(minSpecial, maxSpecial + 1);
            AddRandomCharacters(passwordChars, sequences, specialCount, '!', '/', ':', '@', '[', '`', '{', '~');

            passwordChars = EnsureCorrectCounts(passwordChars, totalCharacters, alphabeticCount, numericCount, specialCount, random, sequences, minAlphabetic, maxAlphabetic, minNumeric, maxNumeric, minSpecial, maxSpecial);

            passwordChars = Shuffle(passwordChars, random);

            if (separators && separatorInterval > 0)
            {
                for (int i = separatorInterval; i < passwordChars.Count; i += separatorInterval + 1)
                {
                    passwordChars.Insert(i, '-');
                }
            }

            return new string(passwordChars.Take(totalCharacters).ToArray());
        }

        private static void AddRandomCharacters(List<char> passwordChars, List<char> sequences, int count, params char[] ranges)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                char nextChar;
                do
                {
                    nextChar = sequences[random.Next(sequences.Count)];
                } while (!IsCharInRanges(nextChar, ranges));

                passwordChars.Add(nextChar);
            }
        }

        private static bool IsCharInRanges(char c, params char[] ranges)
        {
            for (int i = 0; i < ranges.Length; i += 2)
            {
                if (c >= ranges[i] && c <= ranges[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        private static List<char> EnsureCorrectCounts(List<char> passwordChars, int totalCharacters, int alphabeticCount, int numericCount, int specialCount, Random random, List<char> sequences, int minAlphabetic, int maxAlphabetic, int minNumeric, int maxNumeric, int minSpecial, int maxSpecial)
        {
            while (alphabeticCount > maxAlphabetic)
            {
                passwordChars.Remove(passwordChars.First(char.IsLetter));
                alphabeticCount--;
            }

            while (numericCount > maxNumeric)
            {
                passwordChars.Remove(passwordChars.First(char.IsDigit));
                numericCount--;
            }

            while (specialCount > maxSpecial)
            {
                passwordChars.Remove(passwordChars.First(c => !char.IsLetterOrDigit(c)));
                specialCount--;
            }

            while (passwordChars.Count < totalCharacters)
            {
                char nextChar = sequences[random.Next(sequences.Count)];
                passwordChars.Add(nextChar);
            }

            return passwordChars;
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
