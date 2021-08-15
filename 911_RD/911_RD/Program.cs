using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _911_RD.Administracion;
using _911_RD.Administracion.Pacientes;
using _911_RD.Administracion.Transporte;
using _911_RD.Administracion.Vehiculo;

namespace _911_RD 
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
            Application.Run(new FrmVentas());

        }




    }
}
