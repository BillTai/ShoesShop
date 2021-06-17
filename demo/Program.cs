using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace demo
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
            Application.Run(new fLoading());
            //Application.Run(new fBill());
            //Application.Run(new fBillSearch());

            //Application.Run(new fLogin());
            //Application.Run(new fRegister());
            //Application.Run(new fProduct());
            //Application.Run(new fCustomer());
            //Application.Run(new fSize());
            //Application.Run(new fColor());
            //Application.Run(new fStaff());
            //Application.Run(new fProductType());
            //Application.Run(new fStatistical());

        }

    }
}
