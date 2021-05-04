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
        int numri_karaktereve;
        BeaufortCipher AlgoritmiCipher;

        public Form1()
        {
            KomponentaIncializuese_interfaceit();
            Inicializimi_karaktereve_alfabeti();
            AlgoritmiCipher = new BeaufortCipher();       
        }

        private void Inicializimi_karaktereve_alfabeti(){
            karakternumer = new Dictionary<char, int>();
            numerkarakter = new Dictionary<int, char>();
            char[] karakteret_e_lejuara = {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v',
                'w','x','y','z'};
                                             
            numri_karaktereve = karakteret_e_lejuara.Length;

            for (int i = 0; i < numri_karaktereve; i++)
            {
                karakternumer.Add(karakteret_e_lejuara[i], i);
                numerkarakter.Add(i, karakteret_e_lejuara[i]);
            }
        }
        //Kontrollo tekstin nese permban ndonje karakter te palejueshem
        private bool kontrollo_Tekstin(string tekst)        {
            foreach (char i in tekst)
            {
                if (!karakternumer.ContainsKey(i))
                {
                    MessageBox.Show("Nje karakter i palejueshem eshte zbuluar: " + i, "Njoftim", MessageBoxButtons.OK);
                    return false;
                }
            }
            return true;
        }
        //Kontrollo nese hapesira per tekst eshte bosh-CheckIfNotEmpty
        private bool kontrollo_Tekstin_bosh(string tekst){
            if (tekst.Length == 0) {
                MessageBox.Show("Njera nga fushat e tekstit eshte bosh!", "Njoftim", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        //Background color per plaintext
        private void hapesiraperplaintext_ngjyra(object sender, EventArgs e) {
            hapesiraperplaintext.BackColor = System.Drawing.Color.Moccasin;
            hapesirapercelestext.BackColor = System.Drawing.Color.White;
            hapesiraperciphertext.BackColor = System.Drawing.Color.White;   
        }
        //Background color per celes
        private void hapesirapercelestext_ngjyra(object sender, EventArgs e) {
            hapesiraperplaintext.BackColor = System.Drawing.Color.White;
            hapesirapercelestext.BackColor = System.Drawing.Color.Moccasin;
            hapesiraperciphertext.BackColor = System.Drawing.Color.White;           
        }
        //Background color per ciphertext
        private void hapesiraperciphertext_ngjyra(object sender, EventArgs e)    {
        }
        // Butoni i enkriptimit
        private void butonienkriptimit_(object sender, EventArgs e)  {
            if (!kontrollo_Tekstin_bosh(hapesiraperplaintext.Text) || !kontrollo_Tekstin_bosh(hapesirapercelestext.Text))
                return;
            else
                EnkriptimDekriptimTeksti(ref hapesiraperciphertext, hapesiraperplaintext.Text, hapesirapercelestext.Text);
        }
        // Butoni i dekriptimit
        private void butonidekriptimit_(object sender, EventArgs e) {
            if (!kontrollo_Tekstin_bosh(hapesiraperciphertext.Text) || !kontrollo_Tekstin_bosh(hapesirapercelestext.Text))
                return;
            else
                EnkriptimDekriptimTeksti(ref hapesiraperplaintext, hapesiraperciphertext.Text, hapesirapercelestext.Text);
        }
        
        private char EnkriptimiDekriptimiKarakterit(char textLetter, char keyLetter)
        {
            //Algoritmi i enkriptimit dhe dekriptimit jane saktesishte te njejta, C = E (M) = (K - M) mod 26           
            int rez_numrit_karaktereve = karakternumer[keyLetter] - karakternumer[textLetter];// Hapi i parë: (K - M)           
            rez_numrit_karaktereve %= numri_karaktereve;//  Hapi i dytë: mod 26

            // Korrigjimi i modulit (nese eshte negativ)
            if (rez_numrit_karaktereve < 0)
                rez_numrit_karaktereve += numri_karaktereve;

            return numerkarakter[rez_numrit_karaktereve];
        }

        private void EnkriptimDekriptimTeksti(ref TextBox resultTextBox, string textMessage, string keyText)
        {   //nëse vargu përmban karaktere të paligjshme, lëre funksionin
            if (kontrollo_Tekstin(textMessage) == false)
                return;
            string rez_tekstit = "";
            for(int i = 0; i < textMessage.Length; i++){
                rez_tekstit += EnkriptimiDekriptimiKarakterit(textMessage[i], keyText[i % keyText.Length]);
            }
             resultTextBox.Text = rez_tekstit;
        }        
      
        //Butoni i fshirjes se teksti
        private void butonifshirjes_(object sender, EventArgs e) {
            hapesiraperplaintext.Text = "";
            hapesirapercelestext.Text = "";
            hapesiraperciphertext.Text = "";
            AlgoritmiCipher.unmarkAll();
        }
        
        //Butoni i informatave
        private void butoniinformatave_(object sender, EventArgs e){
            AlgoritmiCipher.shfaqdritaren_informatave();
        }
        }



}