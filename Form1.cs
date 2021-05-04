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

namespace BeaufortCipher{
        public partial class Form1 : Form{
            Dictionary<char, int> karakternumer;
            Dictionary<int, char> numerkarakter;
            int numrikaraktereve;

            BeaufortCipher AlgoritmiCipher;

        public Form1()
        {
            KomponentiInicializues();
            InicializimiFjalorit();

            AlgoritmiCipher = new BeaufortCipher();
        
        }

        private void InicializimiFjalorit()
        {
            karakternumer = new Dictionary<char, int>();
            numerkarakter = new Dictionary<int, char>();

            char[] p = {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v',
                'w','x','y','z'};
            char[] LejoKarakteret = p;
                                    
            numrikaraktereve = LejoKarakteret.Length;

            for (int i = 0; i < numrikaraktereve; i++)
            {
                karakternumer.Add(LejoKarakteret[i], i);
                numerkarakter.Add(i, LejoKarakteret[i]);
            }
        }
        private bool KontrolloNeseeshteZbrazet(string tekst)
        {
            if (tekst.Length == 0)
            {
                MessageBox.Show("Një nga fushat e kërkuara të tekstit është bosh!", "Fusha boshe", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        }



}