using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class BeaufortCipher
    {
        //static void Main(string[] args)
        public static void Main()
        {
           
        }

        private static string TextSize(int length, string keytext)
        {
            string rez = keytext;

            int i = 0;
            while (rez.Length < length)
            {
                rez += keytext[i++];

                if (i >= keytext.Length)
                {
                    i = 0;
                }
            }

            return rez;
        }
        private static int IndexOf(char[] array, char toFind)
        {
            int rez = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == toFind)
                {
                    rez = i;
                    break;
                }
            }

            return rez;
        }

        private static string Enkriptimi(string clearText, char[][] karakteret, string keyword)
        {
            string result = string.Empty;

            keyword = TextSize(clearText.Length, keyword);

            for (int i = 0; i < clearText.Length; i++)
            {
                int row = keyword[i] - 'a';
                char charToCipher = clearText[i];

                int idx = IndexOf(karakteret[row], charToCipher);

                if (idx == 0)
                {
                    idx = karakteret[row].Length;
                }

                idx = karakteret[row].Length - idx;

                result += karakteret[0][idx];
            }

            return result;
        }
    }
}

