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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void tsBtnClientes_Click(object sender, EventArgs e)
        {
            Boolean encontrado = false;
            // busco uno de tipo alta
            foreach (Form aux in Application.OpenForms)
            {
                if (aux.GetType().Name.Equals("Clientes"))
                {
                    //muestro
                    aux.BringToFront();
                    // encontrado true
                    encontrado = true;
                }
            }
            if (encontrado == false)
            {
                // crear alta si no encontrado
                Clientes clientes = new Clientes();
                clientes.WindowState = FormWindowState.Maximized;
                clientes.MdiParent = this;
                clientes.Show();
            }
        }

        private void tsBtnReservas_Click(object sender, EventArgs e)
        {
            Boolean encontrado = false;
            // busco uno de tipo alta
            foreach (Form aux in Application.OpenForms)
            {
                if (aux.GetType().Name.Equals("Clientes"))
                {
                    //muestro
                    aux.BringToFront();
                    // encontrado true
                    encontrado = true;
                }
            }
            if (encontrado == false)
            {
                // crear alta si no encontrado
                Reservas reservas = new Reservas();
                reservas.WindowState = FormWindowState.Maximized;
                reservas.MdiParent = this;
                reservas.Show();
            }
        }
    }
}
