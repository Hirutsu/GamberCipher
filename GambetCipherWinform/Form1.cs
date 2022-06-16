using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GambetCipherWinform
{
    public partial class Form1 : Form
    {
        Dictionary<char, int> _dictionary = new Dictionary<char, int>()
        {
            { ' ' , 0}, { 'а', 1 }, { 'б', 2 }, { 'в', 3 }, { 'г', 4 }, { 'д', 5 }, { 'е', 6 },
            { 'ё', 7 }, { 'ж', 8 }, { 'з', 9 }, { 'и', 10 }, { 'й', 11}, { 'к', 12}, { 'л', 13}, 
            { 'м', 14}, { 'н', 15}, { 'о', 16}, { 'п', 17}, { 'р', 18}, { 'с', 19},
            { 'т', 20}, { 'у', 21}, { 'ф', 22}, { 'х', 23}, { 'ц', 24}, { 'ч', 25},
            { 'ш', 26}, { 'щ', 27}, { 'ъ', 28}, { 'Ы', 29}, { 'ь', 30}, { 'э', 31},
            { 'ю', 32}, { 'я', 33}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void codeBtn_Click(object sender, EventArgs e)
        {
            List<int> key = new List<int>();
            List<int> codeWords = new List<int>();
            string text = inputTB.Text.ToLower();
            string keyStr = keyInutTB.Text.ToLower();

            for (int i = 0; i < keyStr.Length; i++)
            {
                key.Add(_dictionary[keyStr[i]]);
            }

            int index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (index > keyStr.Length - 1)
                {
                    index = 0;
                }
                codeWords.Add(_dictionary[text[i]] + key[index]);
                index++;
            }

            codeTB.Text = String.Join(" ",codeWords);
        }

        private void unCodeBtn_Click(object sender, EventArgs e)
        {
            List<char> unCodeWords = new List<char>();
            List<int> codeWords = new List<int>();
            List<string> codeWordsStr = new List<string>(codeTB.Text.ToLower().Split());
            
            List<int> key = new List<int>();
            string keyStr = keyInutTB.Text.ToLower();

            for (int i = 0; i < keyStr.Length; i++)
            {
                key.Add(_dictionary[keyStr[i]]);
            }

            int index = 0;

            for (int i = 0; i < codeWordsStr.Count; i++)
            {
                if (index > keyStr.Length - 1)
                {
                    index = 0;
                }
                codeWords.Add(Convert.ToInt32(codeWordsStr[i]) - key[index]);
                index++;
            }

            for (int i = 0; i < codeWords.Count; i++)
            {
                unCodeWords.Add(_dictionary.FirstOrDefault(x => x.Value == codeWords[i]).Key);
            }

            inputTB.Text = String.Join("", unCodeWords);

        }
    }
}
