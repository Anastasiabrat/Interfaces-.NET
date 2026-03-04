using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA_SistemasDeSeguridad
{
    class Cliente
    {

        private String nombre;
        private String apellidos;
        private String DNI;
        private String direccion;
        private String poblacion;
        private String telefono1;
        private String telefono2;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public string Telefono11 { get => telefono1; set => telefono1 = value; }
        public string Telefono21 { get => telefono2; set => telefono2 = value; }

        public Cliente(string nombre, string apellidos, string dni, string direccion, string poblacion, string telefono1)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.DNI1 = dni;
            this.direccion = direccion;
            this.poblacion = poblacion;
            this.telefono1 = telefono1;
        }

        public Cliente(string nombre, string apellidos, string dni, string direccion, string poblacion, string telefono1, string telefono2)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.DNI1 = dni;
            this.direccion = direccion;
            this.poblacion = poblacion;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
        }

        public Cliente()
        {
        }
    }
}
