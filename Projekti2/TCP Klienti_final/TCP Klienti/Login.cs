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
        private static RSACryptoServiceProvider rsaServer = new RSACryptoServiceProvider();
        //DESCryptoServiceProvider objDes = new DESCryptoServiceProvider();
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
       
         string DESEncrypt(string data)
        {
            DESCryptoServiceProvider dess = new DESCryptoServiceProvider();

            byte[] EncryptedData = des.EncryptTextToMemory(data, dess.Key, dess.IV);

            byte[] RSAKey = rsa.RSAEncrypt(dess.Key, rsaServer.ExportParameters(false), false);

            return Convert.ToBase64String(dess.IV) + "*" + Convert.ToBase64String(RSAKey) + "*" + Convert.ToBase64String(EncryptedData);
        }
    }
}

