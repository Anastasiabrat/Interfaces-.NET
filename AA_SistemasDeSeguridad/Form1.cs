using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_SistemasDeSeguridad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            Form formClientes = new FormClientes();
            formClientes.MdiParent = this;
               
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormClientes f = new FormClientes();
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButtonSistemas_Click(object sender, EventArgs e)
        {
            FormSistemas f = new FormSistemas();
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButtonSensores_Click(object sender, EventArgs e)
        {
            FormSensores f = new FormSensores();
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButtonServicios_Click(object sender, EventArgs e)
        {
            FormServicios f = new FormServicios();
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }
    }
}
// FALTA
// FormClientes --> si ya existe cliente que intento dar de alta --> mensaje aviso ya existe!
//         mensaje solo si alta exitoso!! sale siemre q ue pulso boton 
// FormSistemas ---> COMO HAGO QUE LEA BIEN LOS FICHEROS CON ATRUBUTOS DE SENSORES???