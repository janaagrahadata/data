using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAuth
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
		/// More description to be added here
		/// More description to be added here
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmADAuth());
        }
    }
}
