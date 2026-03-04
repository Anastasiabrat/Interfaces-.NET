using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorEventosPeliculas
{
    class Pelicula
    {
        // Atributos
        private string titulo;
        private string actores;
        private string director;
        private string clasificacion;

        // Constructor
        public Pelicula(string titulo, string actores, string director, string clasificacion)
        {
            this.titulo = titulo;
            this.actores = actores;
            this.director = director;
            this.clasificacion = clasificacion;
        }

        // Getters y Setters
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Actores
        {
            get { return actores; }
            set { actores = value; }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public string Clasificacion
        {
            get { return clasificacion; }
            set { clasificacion = value; }
        }
    }

}
