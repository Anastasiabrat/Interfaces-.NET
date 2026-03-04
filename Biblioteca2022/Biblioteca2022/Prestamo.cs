using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2022
{
    public class Prestamo
    {
        private string persona;
        private string idLibro;
        private string fecha;

        public Prestamo()
        {
        }

        public Prestamo(string persona, string idLibro, string fecha)
        {
            this.Persona = persona;
            this.IdLibro = idLibro;
            this.Fecha = fecha;
        }

        public Prestamo(string persona, string idLibro)
        {
            this.Persona = persona;
            this.IdLibro = idLibro;
        }

        public string Persona { get => persona; set => persona = value; }
        public string IdLibro { get => idLibro; set => idLibro = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
