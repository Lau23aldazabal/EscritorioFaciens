using EscritorioFaciens.FormsUsuario;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Windows.Forms;

namespace EscritorioFaciens
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            login.Show();
            Application.Run();

        }
    }
}
