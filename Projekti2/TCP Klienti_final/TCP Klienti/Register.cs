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
    public partial class Register : Form
    {
        X509Certificate2 certifikata;
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        DESCryptoServiceProvider des = new DESCryptoServiceProvider();
        Socket clientSocket;

        public Register(Socket socket, X509Certificate2 certificate2)
        {
            InitializeComponent();
            clientSocket = socket;
            certifikata = certificate2;
        }



        private void Register_Load(object sender, EventArgs e)
        {

        }
        
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Your information have been saved. Go to Login!");
            this.Close();
        }
        private void send()
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string invoicetypee = txtFatura.Text;
            string year = txtViti.Text;
            string email = txtEmail.Text;
            string month = txtMuaji.Text;
            string valueineuros = txtEuro.Text;
            string valueindollars = txtDollar.Text;

            string msg = name + "." + surname + "." + username + "." + password + "." + invoicetypee + "." + year + "." + email + "." + month + "." + valueineuros + "." + valueindollars ;
            msg = DESEncrypt(msg);
            byte[] data = Encoding.Default.GetBytes(msg);
            clientSocket.Send(data, 0, data.Length, 0);

        }

        string DESEncrypt(string data)
        {
            des.GenerateKey();
            des.GenerateIV();
            des.Padding = PaddingMode.Zeros;
            des.Mode = CipherMode.CBC;
            string key = Encoding.Default.GetString(des.Key);
            string IV = Encoding.Default.GetString(des.IV);


            ///??????
            rsa = (RSACryptoServiceProvider)certifikata.PublicKey.Key;
            //?????????
            
            
            byte[] byteKey = rsa.Encrypt(des.Key, true);
            string encryptedKey = Convert.ToBase64String(byteKey);

            byte[] bytePlaintexti = Encoding.ASCII.GetBytes(data);


            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(bytePlaintexti, 0, bytePlaintexti.Length);
            cs.Close();

            byte[] byteCiphertexti = ms.ToArray();

            return IV + "*" + encryptedKey + "*" + Convert.ToBase64String(byteCiphertexti);

        }
    }
}

