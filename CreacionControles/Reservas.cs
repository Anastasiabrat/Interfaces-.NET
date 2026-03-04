using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CreacionControles
{
    public partial class Reservas : Form
    {
        private List<Reserva> reservas = new List<Reserva>();
        private string archivoReservas = "Reservas.txt";

        public Reservas()
        {
            InitializeComponent();
            CargarReservas();
            ConfigurarDataGridView();
        }

        private void CargarReservas()
        {
            if (!File.Exists(archivoReservas))
            {
                MessageBox.Show("El archivo de reservas no existe.");
                return;
            }

            reservas.Clear();
            foreach (var linea in File.ReadAllLines(archivoReservas))
            {
                var datos = linea.Split('#');
                if (datos.Length == 4)
                {
                    reservas.Add(new Reserva(datos[0], datos[1], DateTime.Parse(datos[2]), datos[3]));
                }
            }
            ActualizarGrid();
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewReservas.AutoGenerateColumns = true;
            dataGridViewReservas.DataSource = reservas;
            dataGridViewReservas.ColumnHeaderMouseClick += (s, e) => OrdenarPorColumna(e.ColumnIndex);
        }

        private void ActualizarGrid()
        {
            var filtroCategorias = listBoxCategorias.SelectedItems.Cast<string>().ToList();
            var fechaSeleccionada = monthCalendar.SelectionStart;
            var reservasFiltradas = reservas.Where(r => (filtroCategorias.Count == 0 || filtroCategorias.Contains(r.Categoria)) && r.Fecha.Date == fechaSeleccionada.Date).ToList();

            dataGridViewReservas.DataSource = null;
            dataGridViewReservas.DataSource = reservasFiltradas;
        }

        private void OrdenarPorColumna(int columnIndex)
        {
            if (columnIndex == 0) reservas = reservas.OrderBy(r => r.Nombre).ToList();
            else if (columnIndex == 1) reservas = reservas.OrderBy(r => r.Fecha).ToList();
            else if (columnIndex == 2) reservas = reservas.OrderBy(r => r.Categoria).ToList();

            ActualizarGrid();
        }

        private void listBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            ActualizarGrid();
        }
    }

    public class Reserva
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha { get; set; }
        public string Categoria { get; set; }

        public Reserva(string nombre, string apellido, DateTime fecha, string categoria)
        {
            Nombre = nombre;
            Apellido = apellido;
            Fecha = fecha;
            Categoria = categoria;
        }
    }
}
