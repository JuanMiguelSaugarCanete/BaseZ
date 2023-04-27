using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseZ.Interface
{
    public interface IViewController
    {
        void openView(string action,string viewToOpen);
    }
}
