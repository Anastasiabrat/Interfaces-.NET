using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionControles
{
    class Cliente
    {
        private String nombre;
        private String apellidos;
        private String telefono;
        private String comentarios;

        public Cliente(string nombre, string apellidos, string telefono, string comentarios)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.comentarios = comentarios;
        }

        public Cliente()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
    }
}
