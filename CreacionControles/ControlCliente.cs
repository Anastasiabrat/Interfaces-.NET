using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreacionControles
{
    public partial class ControlCliente : UserControl
    {
        public String ClaveUsuario;

        public string ClaveUsuario1 { get => ClaveUsuario; set => ClaveUsuario = value; }

        // Add these new methods to get the values from textboxes
        public string GetNombre() { return tbNombre.Text; }
        public string GetApellidos() { return tbApellidos.Text; }
        public string GetTelefono() { return tbTelefono.Text; }
        public string GetComentarios() { return tbComentarios.Text; }


        public String getClaveUsuario()
        {
            return ClaveUsuario;
        }

        public void SetDatos(string nombre, string apellidos, string telefono, string comentarios)
        {
            tbNombre.Text = nombre;
            tbApellidos.Text = apellidos;
            tbTelefono.Text = telefono;
            tbComentarios.Text = comentarios;
        }

        public ControlCliente()
        {
            InitializeComponent();
        }
    }
}
