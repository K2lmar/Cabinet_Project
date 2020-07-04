using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Project
{
    static class Program
    {
        public static Cabinet_ProjectEntities2 wftDb = new Cabinet_ProjectEntities2();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAuthorization());
        }
    }
}
