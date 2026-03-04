using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca2022
{
    public partial class FormAlta : Form
    {
        public FormAlta()
        {
            InitializeComponent();
        }

        private void Rbtb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                if (rb.Name.Equals("RbtnUsuario"))
                {
                    Txt2.Visible = true; Txt3.Visible = true;
                    Lbl2.Text = "Tipo"; Lbl1.Text = "Nombre"; Lbl3.Text = "Departamento";
                    Lbl1.Visible = true; Lbl2.Visible = true; Lbl3.Visible = true;
                    btnRestablecer_Click(sender, e);
                }
                else if (rb.Name.Equals("RbtnLibro"))
                {
                    Txt2.Visible = true; Txt3.Visible = true;
                    Lbl3.Text = "Ubicacion"; Lbl2.Text = "Titulo"; Lbl1.Text = "Identificador";
                    Lbl1.Visible = true; Lbl2.Visible = true; Lbl3.Visible = true;
                    btnRestablecer_Click(sender, e);
                }
                else if (rb.Name.Equals("RbtnPrestamo"))
                {
                    Txt2.Visible = true; Txt3.Visible = false;
                    Lbl1.Text = "Usuario"; Lbl2.Text = "ID Libro";
                    Lbl1.Visible = true; Lbl2.Visible = true; Lbl3.Visible = false;
                    btnRestablecer_Click(sender, e);
                }
                else if (rb.Name.Equals("RbtnDevolucion"))
                {
                    Txt2.Visible = false; Txt3.Visible = false;
                    Lbl1.Text = "ID Libro";
                    Lbl1.Visible = true; Lbl2.Visible = false; Lbl3.Visible = false;
                    btnRestablecer_Click(sender, e);
                }
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            Txt1.Text = ""; Txt2.Text = ""; Txt3.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Boolean encontrado;
            Boolean encontrado2 = false;
            Boolean existe;
            if (RbtnUsuario.Checked)
            {
                if (Txt1.Text.Equals("") || Txt2.Text.Equals("") || Txt3.Text.Equals(""))
                {
                    MessageBox.Show("Rellena todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    existe = false;
                    foreach (var i in FormPrincipal.Usuarios)
                    {
                        if (i.Nombre.Equals(Txt1.Text))
                        {
                            MessageBox.Show("Ya existe un usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            existe = true;
                            break;
                        }
                    }

                    if (!existe)
                    {
                        FormPrincipal.Usuarios.Add(new Usuario(Txt2.Text, Txt1.Text, Txt3.Text));
                        MessageBox.Show("Usuario añadido");
                    }
                }
            }
            else if (RbtnLibro.Checked)
            {
                if (Txt1.Text.Equals("") || Txt2.Text.Equals("") || Txt3.Text.Equals(""))
                {
                    MessageBox.Show("Rellena todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    existe = false;
                    foreach (var i in FormPrincipal.Libros)
                    {
                        if (i.Identificador.Equals(Txt1.Text))
                        {
                            MessageBox.Show("Ya existe un libro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            existe = true;
                            break;
                        }
                    }

                    if (!existe)
                    {
                        FormPrincipal.Libros.Add(new Libro(Txt3.Text, Txt2.Text, Txt1.Text));
                        MessageBox.Show("Libro añadido");
                    }
                }
            }
            else if (RbtnPrestamo.Checked)
            {
                encontrado = false;
                encontrado2 = false;
                Usuario usuarioEncontrado = null;
                foreach (var u in FormPrincipal.Usuarios)
                {
                    if (Txt1.Text.Equals(u.Nombre))
                    {
                        encontrado = true;
                        usuarioEncontrado = u;
                        break;
                    }
                }
                foreach (var u in FormPrincipal.Libros)
                {
                    if (Txt2.Text.Equals(u.Identificador))
                    {
                        encontrado2 = true;
                        break;
                    }       
                }

                if (!encontrado)
                {
                    MessageBox.Show("Usuario no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!encontrado2)
                {
                    MessageBox.Show("Libro no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (encontrado && encontrado2)
                {
                    if (Txt1.Text.Equals("") || Txt2.Text.Equals(""))
                    {
                        MessageBox.Show("Rellena todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        /*
                        // Verificar sanción
                        if (!string.IsNullOrEmpty(usuarioEncontrado.FechaSancion))
                        {
                            DateTime fechaSancion;
                            if (DateTime.TryParseExact(usuarioEncontrado.FechaSancion, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaSancion))
                            {
                                if (fechaSancion >= DateTime.Now)
                                {
                                    MessageBox.Show($"El usuario está sancionado hasta {fechaSancion.ToShortDateString()}", "Préstamo denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }
                        */
                        DateTime fecha = DateTime.Now.Date;
                        FormPrincipal.Prestamos.Add(new Prestamo(Txt1.Text, Txt2.Text, fecha.ToString("d/M/yyyy")));
                        MessageBox.Show("Prestamo añadido");
                    }
                }
                
                
            }
            else if (RbtnDevolucion.Checked)
            {
                encontrado = false;
                Prestamo prestamoEncontrado = null;
                for (int i = FormPrincipal.Prestamos.Count - 1; i >= 0; i--)
                {
                    if (FormPrincipal.Prestamos[i].IdLibro.Equals(Txt1.Text))
                    {
                        encontrado = true;
                        prestamoEncontrado = FormPrincipal.Prestamos[i];
                        break;
                    }
                }
                //El ultimo prestamo con ese id

                if (encontrado && prestamoEncontrado != null)
                {
                    if (Txt1.Text.Equals(""))
                    {
                        MessageBox.Show("Rellena todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        /*
                        // Calcular retraso
                        DateTime fechaPrestamo = DateTime.ParseExact(prestamoEncontrado.Fecha, "d/M/yyyy", null);
                        DateTime fechaDevolucionEsperada = fechaPrestamo.AddDays(30); 
                        DateTime fechaActual = DateTime.Now.Date;

                        if (fechaActual > fechaDevolucionEsperada)
                        {
                            int diasRetraso = (fechaActual - fechaDevolucionEsperada).Days;

                            foreach (var u in FormPrincipal.Usuarios)
                            {
                                if (u.Nombre.Equals(prestamoEncontrado.Persona))
                                {
                                    DateTime nuevaFechaSancion = fechaActual.AddDays(diasRetraso * 2); 
                                    u.FechaSancion = nuevaFechaSancion.ToString("d/M/yyyy");
                                    MessageBox.Show($"Devolución tardía. El usuario está sancionado hasta {nuevaFechaSancion.ToShortDateString()}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                            }
                        }
                        */
                        // Registrar la devolución
                        FormPrincipal.Devoluciones.Add(new Devolucion(Txt1.Text));
                        MessageBox.Show("Devolucion añadida");
                    }
                }
                else
                {
                    MessageBox.Show("Libro no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
