using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using edu.PR.ProyectoJesus.Dtos;

namespace edu.PR.ProyectoJesus.Servicios
{
    /// <summary>
    /// <summary>
    /// Interfaz que declara la información que queremos que introduzca de la lista ClienteDtos.
    /// <author>CMR-040224</author>
    /// </summary>
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// método que muestra al usuario la lista que queremos que complete para 
        /// crear y dar de alta un nuevo usuario.
        /// <author>CMR-040224</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCliente(List<UsuarioDtos> listaAntigua);

        /// <summary>
        /// método que sirve para eliminar a un usuario de la lista.
        /// <author>CMR-040224</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void eliminarCliente(List<UsuarioDtos> listaAntigua);

        /// <summary>
        /// Método que se usa para recorrer una lista
        /// <author>CMR-040224</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void recorrerLista(List<UsuarioDtos> listaAntigua);
    }
}
