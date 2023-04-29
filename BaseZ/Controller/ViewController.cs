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
using BaseZ.Singleton;

namespace BaseZ.Controller
{
    public class ViewController : IViewController
    {
        public void openView(string action, string viewToOpen,Form actualForm)
        {
           
            
            switch (action) {
                case ViewsConstant.AC_OPEN_VIEW:
                    ActionOpenView actionOpen = new ActionOpenView();
                    actionOpen.run(viewToOpen);
                    break;
            }
            if (actualForm != null)
            {
                actualForm.Close();
            }
        }

        public void backMenuBtn(Form actualForm) {
            ConfigurationSingleton.Instance.BtnBaack = true;
            this.openView(ViewsConstant.AC_OPEN_VIEW, ViewsConstant.AC_BACK_TO_MENU, actualForm);
            ConfigurationSingleton.Instance.BtnBaack = false;
        }
        public void closeApp() {
            if (!ConfigurationSingleton.Instance.BtnBaack)
            {
                //Application.Exit();
            }
        }
    }
}
