using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2022
{
    public abstract class Persona : IUsuario
    {
        private string nombre;

        public Persona()
        {
        }

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public abstract DateTime CalcularFechaDevolucion(string ubicacionLibro);
        public abstract DateTime CalcularSancion(int diasRetraso);
    }
}
