using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulariosHeredados
{
    internal class Cliente
    {
        public List<Cliente> clientes = new List<Cliente>();

        private String nombre;
        private String apellidos;
        private String ciudad;
        private String email;
        private String comentario;
        public Boolean vip;

        public Cliente() { }

        public Cliente(string nombre, string apellidos, string ciudad, string email, string comentario, bool vip)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Ciudad = ciudad;
            this.Email = email;
            this.Comentario = comentario;
            this.Vip = vip;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Email { get => email; set => email = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public bool Vip { get => vip; set => vip = value; }
    }
}