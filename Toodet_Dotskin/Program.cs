using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toodet_Dotskin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Kvitung kvitung = new Kvitung("Название товара", 100.50, "C:\\Users\\opilane\\Source\\Repos\\Toodet-AB\\Toodet_Dotskin\\arved\\");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Registreerimine());

        }
    }
}
