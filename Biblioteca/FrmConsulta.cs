using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmConsulta : Form
    {
        String libroSelecc;

        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            // RadioBtb no checked
            radioBtnAutor.Checked = false;
            radioBtnEditorial.Checked = false;
        }


        private void radioBtnAutorEditorial_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is FrmPadre formpadre)
                {
                    listBoxTitulo.Items.Clear();
                    listBoxAutorEdit.Items.Clear();

                    foreach (Libro libro in formpadre.coleccion)
                    {
                        listBoxTitulo.Items.Add(libro.Titulo); // Agregar el título del libro al ListBox

                        if (radioBtnAutor.Checked)
                        {
                            //listBoxAutorEdit.Items.Clear();
                            listBoxAutorEdit.Items.Add(libro.Autor); // Agregar el título del libro al ListBox
                        } else if (radioBtnEditorial.Checked)
                        {
                            //listBoxAutorEdit.Items.Clear();
                            listBoxAutorEdit.Items.Add(libro.Editorial); // Agregar el título del libro al ListBox
                        }
                    }
                }
            }
        }

        private void listBoxTitulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            libroSelecc = listBoxTitulo.SelectedItem.ToString();

            foreach (Form f in Application.OpenForms)
            {
                if (f is FrmPadre formpadre)
                {
                    foreach (Libro libro in formpadre.coleccion)
                    {
                        if (libroSelecc == libro.Titulo)
                        {
                            Bitmap imagen = new Bitmap(libro.RutaImagen);
                            pictureBoxPortada.Image = imagen;
                        }
                    }
                }
            }
        }

 
    }
}