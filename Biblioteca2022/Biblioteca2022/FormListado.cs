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
    public partial class FormListado : Form
    {
        String claseSelec = "";
        public FormListado()
        {
            InitializeComponent();
        }

        private void FormListado_Load(object sender, EventArgs e)
        {

        }
        private void Rbtb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            switch (rb.Text)
            {
                case "Usuario":
                    claseSelec = "usuario";
                    cargarUsuarios();
                    break;
                case "Libro":
                    claseSelec = "libro";
                    cargarLibros();
                    break;
                case "Prestamo":
                    cargarPrestamos();
                    claseSelec = "prestamo";
                    break;
                case "Devolucion":
                    claseSelec = "devolucion";
                    cargarDevoluciones();
                    break;
            }
        }

        private void cargarUsuarios()
        {
            listViewListado.Items.Clear();
            listViewListado.Columns.Clear();

            listViewListado.Columns.Add("Nombre"); listViewListado.Columns.Add("Tipo"); listViewListado.Columns.Add("Departamento"); listViewListado.Columns.Add("Fecha Sanción");

            foreach (Usuario u in FormPrincipal.Usuarios)
            {
                ListViewItem item = new ListViewItem(u.Nombre);
                listViewListado.Items.Add(item);
                item.SubItems.Add(u.Tipo); item.SubItems.Add(u.Departamento); item.SubItems.Add(u.FechaSancion);
            }

            listViewListado.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            foreach (ColumnHeader columna in listViewListado.Columns)
            {
                int anchoHeader = TextRenderer.MeasureText(columna.Text, listViewListado.Font).Width;
                columna.Width = Math.Max(anchoHeader, columna.Width) + 10;
            }
        }
        private void cargarLibros()
        {
            listViewListado.Items.Clear();
            listViewListado.Columns.Clear();

            listViewListado.Columns.Add("Id"); listViewListado.Columns.Add("Nombre"); listViewListado.Columns.Add("Ubicación");

            foreach (Libro l in FormPrincipal.Libros)
            {
                ListViewItem item = new ListViewItem(l.Identificador + "");
                listViewListado.Items.Add(item);
                item.SubItems.Add(l.Titulo); item.SubItems.Add(l.Ubicacion);
            }

            listViewListado.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            foreach (ColumnHeader columna in listViewListado.Columns)
            {
                int anchoHeader = TextRenderer.MeasureText(columna.Text, listViewListado.Font).Width;
                columna.Width = Math.Max(anchoHeader, columna.Width) + 10;
            }
        }
        private void cargarPrestamos()
        {
            listViewListado.Items.Clear();
            listViewListado.Columns.Clear();

            listViewListado.Columns.Add("Persona"); listViewListado.Columns.Add("Id Libro"); listViewListado.Columns.Add("Fecha");

            foreach (Prestamo p in FormPrincipal.Prestamos)
            {
                ListViewItem item = new ListViewItem(p.Persona);
                listViewListado.Items.Add(item);
                item.SubItems.Add(p.IdLibro); item.SubItems.Add(p.Fecha);
            }

            listViewListado.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            foreach (ColumnHeader columna in listViewListado.Columns)
            {
                int anchoHeader = TextRenderer.MeasureText(columna.Text, listViewListado.Font).Width;
                columna.Width = Math.Max(anchoHeader, columna.Width) + 10;
            }
        }
        private void cargarDevoluciones()
        {
            listViewListado.Items.Clear();
            listViewListado.Columns.Clear();

            listViewListado.Columns.Add("Id Devolucion");

            foreach (Devolucion d in FormPrincipal.Devoluciones)
            {
                ListViewItem item = new ListViewItem(d.Id + "");
                listViewListado.Items.Add(item);
            }

            listViewListado.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            foreach (ColumnHeader columna in listViewListado.Columns)
            {
                int anchoHeader = TextRenderer.MeasureText(columna.Text, listViewListado.Font).Width;
                columna.Width = Math.Max(anchoHeader, columna.Width) + 10;
            }
        }

        private void tbBusqueda_FormListado_KeyDown(object sender, KeyEventArgs e){

            if (e.KeyCode == Keys.Enter){
                busquedaListado();
            }

        }

        private void busquedaListado(){
            String textoTB = tbBusqueda_FormListado.Text;

            if (claseSelec.Equals("usuario")){
                foreach (ListViewItem item in listViewListado.Items){
                    if (!(item.Text.ToLower() == textoTB.ToLower())){
                        item.Remove();
                    }
                }
                if (listViewListado.Items.Count == 0 && textoTB != ""){
                    MessageBox.Show("No existe un usuario con ese nombre.");
                    tbBusqueda_FormListado.Text = "";
                    cargarUsuarios();
                }else if (textoTB == ""){
                    cargarUsuarios();
                }
            }
            if (claseSelec.Equals("libro")){
                foreach (ListViewItem item in listViewListado.Items){
                    if (!(item.SubItems[1].Text.ToLower() == textoTB.ToLower())){
                        item.Remove();
                    }
                }
                if (listViewListado.Items.Count == 0 && textoTB != ""){
                    MessageBox.Show("No existe un libro con ese nombre.");
                    tbBusqueda_FormListado.Text = "";
                    cargarLibros();
                }else if (textoTB == ""){
                    cargarLibros();
                }
            }
            if (claseSelec.Equals("prestamo")){
                HashSet<ListViewItem> items_aBorrar = new HashSet<ListViewItem> ();
                
                foreach (ListViewItem item in listViewListado.Items){
                    if (!(item.SubItems[0].Text.ToLower() == textoTB.ToLower()) && !(item.SubItems[1].Text.ToLower() == textoTB.ToLower())
                        && !(item.SubItems[2].Text.ToLower() == textoTB.ToLower())){
                        items_aBorrar.Add(item);
                    }
                }
                foreach (ListViewItem item in listViewListado.Items) {
                    if (items_aBorrar.Contains(item)) { 
                        item.Remove();
                    }
                }
                if (listViewListado.Items.Count == 0 && textoTB != ""){
                    MessageBox.Show("No existe un prestamo al que aplicarle ese filtro.");
                    tbBusqueda_FormListado.Text = "";
                    cargarPrestamos();
                }else if (textoTB == ""){
                    cargarPrestamos();
                }
            }
            if (claseSelec.Equals("devolucion")){
                foreach (ListViewItem item in listViewListado.Items){
                    if (!(item.SubItems[0].Text.ToLower() == textoTB.ToLower())){
                        item.Remove();
                    }
                }
                if (listViewListado.Items.Count == 0 && textoTB != ""){
                    MessageBox.Show("No existe una devolución con ese código.");
                    tbBusqueda_FormListado.Text = "";
                    cargarDevoluciones();
                }else if (textoTB == ""){
                    cargarDevoluciones();
                }
            }
        }
    }
}
