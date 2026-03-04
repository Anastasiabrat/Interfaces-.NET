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

namespace FormulariosHeredados
{
    public partial class Form1 : Form
    {
        internal static ArrayList coleccion = new ArrayList(); // La hag interna para que no sea heredada por los hijos

        public Form1()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlta f3 = new FormAlta();
            f3.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormList f2 = new FormList();
            f2.Show();
        }

        private void treeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteTree ftree = new FormClienteTree();
            ftree.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (coleccion.Count == 0)
            {
                coleccion.Add(new Cliente("Anastasia", "Bratkiv", "Madrid", "anastasia@gmail.com", "Nueva empleada", true));
                coleccion.Add(new Cliente("Dani", "ALvarez", "Tenerife", "dani@gmail.com", "Empleado trasladado de Madrid a Tenerife", false));
                coleccion.Add(new Cliente("Constanza", "Canton", "Ibiza", "coti@gmail.com", "Contrato temporal. Temporada de invierno", false));
                coleccion.Add(new Cliente("Claudia", "Garcia", "Madrid", "claudia@gmail.com", "Trabajadora, buena comunicadora.", true));
            }
        }
    }
}
