using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Klienti
{
    public class rsa
    {
        
        internal static RSAParameters ExportParameters(bool v)
        {
            throw new NotImplementedException();
        }

        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    rsa.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = rsa.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);

                return null;
            }

        }
        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    rsa.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = rsa.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                MessageBox.Show(e.ToString());

                return null;
            }

        }
    }
}