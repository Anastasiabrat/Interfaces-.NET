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

namespace Polimorfismo
{
    public partial class FrmPrincipal : Form
    {
        //  ArrayList ELEMENTOS
        private ArrayList elementos = new ArrayList();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlta f = new FrmAlta();
            f.MdiParent = this;
            f.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta f = new FrmConsulta();
            f.MdiParent = this;
            f.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para agregar un elemento al ArrayList
        public void AddItem(object item)
        {
            elementos.Add(item);
        }

        // Método para ordenar los elementos del ArrayList
        public void SortItems()
        {
            elementos.Sort();
        }

        // Método para buscar elementos en el ArrayList
        public List<IElementoMultimedia> BuscarElementos(string criterio)
        {
            List<IElementoMultimedia> resultados = new List<IElementoMultimedia>();

            foreach (var elem in elementos)
            {
                if (elem is IElementoMultimedia elemento && elemento.buscar(criterio))
                {
                    resultados.Add(elemento);
                }
            }

            return resultados;
        }
    }
}

// En los CD, se busca sólo en el título, en las revistas se busca en la lista de palabras clave, y en los libros en el resumen. 
/*
 Se pide realizar una aplicación que permita:
     Dar de alta de elementos en la biblioteca
     Buscar elementos en la biblioteca
 */
 
 /*
    Para que los diferentes elementos de la biblioteca (Revista, Libro, CD)
    puedan ser ordenados utilizando el método Sort de la clase ArrayList, 
    cada clase debe implementar la interfaz IComparable. Esta interfaz define 
    un método CompareTo que se utiliza para comparar dos objetos.
 */

// maximizar ventana ---->   f.WindowState = FormWindowState.Maximized;