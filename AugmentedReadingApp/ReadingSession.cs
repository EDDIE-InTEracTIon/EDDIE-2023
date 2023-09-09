using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AugmentedReadingApp
{
    static class ReadingSession
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuSettings()); //Descomentar esta linea Para utilizar la ultima interfaz y comentar la siguiente
            //Application.Run(new InteractionCoordinator()); //Descomentar esta linea Para utilizar la interfaz original y comentar la anterior
            
            //Iniciar InteractionCoordinator para la interfaz original o usar MenuSettings para la nueva interfaz
        }
    }
}
