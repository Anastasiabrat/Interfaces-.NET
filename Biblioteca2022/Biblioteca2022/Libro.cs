using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2022
{
    public class Libro
    {
        private string ubicacion;
        private string titulo;
        private string identificador;

        public Libro()
        {
        }

        public Libro(string ubicacion, string titulo, string identificador)
        {
            this.Ubicacion = ubicacion;
            this.Titulo = titulo;
            this.Identificador = identificador;
        }

        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Identificador { get => identificador; set => identificador = value; }
    }
}
