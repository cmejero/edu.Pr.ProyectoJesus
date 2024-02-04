using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using edu.PR.ProyectoJesus.Dtos;
using System.Xml.Serialization;


namespace edu.PR.ProyectoJesus.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {

        /// <summary>
        /// método que muestra al usuario la lista que queremos que complete para 
        /// crear y dar de alta un nuevo usuario.
        /// <author>CMR-040224</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        /// 
        public void darAltaCliente(List<UsuarioDtos> listaAntigua)
        {
            UsuarioDtos cliente = crearNuevoCLiente();

            listaAntigua.Add(cliente);

        }

        /// <summary>
        /// Método donde creamos un nuevo usuario.
        /// <author>CMR-040224</author>
        /// </summary>
        /// <returns></returns>
        private UsuarioDtos crearNuevoCLiente()
        {
            UsuarioDtos nuevoUsuario = new UsuarioDtos();

            Console.WriteLine("Introduza el id: ");
            nuevoUsuario.Id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduza nombre: ");
            nuevoUsuario.Nombre = Console.ReadLine();

            Console.WriteLine("Introduza apellidos: ");
            nuevoUsuario.Apellidos = Console.ReadLine();

            Console.WriteLine("Introduza DNI: ");
            nuevoUsuario.Dni = Console.ReadLine();

            Console.WriteLine("Introduza número de telefono: ");
            nuevoUsuario.Telefono = Console.ReadLine();

            return nuevoUsuario;

        }
        public void eliminarCliente(List<UsuarioDtos> listaAntigua)
        {
            MenuInterfaz mi = new MenuImplementacion();
            string dniBuscar = mi.pedirDNI();


            int i;
            bool aBorrar = false;
            for (i = 0; i < listaAntigua.Count(); i++)
            {
                if (listaAntigua[i].Dni.Equals(dniBuscar))
                {
                    aBorrar = true;
                    break;
                }
            }
            if (aBorrar)
            {
                listaAntigua.RemoveAt(i);
            }
            else
            {
                Console.WriteLine("El cliente no existe");
            }

        }
        public void recorrerLista(List<UsuarioDtos> listaAntigua)
        {
            foreach(UsuarioDtos usuario in listaAntigua)
            {
                Console.WriteLine(usuario);
            }
        }
    }
}

    
