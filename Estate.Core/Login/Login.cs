using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows;

namespace Estate.Core.Login
{
   public class Login
    {
       
        Core.IO.InputOutput WriterReader;
        public Login(string appPath)
        {
            WriterReader = new IO.InputOutput(appPath, "Login.txt");
        }
        public int LoginControl(string userName,string Password)
        {
            List<string> userList = new List<string>();

            if (String.IsNullOrWhiteSpace(userName)|| String.IsNullOrWhiteSpace(Password)|| Password.Length<8)
            {
                //Return 0 Giriş Biçimi Doğru deüil
                return 0;
            }
            else
            {
               
                WriterReader.ReadAll(ref userList);
                foreach (var item in userList)
                {
                    if (userName.Trim().ToUpper() == item.Split('|')[0] && Cipher.Encrypt(Password.Trim().ToUpper(),"Kripto")==item.Split('|')[1])
                    {
                        return 1;
                    }
                }
                return -1;
            }
           
        }
    

        public int NewUser(string userName,string password,string eMail)
        {
            //TODO:Email Format Kontrol
            if (String.IsNullOrWhiteSpace(userName) || String.IsNullOrWhiteSpace(password))
            {
                return 0;
            }
            else if (password.Length<8)
            {
                return -1;
            }
            else if (IsValidEmail(eMail)==false)
            {
                return -2;
            }
            else
            {
                WriterReader.Write(userName.Trim().ToUpper() + "|" + Cipher.Encrypt(password.Trim().ToUpper(),"Kripto") + "|" + eMail.Trim().ToUpper());
                return 1;
            }
       
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
