using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseZ.Constants;
using BaseZ.Interface;
using BaseZ.Singleton;
using BaseZ.Views;
using BaseZ.Views.CRUDRegister;

namespace BaseZ.Action
{
    public class ActionOpenView : IActionView
    {
        public void run(string viewToOpen)
        {
            switch (viewToOpen)
            {
                case ViewsConstant.AC_OPEN_VIEW_OPEN_DB:
                    OpenDatabase openDB = new OpenDatabase();
                    ConfigurationSingleton.Instance.MenuForm.Hide();
                    openDB.Show();
                    break;
                case ViewsConstant.AC_OPEN_VIEW_CREATE_DB:
                    CreateDatabaseMenu createDB = new CreateDatabaseMenu();
                    ConfigurationSingleton.Instance.MenuForm.Hide();
                    createDB.Show();
                    break;
                case ViewsConstant.AC_OPEN_VIEW_REGISTER:
                    ViewRegisters viewsRegisters = new ViewRegisters();
                    viewsRegisters.Show();
                    break;
                case ViewsConstant.AC_BACK_TO_MENU:
                    ConfigurationSingleton.Instance.MenuForm.Show();
                    break;
                case ViewsConstant.AC_OPEN_VIEW_CREATE_REGISTER:
                    new CreateRegister().Show();
                    break;
            }
        }

    }

    
}
