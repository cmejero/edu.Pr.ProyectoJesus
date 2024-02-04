using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ProyectoJesus.Servicios
{
    /// <summary>
    /// Interfaz que declara la opciones para la selección del usuario
    ///  /// <author>CMR-040224</author>
    /// </summary>
    internal interface MenuInterfaz
    {

        /// <summary>
        /// método que muestra el menú de selección al usuario.
        /// <author>CMR-040224</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();

        public string pedirDNI();
    }
}
