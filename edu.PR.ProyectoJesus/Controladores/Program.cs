
using edu.PR.ProyectoJesus.Dtos;
using edu.PR.ProyectoJesus.Servicios;
using System.Collections.Generic;

namespace edu.PR.ProyectoJesus.Controladores
{
    /// <summary>
    /// Clase principal de la aplicaión.
    /// <author>CMR-040224</author>
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Método main de la aplicación, es el núcleo procedimental.
        /// <author>CMR-040224</author>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();
            List<UsuarioDtos> listaUsuario = new List<UsuarioDtos>();

            bool cerrarMenu = false;

            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("has indicado añadir usuario");
                        oi.darAltaCliente(listaUsuario);
                        oi.recorrerLista(listaUsuario);
                        break;

                    case 2:
                        Console.WriteLine("has indicado eliminar usuario"); 
                        oi.eliminarCliente(listaUsuario);
                        oi.recorrerLista(listaUsuario);
                        break;                   

                    default:
                        Console.WriteLine("[INFO] - Esta opción no coincide con ninguna");
                        break;
                }
            }
        }
    }
}
