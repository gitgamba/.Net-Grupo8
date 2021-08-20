using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Academia
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
            // Application.Run(new Windows.Main.Login());
            Application.Run(new Windows.FormMain());
            //Application.Run(new Usuarios());
        }
    }
}
