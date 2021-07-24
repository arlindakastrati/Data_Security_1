using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Serveri_TCP_1
{
    class Users
    {
        private static string generateSalt()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(100000, 1000000).ToString();
        }

        public static string generateSaltedHash(string password, string salt)
        {
            string passwordSalt = password + salt;
            SHA1CryptoServiceProvider objHash = new SHA1CryptoServiceProvider();

            byte[] bytePasswordSalt = Encoding.UTF8.GetBytes(passwordSalt);
            byte[] byteSaltedPasswordHash = objHash.ComputeHash(bytePasswordSalt);

            return Convert.ToBase64String(byteSaltedPasswordHash);
        }

        public static void insert(string name, string surname, string username, string password, string invoicetype, string year, string month,  string valueineuros, string valueindollar)
        {
            if (File.Exists("users.xml") == false)
            {
                XmlTextWriter xmlTw = new XmlTextWriter("users.xml", Encoding.UTF8);
                xmlTw.WriteStartElement("users");
                xmlTw.Close();
            }
            XmlDocument objXml = new XmlDocument();
            objXml.Load("users.xml");

            XmlElement rootNode = objXml.DocumentElement;
            XmlElement userNode = objXml.CreateElement("users");
            userNode.SetAttribute("id", (getNumberOfUsers() + 1).ToString());
            XmlElement nameNode = objXml.CreateElement("name");
            XmlElement surnameNode = objXml.CreateElement("surname");
            XmlElement usernameNode = objXml.CreateElement("username");
            XmlElement passwordNode = objXml.CreateElement("password");
            XmlElement saltNode = objXml.CreateElement("salt");
            XmlElement saltedHashNode = objXml.CreateElement("saltedHash");
            XmlElement invoicetypeNode = objXml.CreateElement("invoicetype");
            XmlElement yearNode = objXml.CreateElement("year");
            XmlElement monthNode = objXml.CreateElement("month");
            XmlElement valueineurosNode = objXml.CreateElement("valueineuros");
            XmlElement valueindollarNode = objXml.CreateElement("valueindollar");//shtese


            string salt = generateSalt();

            nameNode.InnerText = name;
            surnameNode.InnerText = surname;
            usernameNode.InnerText = username;
            saltNode.InnerText = salt;
            saltedHashNode.InnerText = generateSaltedHash(password, salt);
            invoicetypeNode.InnerText = invoicetype;
            yearNode.InnerText = year;
            monthNode.InnerText = month;
            valueineurosNode.InnerText = valueineuros;
            valueindollarNode.InnerText = valueindollar;

            passwordNode.AppendChild(saltNode);
            passwordNode.AppendChild(saltedHashNode);
            userNode.AppendChild(nameNode);
            userNode.AppendChild(surnameNode);
            userNode.AppendChild(usernameNode);
            userNode.AppendChild(passwordNode);
            userNode.AppendChild(invoicetypeNode);
            userNode.AppendChild(yearNode);
            userNode.AppendChild(monthNode);
            userNode.AppendChild(valueineurosNode);
            userNode.AppendChild(valueindollarNode);



            rootNode.AppendChild(userNode);

            objXml.Save("users.xml");


        }

        public static double getNumberOfUsers()
        {
            var filename = "users.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var usersFilepath = Path.Combine(currentDirectory, filename);

            try
            {
                XElement users = XElement.Load($"{usersFilepath}");

                IEnumerable<int> numberofusers = from user in users.Descendants("user")
                                                   select (int)user.Attribute("id");
                return numberofusers.Count();
            }
            catch
            {
                return 0;
            }
        }

        public static string getSaltByUsername(string username)
        {
            var filename = "users.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var usersFilepath = Path.Combine(currentDirectory, filename);

            try
            {
                XElement users = XElement.Load($"{usersFilepath}");

                IEnumerable<string> salt = from user in users.Descendants("user")
                                           where user.Element("username").Value.ToString().Equals(username)
                                           select user.Element("password").Element("salt").Value;

                return salt.Single();
            }
            catch
            {
                return null;
            }
        }

        public static bool isUser(string username, string password)
        {
            var filename = "users.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var usersFilepath = Path.Combine(currentDirectory, filename);

            try
            {
                XElement users = XElement.Load($"{usersFilepath}");

                IEnumerable<XElement> passwordInfo = from user in users.Descendants("user")
                                                     where user.Element("username").Value.ToString().Equals(username)
                                                     select user.Element("password");


                string saltPassword = password + getSaltByUsername(username);
                byte[] byteSaltPassword = Encoding.UTF8.GetBytes(saltPassword);

                SHA1CryptoServiceProvider objHash = new SHA1CryptoServiceProvider();

                byte[] byteSaltedHashPassword = objHash.ComputeHash(byteSaltPassword);

                string base64SaltedHashPassword = Convert.ToBase64String(byteSaltedHashPassword);

                if (base64SaltedHashPassword.Equals(passwordInfo.First().Element("saltedHash").Value))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }

        }
        public static XElement getUserInfo(string username)
        {
            var filename = "users.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var usersFilepath = Path.Combine(currentDirectory, filename);

            try
            {
                XElement users = XElement.Load($"{usersFilepath}");
                IEnumerable<XElement> infoUserat = from user in users.Descendants("user")
                                                     where user.Element("username").Value.ToString().Equals(username)
                                                     select user;

                return infoUserat.First();
            }
            catch
            {
                return null;
            }
        }
    }
}
