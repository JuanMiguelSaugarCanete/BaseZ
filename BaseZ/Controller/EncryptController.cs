using BaseZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseZ.Controller
{
    public class EncryptController
    {
        public static List<Register> deletePasswordEncrypt(List<Register> registers) {
            registers.ForEach(r => EncryptController.removePassword(r));
            return registers;
        }

        public static Register removePassword(Register register) {
            register.PasswordDesencrypt = "";
            return register;
        }

        public static List<Register> DecryptPasswordDatabase(List<Register> registers) { 
            Encrytp encrytp = new Encrytp();
            registers.ForEach(r => encrytp.DecryptPassword(r));
            return registers;

        }
    }
}
