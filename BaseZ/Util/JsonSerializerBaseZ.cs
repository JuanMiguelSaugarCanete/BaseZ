using BaseZ.Controller;
using BaseZ.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseZ.Util
{
    internal class JsonSerializerBaseZ
    {
        public static string SerializeRegisters(List<Register> _registers) {
            return JsonConvert.SerializeObject(EncryptController.deletePasswordEncrypt(_registers), Formatting.Indented);
        }
        

        public static List<Register> DeserializeRegister(string jsonString) {            
            return EncryptController.DecryptPasswordDatabase(JsonConvert.DeserializeObject<List<Register>>(jsonString));        
        }
       
    }
}
