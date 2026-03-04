using System;
using System.Collections;
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
    public partial class FrmPadre : Form
    {
        internal ArrayList coleccion = new ArrayList();

        public FrmPadre()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMessageBox(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlta f = new FrmAlta();
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta f = new FrmConsulta();
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }

        private void organizarHijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                MessageBox.Show(f.GetType().Name.ToString());

            }
        }

        private void showMessageBox(object sender, EventArgs e)
        {
            // COMO FUNCIONA DialogResult: ----

            DialogResult result = MessageBox.Show(
                "Está seguro de que desea salir?",  // Mensaje
                "Confirmacion",                     // Titulo de la ventana
                MessageBoxButtons.YesNo,            // Botones que apareceran. "Yes" y "No"
                MessageBoxIcon.Question);           // Icono de pregunta que aparece en el cuadro de diálogo


            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                // No hace nada, desaparece
            }

        }
    }
}
