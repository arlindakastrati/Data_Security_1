using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace TCP_Klienti
{
    public partial class Client : Form
    {
        Socket clientSocket;
        private static RSACryptoServiceProvider rsaClient = new RSACryptoServiceProvider();
        private static RSACryptoServiceProvider rsaServer = new RSACryptoServiceProvider();   
        X509Certificate2 certifikata = new X509Certificate2();
       
        //RSACryptoServiceProvider objRsa = new RSACryptoServiceProvider();
        public static Socket server;
        static string receivedData;
        private string IP_Address = "";
        private int PortNo = 9000;
        
        private static string KeyServer;
        Socket socket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public Client()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            clientSocket = socket();
            
        }
        private void SendDataToServer(string data)
        {
            server.Send(Encoding.ASCII.GetBytes(data));
        }

        private string ReceiveDataFromServer()
        {
            byte[] data = new byte[512];
            int recv_data = server.Receive(data);
            string stringData = Encoding.ASCII.GetString(data, 0, recv_data);
            byte[] EncryptedData;
            byte[] IV;
            byte[] key;
            string[] stringDataList = stringData.Split('*');
            IV = Convert.FromBase64String(stringDataList[0]);
            key = Convert.FromBase64String(stringDataList[1]);
            EncryptedData = Convert.FromBase64String(stringDataList[2]);
            stringData = des.DecryptTextFromMemory(EncryptedData, key, IV);


            receivedData = stringData;
            return stringData;
        }
        private void SendRequestToSrv(string teksti)
        {
            try
            {
                server.Send(Encoding.ASCII.GetBytes(teksti));
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message.ToString());
            }
        }
         private void Siggnup_Click(object sender, EventArgs e)
         {
           new Register(clientSocket,certifikata).Show();
          }

        //private bool Validate(TextBox textbox, string Errormsg)
        //{
        //   bool textstatus = true;
        //   if (textbox.Text == "")
        //   {
        //      MessageBox.Show("Please write your informations!");
        //      textstatus = false;
        //}
        // else
        //   {
        //MessageBox.Show("You have written your informations!");
         //   }
         //   return textstatus ;
         //}
        //private bool connect;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //bool usernamevalid = Validate(txtUsername, "Write your username!");
            //bool passwordvalid = Validate(txtPassword, "Write your password!");
            
            //if (!connect)
            //    MessageBox.Show("No connection with your Server!");

            
            //else{
                
               new Login(clientSocket,certifikata).Show();

               
            //}
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[512];

            if (txtIP.Text.Trim() != "" && txtPorti.Text.Trim() != "")
            {
                IP_Address = txtIP.Text.Trim();
                PortNo = Convert.ToInt32(txtPorti.Text.Trim());

                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP_Address), PortNo);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    server.Connect(ipep);

                    txtMesazhi.AppendText("You are connected with Server:" + txtIP.Text + " and Port: " + txtPorti.Text + "\n");
                    

                    KeyServer = ReceiveDataFromServer();
                    txtMesazhi.AppendText("\n\n");
                    rsaServer.FromXmlString(KeyServer);
                    txtMesazhi.AppendText("\n\n" + ReceiveDataFromServer());
                    
                }
                catch (SocketException ex)
                {
                    txtMesazhi.AppendText("It is impossible to connect with Server.Please check your IP Address and Port!");
                    txtMesazhi.AppendText("\n" + ex.ToString());
                    //connect = false;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fill IP Address and/or Port first!");
            }
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

