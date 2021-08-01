using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BeaufortCipher 
{
    public class BeaufortCipher 
    {
        //Dritarja e udhezimeve-informatave
        public void shfaqdritaren_informatave(){
            String infoText = "Beaufort Cipher e krijuar nga Francis Beaufort është një shifrim zëvendësimi e ngjashme me Vigenere"+
                " Cipher por me një mekanizem më të modifikuar. Është një sistem kriptografik përmes të cilit mund të bëhet enkriptimi dhe dekriptimi i karaktereve ose teksti.\n\n"+
                "Për shembull, nëse donit të enkriptoni karakterin e një teksti të thjeshtë 'e' me celesin 'l', hapat do të ishin:\n"+
                "1.Gjeni kolonën me karakterin 'e' në krye,\n"+
                "2.Vazhdoni poshtë nëpër atë kolonë për të gjetur çelësin 'l',\n"+
                "3.Vazhdoni në skajin e majtë të tabeles për të gjetur shkronjën e tekstit të koduar ('H' në këtë rast).\n\n"+
                "Beaufort Cipher është shifrim reciprok që nënkupton se algoritmi i enkriptimit dhe dekriptimit është i njëjtë.\n\n"+
                "Beaufort Cipher mund të përshkruhet edhe në formën algjebrike:\n"+
                "M=M1,M2,M3,... -karakteret e plaintextit\n"+
                "C=C1,C2,C3,....,CN-karakteret e ciphertextit\n"+
                "K=K1,K2,K3,....,KN-karakteret e celesit\n\n"+
                "E-Enkriptimi i Beuafort Cipher\n"+
                "Ci=Ek(Mi)=(Ki-Mi) mod 26\n\n"+
                "D-Dekriptimi i Beaufort Cipher\n"+
                "Mi=Dk(Ci)=(Ki-Ci) mod 26\n\n"+
                "Pasi lexuat kerkesat,shtyp OK per te perfunduar.\n"
                ;
            MessageBox.Show(infoText, "Informacionet", MessageBoxButtons.OK);
        }

     
       

      
    }
}
