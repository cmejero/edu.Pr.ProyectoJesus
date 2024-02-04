using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.ProyectoJesus.Dtos
{
    internal class UsuarioDtos
    {
        long id;
        string nombre;
        string apellidos;
        string dni;
        string telefono;

        public UsuarioDtos(string nombre,string dni)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.telefono = telefono;
        }

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public UsuarioDtos() { }
        
    public string ToString()
        {
            string clienteString = "Nombre: " + this.nombre +
                "Apellidos: " + this.apellidos +
                "DNI: " + this.dni +
                "Telefono:" + this.telefono;
               




            return clienteString;
        }
    }

   



}
