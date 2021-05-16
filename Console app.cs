using System;
using System.Text;


namespace ConsoleApp
{
    class Program
    {
        static char[,] matrix(string keyword)
        {
            char[,] matrica = new char[4, 4];

            StringBuilder letters = new StringBuilder();
            for (int i = 65; i < 65 + 26; i++)
                if ((char)i != 'K')
                    letters.Append((char)i);

            keyword = keyword.ToUpper();
            keyword = keyword.Replace("K", "L");

            for (int i = 0; i < keyword.Length; i++)
                letters.Replace(keyword[i].ToString(), "");
                int k = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (k < keyword.Length)
                    {
                        for (int l = 0; l < k; l++)
                        {
                            if (k < keyword.Length && keyword[l] == keyword[k])
                            {
                                k++;
                                l = -1;
                            }
                        }
                        if (k < keyword.Length)
                        {
                            matrica[i, j] = keyword[k];
                            k++;
                        }
                    }
                    else
                    {
                        matrica[i, j] = letters[0];
                        letters.Remove(0, 1);
                    }
                }
            return matrica;
        }
        static string Encrypt(string plaintext, char[,] matrica)
        {

            StringBuilder sb = new StringBuilder("");
            plaintext = plaintext.Replace("K", "L");
            plaintext = plaintext.Replace(" ", "");
            plaintext = plaintext.ToUpper();

            for (int i = 0; i < plaintext.Length; i++)
            {
                char chA = plaintext[i];
                int X = 0, Y = 0;
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 4; k++)
                        if (matrica[j, k] == chA)
                        {
                            X = j + 1;
                            Y = k + 1;
                        }


                string enc = X.ToString() + Y.ToString();
                sb.Append(enc);
            }

            return sb.ToString();
        }
        static string Decrypt(string ciphertext, char[,] matrica)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                char enc11 = ciphertext[i];
                char enc21 = ciphertext[i + 1];
                int enc1 = int.Parse(enc11.ToString()) - 1;
                int enc2 = int.Parse(enc21.ToString()) - 1;
                char dec = 'z';
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 4; k++)
                    {
                        if (j == enc1 && k == enc2)
                        {
                            dec = matrica[j, k];
                        }

                    }
                sb.Append(dec);
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sheno plaintext-in: ");
            string plaintext = Console.ReadLine();

            Console.WriteLine("Sheno celesin: ");
            string key = Console.ReadLine();


            char[,] matrica = matrix(key);

            //for (int i = 0; i < 5; i++)
            //    for (int j = 0; j < 5; j++)
            //        Console.WriteLine(matrica[i, j]);
            Console.WriteLine("Text-i i enkriptuar");
            string encrypted = Encrypt(plaintext, matrica);
            Console.WriteLine(encrypted + "\n\n");

            Console.WriteLine("Text-i i dekriptuar");
            string decrypted = Decrypt(encrypted, matrica);
            Console.WriteLine(decrypted);

        }

    }
