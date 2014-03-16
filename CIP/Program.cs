using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitys;
namespace CIP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(Utilitys.Utils.debugging)
            {
                UserHandler.User.UseLocalHost = true;
                Application.Run(new AppMain());
            }
            else
            Application.Run(new Splash());
            
        }
    }
}
