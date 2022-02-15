using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class Program
    {
        public static void Main()
        {
            run();
        }

        private static void run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin logInForm = new FormLogin();
            Application.Run(logInForm);
        }
    }
}
