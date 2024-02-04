using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ProyectoJesus.Servicios
{
    /// <summary>
    ///  implementación de MenuInterfaz.
    ///  <author>CMR-040224</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        /// <summary>
        /// método que muestra el menú de selección al usuario.
        /// <author>CMR-040224</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion()
        {

            int opcionIntroducida;

            Console.WriteLine("#####################");
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Alta usuario");           
            Console.WriteLine("2. Eliminar cliente");
            Console.WriteLine("#####################");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;

        }

        public string pedirDNI()
        {
            Console.WriteLine("Indica el DNI del cliente: ");
            string dniCliente = Console.ReadLine();
            return dniCliente;
        }
    }
}
