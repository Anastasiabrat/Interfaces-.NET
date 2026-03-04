using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca2022
{
    public partial class FormPrincipal : Form
    {
        public static List<Usuario> Usuarios;
        public static List<Libro> Libros;
        public static List<Prestamo> Prestamos;
        public static List<Devolucion> Devoluciones;
        public FormPrincipal()
        {
            InitializeComponent();
            Usuarios = new List<Usuario>();
            Libros = new List<Libro>();
            Prestamos = new List<Prestamo>();
            Devoluciones = new List<Devolucion>();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //LECTURA DE USUARIOS
            string[] linesUsuarios = System.IO.File.ReadAllLines("usuarios.txt", Encoding.UTF8);
            // Leer y crear objetos 
            foreach (var line in linesUsuarios)
            {
                var partes = line.Split(',');
                if (partes.Length > 1)
                {
                    string[] tipoYNombre = partes[0].Trim().Split(new[] { ' ' }, 2);
                    if (tipoYNombre.Length == 2)
                    {
                        string tipo = tipoYNombre[0].Trim();
                        string nombre = tipoYNombre[1].Trim();
                        string dedicacion = partes[1].Trim();
                        string fecha = "";

                        // Manejo de la fecha sin operador ternario
                        if (partes.Length > 2)
                        {
                            fecha = partes[2].Trim();
                        }

                        // Crear y añadir el usuario a la lista
                        Usuario usuario = new Usuario(tipo, nombre, dedicacion, fecha);
                        Usuarios.Add(usuario);
                    }
                }
            }

            //LECTURA DE LIBROS
            string[] linesLibros = System.IO.File.ReadAllLines("libros.txt", Encoding.UTF8);

            // Leer cada línea y crear objetos Libro
            foreach (var line in linesLibros)
            {
                var partes = line.Split(',');
                if (partes.Length == 2)
                {
                    string[] ubicacionYTitulo = partes[0].Trim().Split(new[] { ' ' }, 2);
                    if (ubicacionYTitulo.Length == 2)
                    {
                        string ubicacion = ubicacionYTitulo[0].Trim();
                        string titulo = ubicacionYTitulo[1].Trim();
                        string id = partes[1].Trim();

                        // Crear y añadir el libro a la lista
                        Libro libro = new Libro(ubicacion, titulo, id);
                        Libros.Add(libro);
                    }
                }
            }

            //LECTURA DE PRESTAMOS Y DEVOLUCIONES
            // LECTURA DEL ARCHIVO
            string[] lines = System.IO.File.ReadAllLines("transacciones.txt", Encoding.UTF8);

            foreach (var line in lines)
            {
                // Ignorar líneas de fecha
                if (line.StartsWith("fecha")) continue;

                // Procesar línea de préstamo
                if (line.StartsWith("prestamo"))
                {
                    var partes = line.Substring(9).Split(',');
                    if (partes.Length >= 2)
                    {
                        string persona = partes[0].Trim();
                        string idLibro = partes[1].Trim();
                        string fecha = partes.Length == 3 ? partes[2].Trim('#', ' ') : string.Empty;

                        Prestamo prestamo = new Prestamo(persona, idLibro, fecha);
                        Prestamos.Add(prestamo);
                    }
                }
                // Procesar línea de devolución
                else if (line.StartsWith("devolucion"))
                {
                    string idLibro = line.Substring(11).Trim();
                    Devolucion devolucion = new Devolucion(idLibro);
                    Devoluciones.Add(devolucion);
                }
            }
        }

        //Manejar el ToolStripMenu
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Alta")
            {
                FormAlta f = new FormAlta();
                f.WindowState = FormWindowState.Maximized;
                f.MdiParent = this;
                f.Show();
            }
            if (e.ClickedItem.Text == "Modificacion")
            {
                FormModificacion f = new FormModificacion();
                f.WindowState = FormWindowState.Maximized;
                f.MdiParent = this;
                f.Show();
            }
            if (e.ClickedItem.Text == "Borrado")
            {
                FormBorrado f = new FormBorrado();
                f.WindowState = FormWindowState.Maximized;
                f.MdiParent = this;
                f.Show();
            }
            if (e.ClickedItem.Text == "Listado")
            {
                FormListado f = new FormListado();
                f.WindowState = FormWindowState.Maximized;
                f.MdiParent = this;
                f.Show();
            }
        }

        //SOBREESCRITURA 
        public static void GuardarDatos()
        {
            GuardarLibros();
            GuardarTransacciones();
            GuardarUsuarios();
            MessageBox.Show("Datos guardados correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void GuardarLibros()
        {
            using (StreamWriter sw = new StreamWriter("libros.txt"))
            {
                foreach (var libro in FormPrincipal.Libros)
                {
                    sw.WriteLine($"{libro.Ubicacion} {libro.Titulo}, {libro.Identificador}");
                }
            }
        }

        public static void GuardarTransacciones()
        {
            DateTime fecha = new DateTime.Now.Date;
            using (StreamWriter sw = new StreamWriter("transacciones.txt"))
            {
                sw.WriteLine($"prestamo {}");
                // Escribir préstamos
                foreach (var prestamo in FormPrincipal.Prestamos)
                {
                    sw.WriteLine($"prestamo {prestamo.Persona}, {prestamo.IdLibro}, #{prestamo.Fecha}#");
                }

                // Escribir devoluciones
                foreach (var devolucion in FormPrincipal.Devoluciones)
                {
                    sw.WriteLine($"devolucion {devolucion.Id}");
                }
            }
        }

        public static void GuardarUsuarios()
        {
            using (StreamWriter sw = new StreamWriter("usuarios.txt"))
            {
                foreach (var usuario in FormPrincipal.Usuarios)
                {
                    if (!string.IsNullOrEmpty(usuario.FechaSancion))
                    {
                        sw.WriteLine($"{usuario.Tipo} {usuario.Nombre}, {usuario.Departamento}, #{usuario.FechaSancion}#");
                    }
                    else
                    {
                        sw.WriteLine($"{usuario.Tipo} {usuario.Nombre}, {usuario.Departamento}");
                    }
                }
            }
            MessageBox.Show("Usuarios guardados correctamente.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarDatos();
        }
    }
}
