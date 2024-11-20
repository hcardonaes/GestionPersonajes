// Archivo: Program.cs
using System;
using System.Windows.Forms;

namespace HistoriaMedieval
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
            Application.Run(new MainForm()); // Asegúrate de que el nombre del formulario sea MainForm
        }
    }
}

