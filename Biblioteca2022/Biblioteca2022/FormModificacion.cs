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
    public partial class FormModificacion : Form
    {
        Boolean bUsuario= false;
        Boolean bLibro = false;
        Boolean bPrestamo = false;
        Boolean bDevolucion = false;
        public FormModificacion()
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
                    LblTxt.Text = "Introduzca el nombre";
                    btnRestablecer_Click(sender, e);
                }
                else if (rb.Name.Equals("RbtnLibro"))
                {
                    Txt2.Visible = true; Txt3.Visible = true;
                    Lbl3.Text = "Ubicacion"; Lbl2.Text = "Titulo"; Lbl1.Text = "Identificador";
                    Lbl1.Visible = true; Lbl2.Visible = true; Lbl3.Visible = true;
                    LblTxt.Text = "Introduzca el ID";
                    btnRestablecer_Click(sender, e);
                }
                else if (rb.Name.Equals("RbtnPrestamo"))
                {
                    Txt2.Visible = true; Txt3.Visible = false;
                    Lbl1.Text = "Usuario"; Lbl2.Text = "ID Libro";
                    Lbl1.Visible = true; Lbl2.Visible = true; Lbl3.Visible = false;
                    LblTxt.Text = "Introduzca el usuario y el ID del libro";
                    btnRestablecer_Click(sender, e);
                }
                else if (rb.Name.Equals("RbtnDevolucion"))
                {
                    Txt2.Visible = false; Txt3.Visible = false;
                    Lbl1.Text = "ID Libro";
                    Lbl1.Visible = true; Lbl2.Visible = false; Lbl3.Visible = false;
                    LblTxt.Text = "Introduzca el ID del libro";
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
            if (bUsuario)
            {
                if (Txt1.Text.Equals("") || Txt2.Text.Equals("") || Txt3.Text.Equals(""))
                {
                    MessageBox.Show("Rellena todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var i in FormPrincipal.Usuarios)
                    {
                        if (Txt1.Text.Equals(i.Nombre))
                        {
                            i.Nombre = Txt1.Text; i.Tipo = Txt2.Text; i.Departamento = Txt3.Text;
                            MessageBox.Show("Usuario modificado", "ACCEPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                            
                }
            }
            if (bLibro)
            {
                if (Txt1.Text.Equals("") || Txt2.Text.Equals("") || Txt3.Text.Equals(""))
                {
                    MessageBox.Show("Rellena todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var i in FormPrincipal.Libros)
                    {
                        if (Txt1.Text.Equals(i.Identificador))
                        {
                            i.Identificador = Txt1.Text; i.Titulo = Txt2.Text; i.Ubicacion = Txt3.Text;
                            MessageBox.Show("Libro modificado", "ACCEPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }

                }
            }
            if (bPrestamo)
            {
                if (Txt1.Text.Equals("") || Txt2.Text.Equals(""))
                {
                    MessageBox.Show("Rellena todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var i in FormPrincipal.Prestamos)
                    {
                        if (Txt1.Text.Equals(i.Persona) && Txt2.Text.Equals(i.IdLibro))
                        {
                            i.Persona = Txt1.Text; i.IdLibro = Txt2.Text; 
                            MessageBox.Show("Prestamo modificado", "ACCEPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }

                }
            }

            if (bDevolucion)
            {
                if (Txt1.Text.Equals(""))
                {
                    MessageBox.Show("Rellena todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Se modifica la ultima devolucion con ese id
                    for (int i = FormPrincipal.Devoluciones.Count - 1; i >= 0; i--)
                    {
                        if (FormPrincipal.Devoluciones[i].Equals(Txt1.Text))
                        {
                            FormPrincipal.Devoluciones[i].Id = Txt1.Text;
                            MessageBox.Show("Prestamo modificado", "ACCEPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }

                }
            }
            bUsuario = false; bLibro = false; bPrestamo = false; bDevolucion = false;
        }

        private void Txt1_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla presionada es la tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                Busqueda();
            }

        }

        private void Busqueda()
        {
            
            if (RbtnUsuario.Checked)
            {
                foreach(var i in FormPrincipal.Usuarios)
                {
                    if (Txt1.Text.Equals(i.Nombre))
                    {
                        Txt1.Text = i.Nombre ; Txt2.Text = i.Tipo ; Txt3.Text = i.Departamento;
                        bUsuario = true;
                        break;
                    }
                }
                if (!bUsuario)
                {
                    MessageBox.Show("Usuario no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (RbtnLibro.Checked)
            {
                foreach (var i in FormPrincipal.Libros)
                {
                    if (Txt1.Text.Equals(i.Identificador))
                    {
                        Txt1.Text = i.Identificador ;  Txt2.Text = i.Titulo; Txt3.Text = i.Ubicacion;
                        bLibro = true;
                        break;
                    }
                }
                if (!bLibro)
                {
                    MessageBox.Show("Libro no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (RbtnPrestamo.Checked)
            {
                foreach (var i in FormPrincipal.Prestamos)
                {
                    if (Txt1.Text.Equals(i.Persona) && Txt2.Text.Equals(i.IdLibro))
                    {
                        Txt1.Text = i.Persona; Txt2.Text = i.IdLibro ;
                        bPrestamo = true;
                        break;
                    }
                }
                if (!bPrestamo)
                {
                    MessageBox.Show("Prestamo no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (RbtnDevolucion.Checked)
            {
                //Se modifica la ultima devolucion con ese id
                for (int i = FormPrincipal.Devoluciones.Count - 1; i >= 0; i--)
                {
                    if (FormPrincipal.Devoluciones[i].Equals(Txt1.Text))
                    {
                        Txt1.Text = FormPrincipal.Devoluciones[i].Id ;
                        bDevolucion = true;
                        break;
                    }
                }
                if (!bDevolucion)
                {
                    MessageBox.Show("Devolucion no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
