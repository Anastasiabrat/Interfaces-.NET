using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro
    {
        private String titulo;
        private String autor;
        private String editorial;
        private Boolean nuevo;
        private String rutaImagen;

        public Libro() { }

        public Libro (String t, String a, String e, bool n, String r)
        {
            Titulo = t;
            Autor = a;
            Editorial = e;
            Nuevo = n;
            RutaImagen = r;
    }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public bool Nuevo { get => nuevo; set => nuevo = value; }
        public string RutaImagen { get => rutaImagen; set => rutaImagen = value; }

    }
}
