using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseZ.Action;
using BaseZ.Constants;
using BaseZ.Interface;
using BaseZ.Models;

namespace BaseZ.Controller
{
    public class ViewController : IViewController
    {
        public void openView(string action, string viewToOpen)
        {
            switch (action) {
                case ViewsConstant.AC_OPEN_VIEW:
                    ActionOpenView actionOpen = new ActionOpenView();
                    actionOpen.run(viewToOpen);
                    break;
            }
        }
    }
}
