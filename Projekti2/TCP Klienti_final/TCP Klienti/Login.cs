using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace TCP_Klienti
{
    public partial class Login : Form
    {
        X509Certificate2 certifikata;
        RSACryptoServiceProvider objRsa = new RSACryptoServiceProvider();
        DESCryptoServiceProvider objDes = new DESCryptoServiceProvider();
        Socket clientSocket;

        public Login(Socket socket, X509Certificate2 certificate2)
        {
            InitializeComponent();
            clientSocket = socket;
            certifikata = certificate2;
        }

         private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            //send();
            MessageBox.Show("Do you want to log out?");
            this.Close(); 
            MessageBox.Show("You have been logout!");
            Application.Exit();
        }
        private string encrypt(string plaintext)
        {
            objDes.GenerateKey();
            objDes.GenerateIV();
            objDes.Padding = PaddingMode.Zeros;
            objDes.Mode = CipherMode.CBC;
            string key = Encoding.Default.GetString(objDes.Key);
            string IV = Encoding.Default.GetString(objDes.IV);


            ///??????
            objRsa = (RSACryptoServiceProvider)certifikata.PublicKey.Key;
            //?????????
            
            
            byte[] byteKey = objRsa.Encrypt(objDes.Key, true);
            string encryptedKey = Convert.ToBase64String(byteKey);

            byte[] bytePlaintexti = Encoding.UTF8.GetBytes(plaintext);


            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, objDes.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(bytePlaintexti, 0, bytePlaintexti.Length);
            cs.Close();

            byte[] byteCiphertexti = ms.ToArray();

            return IV + "." + encryptedKey + "." + Convert.ToBase64String(byteCiphertexti);

        }
    }
}
