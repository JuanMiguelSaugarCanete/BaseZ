using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseZ.Models
{
    internal class Register
    {
        private string _id;
        private string _name;
        private string _email;
        private string _userName;
        private string _password;
        private string _url;

        public Register()
        {
            
        }
        public Register(string id, string name, string email, string userName, string password, string url)
        {
            _id = id;
            _name = name;
            _email = email;
            _userName = userName;
            _password = password;
            _url = url;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Url { get => _url; set => _url = value; }
    }
}
