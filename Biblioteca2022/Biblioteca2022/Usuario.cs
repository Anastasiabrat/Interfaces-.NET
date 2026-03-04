using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2022
{
    public class Usuario : Persona
    {
        private string tipo;
        private string departamento;
        private string fechaSancion;

        public Usuario()
        {
        }

        public Usuario(string tipo, string nombre, string departamento, string fechaSancion) : base(nombre)
        {
            this.Tipo = tipo;
            this.Departamento = departamento;
            this.FechaSancion = fechaSancion;
        }

        public Usuario(string tipo, string nombre, string departamento) : base(nombre)
        {
            this.Tipo = tipo;
            this.Departamento = departamento;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public String FechaSancion { get => fechaSancion; set => fechaSancion = value; }

        public override DateTime CalcularFechaDevolucion(string ubicacionLibro)
        {
            int dias = 0;

            switch (Tipo.ToLower())
            {
                case "alumno":
                    dias = ubicacionLibro.ToLower() == "sala" ? 10 : 15;
                    break;
                case "pas":
                    dias = 15;
                    break;
                case "profesor":
                    dias = ubicacionLibro.ToLower() == "sala" ? 30 : 45;
                    break;
                default:
                    throw new ArgumentException("Tipo de usuario no válido");
            }

            return DateTime.Now.AddDays(dias);
        }

        public override DateTime CalcularSancion(int diasRetraso)
        {
            int diasSancion = 0;

            switch (Tipo.ToLower())
            {
                case "alumno":
                    diasSancion = diasRetraso * 7;
                    break;
                case "pas":
                    diasSancion = diasRetraso * 3;
                    break;
                case "profesor":
                    diasSancion = diasRetraso * 2;
                    break;
                default:
                    throw new ArgumentException("Tipo de usuario no válido");
            }

            return DateTime.Now.AddDays(diasSancion);
        }

        public bool EstaSancionado()
        {
            try
            {
                DateTime fecha = ObtenerFechaSancion();
                return DateTime.Now < fecha;
            }
            catch (FormatException)
            {
                // Manejar errores si la fecha no está en el formato correcto
                return false;
            }
        }
        public DateTime ObtenerFechaSancion()
        {
            if (DateTime.TryParse(fechaSancion, out DateTime fecha))
            {
                return fecha;
            }
            else
            {
                throw new FormatException("La fecha de sanción no tiene un formato válido.");
            }
        }
    }
}

