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
using System.Security.Cryptography.X509Certificates;

namespace TCP_Klienti
{
    public partial class Client : Form
    {
         Socket clientSocket;
        //RSACryptoServiceProvider objRsa = new RSACryptoServiceProvider();
        //DESCryptoServiceProvider objDes = new DESCryptoServiceProvider();
        X509Certificate2 certifikata = new X509Certificate2();
       
        //RSACryptoServiceProvider objRsa = new RSACryptoServiceProvider();
        public static Socket server;
        static string receivedData;
        private string IP_Address = "";
        private int PortNo = 0;
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
         private void Label6_Click(object sender, EventArgs e)
        {
           new Register(clientSocket,certifikata).Show();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //send();
            new Login(clientSocket,certifikata).Show();
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
                    
                    txtMesazhi.AppendText("\n\n" + ReceiveDataFromServer());
                }
                catch (SocketException ex)
                {
                    txtMesazhi.AppendText("It is impossible to connect with Server.Please check your IP Address and Port!");
                    txtMesazhi.AppendText("\n" + ex.ToString());
                    
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fill IP Address and/or Port first!");
            }
        }

        
        
    }
}
