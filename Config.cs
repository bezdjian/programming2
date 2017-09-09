using System;
using System.Security.Cryptography;
using System.Text;

namespace TRF
{
    public class Config
    {
        // DB
        public string database_user { get; set; }
        public string database_password { get; set; }
        public string database_name{ get; set; }
        public string database_host { get; set; }
        // Admin user
        public string admin_username { get; set; }
        public string admin_fullname { get; set; }
        public string admin_password { get; set; }

        public Config(string dbname, string dbuser, string dbpassword, string database_host, string admin_username, string admin_fullname, string admin_password)
        {
            this.database_name = dbname;
            this.database_password = dbpassword;
            this.database_user = dbuser;
            this.database_host = database_host;
            this.admin_fullname = admin_fullname;
            this.admin_password = admin_password;
            this.admin_username = admin_username;
        }

        // Password encryption method.
        public static string encryption(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data  
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data  
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
    }
}
