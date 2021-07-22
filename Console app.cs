using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class BeaufortCipher
    {
        //static void Main(string[] args)
        public static void Main()
        {
            Console.WriteLine("BeaufortCipher");
            Console.WriteLine();


            Console.WriteLine("Plaintext: ");
            string plaintext = Console.ReadLine();
            Console.WriteLine();

            List<char> alfabeti =
                Enumerable.Range('a', 'z' - 'a' + 1)
                .Select(x => (char)x).ToList();

            char[][] karakteret = new char['z' - 'a' + 1][];
            for (int i = 0; i < karakteret.Length; i++)
            {
                karakteret[i] = alfabeti.ToArray();
                var first = alfabeti.First();
                alfabeti.Remove(first);
                alfabeti.Insert(alfabeti.Count, first);
            }

            Console.WriteLine("Celesi:");
            string keytext = Console.ReadLine();

            Console.WriteLine();

            string cipherText = Enkriptimi(plaintext, karakteret, keytext);
            Console.WriteLine("Teksti i enkriptuar: {0}", cipherText);

            string decipherText = Dekriptimi(cipherText, karakteret, keytext);
            Console.WriteLine("Teksti i dekriptuar: {0}", decipherText);

            Console.ReadKey();
           
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
        private static string Dekriptimi(string cipherText, char[][] karakteret, string keytext)
        {
            string rez = string.Empty;

            rez = Enkriptimi(cipherText, karakteret, keytext);

            return rez;
        }
    }
}

