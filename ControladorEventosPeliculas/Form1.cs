using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

/*
Ejercicio controlador de eventos

Se quiere realizar una aplicación que muestre datos de películas.

Al arrancar el programa las películas se cargan en una colección del fichero peliculas.txt

Cada línea del fichero tiene este formato.

Titulo # Actores # Director  # Clasificación 

En el evento load del formulario, se crean en tiempo de ejecución, tantos Radio Buttons como
clasificaciones distintas de películas haya (se crea el objeto RadioButton y
se añade a la colección Controls del formulario)

Según se van creando los RadioButtons, se asocia el evento click de cada RadioButton
 con un controlador de eventos previamente creado, de forma que cada vez que 
 se pulse en uno se muestren en diferentes ListBox los títulos, 
 actores y directores de las películas de esa clasificación.
*/
namespace ControladorEventosPeliculas
{
    public partial class Form1 : Form
    {
        private List<Pelicula> peliculas = new List<Pelicula>();
        private HashSet<string> clasificaciones = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPeliculas();
            CrearRadioButtons();
        }

        private void CargarPeliculas()
        {
            string path = "Peliculas.txt"; // Ruta
            string line;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        // Dividir la línea usando el separador '#'
                        string[] datos = line.Split('#');
                        if (datos.Length == 4)
                        {
                            // Crear y añadir una nueva película a la lista
                            Pelicula pelicula = new Pelicula(
                                titulo: datos[0].Trim(),
                                actores: datos[1].Trim(),
                                director: datos[2].Trim(),
                                clasificacion: datos[3].Trim()
                            );
                            peliculas.Add(pelicula);
                            clasificaciones.Add(pelicula.Clasificacion);
                        }
                        // Leer la siguiente línea
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void CrearRadioButtons()
        {
            int yPos = 10; // Posición inicial para los RadioButtons
            foreach (string clasificacion in clasificaciones)
            {
                RadioButton radioButton = new RadioButton
                {
                    Text = clasificacion,
                    Location = new System.Drawing.Point(10, yPos),
                    AutoSize = true
                };

                radioButton.Click += new EventHandler(RadioButton_Click);
                this.Controls.Add(radioButton);

                yPos += 25; // Espacio entre botones
            }
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                string clasificacionSeleccionada = radioButton.Text;

                // Filtrar las películas por clasificación
                var peliculasFiltradas = peliculas.Where(p => p.Clasificacion == clasificacionSeleccionada);

                // Limpiar ListView antes de mostrar nueva información
                listViewPeliculas.Items.Clear();

                // Agregar las películas al ListView
                foreach (var pelicula in peliculasFiltradas)
                {
                    // Crear un nuevo item para cada película
                    ListViewItem item = new ListViewItem(pelicula.Titulo);
                    item.SubItems.Add(string.Join(", ", pelicula.Actores));
                    item.SubItems.Add(pelicula.Director);

                    listViewPeliculas.Items.Add(item);
                }
            }
        }

    }
}
