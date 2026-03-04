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
    public partial class FormBorrado : Form
    {
        Boolean bUsuario = false;
        Boolean bLibro = false;
        public FormBorrado()
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
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            Txt1.Text = ""; Txt2.Text = ""; Txt3.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (bUsuario)
            {
                foreach (var i in FormPrincipal.Usuarios)
                {
                    if (Txt1.Text.Equals(i.Nombre))
                    {
                        FormPrincipal.Usuarios.Remove(i);
                        MessageBox.Show("Usuario Borrado", "ACCEPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
            if (bLibro)
            {  
                foreach (var i in FormPrincipal.Libros)
                {
                    if (Txt1.Text.Equals(i.Identificador))
                    {
                        FormPrincipal.Libros.Remove(i);
                        MessageBox.Show("Libro Borrado", "ACCEPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }

            bUsuario = false; bLibro = false;
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
                foreach (var i in FormPrincipal.Usuarios)
                {
                    if (Txt1.Text.Equals(i.Nombre))
                    {
                        Txt1.Text = i.Nombre; Txt2.Text = i.Tipo; Txt3.Text = i.Departamento;
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
                        Txt1.Text = i.Identificador; Txt2.Text = i.Titulo; Txt3.Text = i.Ubicacion;
                        bLibro = true;
                        break;
                    }
                }
                if (!bLibro)
                {
                    MessageBox.Show("Libro no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
