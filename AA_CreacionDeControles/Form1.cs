using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_CreacionDeControles
{
    public partial class Form1 : Form
    {
        // 1. Hago public la clase *Objeto* + creo coleccion
        public static List<Incidencia> incidencias;
        public static List<String> equipos;
        private CheckBox chkBox;
        int desp = 20; // para dif posicin de los checkBox

        public Form1()
        {
            InitializeComponent();
            // 2. Inicializo coleccion
            incidencias = new List<Incidencia>();
            equipos = new List<String>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int contadorEquipos = 0; //para crear tantos chechbox como equipos haya

            // 3. LECTURA de archivo
            // Ojo - archivo .txt va dento de carpeta bin/Debug
            string[] lineasIncidencias = System.IO.File.ReadAllLines("Incidencias.txt", Encoding.UTF8);
            // 4. Leer + crear + Add objetos Incidencia
            foreach(var line in lineasIncidencias)
            {
                var partes = line.Split('#');
                if(partes.Length > 1)
                {
                    string id = partes[0].Trim();
                    string desincidencia = partes[1].Trim();
                    string desnivel = partes[2].Trim();
                    string fecha = partes[3].Trim();
                    string usuario = partes[4].Trim();
                    string equipo = partes[5].Trim();
                    string generaaveria = partes[6].Trim();

                    Incidencia incidencia = new Incidencia(id, desincidencia, desnivel, fecha, usuario, equipo, generaaveria);
                    incidencias.Add(incidencia);

                    // 5. Cuento N de equipos para crear checkboxes
                    if (!equipos.Contains(equipo))
                    {
                        equipos.Add(equipo);
                    }

                    
                }
            }

            foreach (string equipo in equipos)
            {

                chkBox = new CheckBox();
                this.chkBox.Top = desp;
                this.chkBox.Left = 50;
                this.chkBox.Width = 200;
                this.chkBox.Text = equipo;

                // Asigna el evento CheckedChanged a cada checkbox
                chkBox.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);

                this.Controls.Add(chkBox);
                desp = desp + 30;
            }

            // 6. Creo las columnas del DataGridView en tiempo de ejecucion
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("DescIncidencia", "Descripción de la Incidencia");
                dataGridView1.Columns.Add("DescNivel", "Nivel de Incidencia");
                dataGridView1.Columns.Add("Fecha", "Fecha");
                dataGridView1.Columns.Add("Usuario", "Usuario");
                dataGridView1.Columns.Add("Equipo", "Equipo");
                dataGridView1.Columns.Add("GeneraAveria", "Genera Avería");
            }

            //ListView
            foreach (CheckBox box in this.Controls.OfType<CheckBox>())
            {
                if (box.Checked)
                {
                    foreach(Incidencia incid in incidencias)
                    {
                        if (incid.Equipo.Contains(box.Text)) // Filtrar por equipo seleccionado
                        {
                            dataGridView1.Rows.Add(incid.Id, incid.Descincidencia, incid.Descnivel, incid.Fecha, incid.Usuario, incid.Equipo, incid.Generaaveria);
                        }
                    }
                }
            }

        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dataGridView1.Rows.Clear(); // Borra todas las filas para actualizar los datos

            foreach (CheckBox box in this.Controls.OfType<CheckBox>())
            {
                if (box.Checked) // Si el CheckBox esta marcado
                {
                    foreach (Incidencia incid in incidencias)
                    {
                        if (incid.Equipo.Contains(box.Text)) // Filtrar por equipo seleccionado
                        {
                            dataGridView1.Rows.Add(incid.Id, incid.Descincidencia, incid.Descnivel, incid.Fecha, incid.Usuario, incid.Equipo, incid.Generaaveria);
                        }
                    }
                }
            }
        }

    }
}
