using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WordfuedHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            String letters = tbInputLetter.Text;


            if (letters.Length > 0)
            {
                char[] userChars = transformUserInput(letters);
                List<string> wordsFound = analyzeLetters(userChars);
                printWords(wordsFound);
            }
            else
            {
                MessageBox.Show("Please enter a word");
            }
        }
        
       private char[] transformUserInput(String letters)
        {
            //return letters.ToCharArray();

            char[] chars = { 'f', 'i', 'k', 'x', '*' };

            return chars;
        }

        private List<string> analyzeLetters(char[] userChars)
        {
            String[] words = new String[] { "fikss", "fisk", "fik", "ifx", "fix", "fick" };
            List<string> wordList = new List<string>();

            foreach(String word in words)
            {
                bool isValid = true;
                char[] charWord = word.ToCharArray();

                foreach(char character in charWord)
                {
                    if (!userChars.Contains(character))
                    {
                        
                        isValid = false;

                        //if (userChars.Contains('*')) isValid = true;
                    }
                }

                if (isValid) wordList.Add(word);
            }

            return wordList;
        }

        private void printWords(List<string> wordList)
        {
            foreach (String word in wordList)
            {
                Console.WriteLine(word);
            }

        }
    }
}
