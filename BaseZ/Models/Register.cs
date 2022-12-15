using BaseZ.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseZ.Models
{
    public class Register
    {
        private string _id;
        private string _name;
        private string _email;
        private string _userName;
        private string _url;
        private byte[] _passwordEncrypt;
        private string _passwordDesencrypt;

        public Register()
        {
            
        }
        public Register(string id, string name, string email, string userName, string url,string password)
        {
            _id = id;
            _name = name;
            _email = email;
            _userName = userName;
            _url = url;
            _passwordDesencrypt = password;
        }

        public Register(string name, string email, string userName, string url, string passwordDesencrypt)
        {
            _name = name;
            _email = email;
            _userName = userName;
            _url = url;
            _passwordDesencrypt = passwordDesencrypt;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Url { get => _url; set => _url = value; }

        public byte[] PasswordEncrypt { get => _passwordEncrypt; set => _passwordEncrypt = value; }
        public string PasswordDesencrypt { get => _passwordDesencrypt; set => _passwordDesencrypt = value; }

        public string[] toStringArray { get => new string[] { Name, UserName, Email, Url, PasswordDesencrypt }; }
    }
}
