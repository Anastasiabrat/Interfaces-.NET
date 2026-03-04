using System;
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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string criterio = textBox1.Text;
            List<IElementoMultimedia> resultados = ((FrmPrincipal)this.MdiParent).BuscarElementos(criterio);
            MostrarResultados(resultados);
        }

        private void MostrarResultados(List<IElementoMultimedia> resultados)
        {
            listView1.Items.Clear();
            foreach (var resultado in resultados)
            {
                ListViewItem item = new ListViewItem(resultado.getTitulo());
                item.SubItems.Add(resultado.GetType().Name);
                listView1.Items.Add(item);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                IElementoMultimedia elemento = (IElementoMultimedia)selectedItem.Tag;
                elemento.mostrar(); // Llamar al método mostrar del objeto
            }
        }
    }
}

//Para que en la columna Tipo aparezca el tipo del objeto (Revista, Libro o Cd) utiliza el
//método getType().