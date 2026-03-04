using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_OrdinariaDistancia
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

        //Manejar el ToolStripMenu (pedia en un solo metodo)
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Altas")
            {
                Boolean encontrado = false;
                // busco uno de tipo alta
                foreach (Form aux in Application.OpenForms)
                {
                    if (aux.GetType().Name.Equals("Alta"))
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
                    FormAltas alta = new FormAltas();
                    alta.WindowState = FormWindowState.Maximized;
                    alta.MdiParent = this;
                    alta.Show();
                }
            }
            if (e.ClickedItem.Text == "Consulta")
            {
                Boolean encontrado = false;
                // busco uno de tipo alta
                foreach (Form aux in Application.OpenForms)
                {
                    if (aux.GetType().Name.Equals("Consulta"))
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
                    FormConsulta consulta = new FormConsulta();
                    consulta.WindowState = FormWindowState.Maximized;
                    consulta.MdiParent = this;
                    consulta.Show();
                }
            }
        }
    }
}