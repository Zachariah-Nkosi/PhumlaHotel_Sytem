using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using phumla_kamnandi_83.presentation;

namespace phumla_kamnandi_83
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePageForm());
            //Application.Run(new MDIMainDashBoardForm());
            //Application.Run(new BookingForm());
        }
    }
}
