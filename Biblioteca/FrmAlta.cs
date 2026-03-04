using System;
using System.Drawing;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmAlta : Form
    {
        String tituloInput;
        String autorInput;
        String editorialInput;
        String rutaSelecc;

        public FrmAlta()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            tituloInput = TxtBoxTitulo.Text;
            autorInput = TxtBoxAutor.Text;
            editorialInput = TxtBoxEditorial.Text;

            //Buscar formulario padre en openforms
            //Una vez encontrado, accedo a la coleccion
            foreach (Form f in Application.OpenForms)
            {
                if(f is FrmPadre formpadre)
                {
                    if (checkBoxNuevo.Checked)
                    {
                        formpadre.coleccion.Add(new Libro(tituloInput, autorInput, editorialInput, true, rutaSelecc));
                    }
                    else
                    {
                        formpadre.coleccion.Add(new Libro(tituloInput, autorInput, editorialInput, false, rutaSelecc));
                    }
                }
            }
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBoxTitulo.Text = "";
            TxtBoxAutor.Text = "";
            TxtBoxEditorial.Text = "";
            checkBoxNuevo.Checked = false;
        }

        private void BtnCargarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "(*.jpg) |*.jpg| All files | *.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.ShowDialog();
            rutaSelecc = openFileDialog1.FileName.ToString();

            //MessageBox.Show(rutaSelecc);

            Bitmap imagen = new Bitmap(openFileDialog1.FileName);
            pictureBoxPortada.Image = imagen;
        }

    }
}
