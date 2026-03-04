using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_SistemasDeSeguridad
{
    public partial class FormSensores : Form
    {
        private static List<Sensor> sensores;

        public FormSensores()
        {
            InitializeComponent();

            // Inicializar el DataGridView para gestionar NullReference al listar
            if (dataGridViewSensoresList.Columns.Count == 0)
            {
                dataGridViewSensoresList.Columns.Add("codigo", "Código");
                dataGridViewSensoresList.Columns.Add("tipo", "Tipo");
                dataGridViewSensoresList.Columns.Add("precio", "Precio");
                dataGridViewSensoresList.Columns.Add("alcance", "Alcance");
                dataGridViewSensoresList.Columns.Add("codigoInstalacion", "Código Instalación");
            }
        }

        private void FormSensores_Load(object sender, EventArgs e)
        {
            sensores = new List<Sensor>();
            string[] lineasArchivo = System.IO.File.ReadAllLines("sensores.txt", Encoding.UTF8);

            string codigo = "", tipo = "", datosOpcionales = "", codigoInstalacion = "";
            double precio = 0;
            int contador = 0;

            foreach (string linea in lineasArchivo)
            {
                if (string.IsNullOrEmpty(linea))
                {
                    if (contador > 0)
                    {
                        // Verificar si los datos opcionales son válidos según el tipo
                        if (tipo.ToUpper() == "TACTIL")
                        {
                            datosOpcionales = "N/A";
                        }
                
                        Sensor sensor = new Sensor(codigo, tipo, precio, datosOpcionales, codigoInstalacion);
                        sensores.Add(sensor);

                        // Reiniciar variables
                        codigo = ""; tipo = ""; datosOpcionales = ""; codigoInstalacion = ""; precio = 0;
                        contador = 0;
                    }
                    continue;
                }

                switch (contador)
                {
                    case 0: codigo = linea.Trim(); break;
                    case 1: tipo = linea.Trim(); break;
                    case 2: precio = double.Parse(linea.Trim()); break;
                    case 3: datosOpcionales = linea.Trim(); break;
                    case 4: codigoInstalacion = linea.Trim(); break;
                }
                contador++;
            }
                // Procesar último sensor si existe
            if (contador > 0)
            {
                if (tipo.ToUpper() == "TACTIL")
                {
                    datosOpcionales = "N/A";
                }
                Sensor sensor = new Sensor(codigo, tipo, precio, datosOpcionales, codigoInstalacion);
                sensores.Add(sensor);
            }
        }


        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox txt)
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    errorProvider1.SetError(txt, "El campo no puede estar vacío.");
                }
                else
                {
                    errorProvider1.SetError(txt, ""); // Limpiar el error si el campo está lleno
                }
            }
        }

        private void buttonDarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean hayCampoVacio = false;
                String codigo = labelCodigo.Text;
                String tipo = comboBoxTipo.Text;
                double precio; // if para que coga inputs con comay sin coma. Ej 22 / 22,50
                if (!double.TryParse(textBoxPrecio.Text, NumberStyles.Any, new CultureInfo("es-ES"), out precio))
                {
                    MessageBox.Show("Ingrese un número válido (por ejemplo: 22,50)");
                    return; // salir si el precio no es válido
                }
                String datosOpcionales = ""; // Inicialmente vacio

                // Comprobacion campos llenos
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        if (textBox.Name != "textBoxTempAlcance" && textBox.Text == "")
                        {
                            hayCampoVacio = true;
                            break;
                        }
                    }
                }

                // Asignar datos opcionales segun el tipo
                switch (tipo.ToUpper())
                {
                    case "INFRARROJO":
                        datosOpcionales = textBoxTempAlcance.Text; // Temperatura
                        break;
                    case "VOLUMETRICO":
                        datosOpcionales = textBoxTempAlcance.Text; // Radio d acción
                        break;
                    case "TACTIL":
                        datosOpcionales = "N/A"; // No aplica
                        break;
                }

                String codigoInstalacion = textBoxCodigoInstalacion.Text;

                if (!hayCampoVacio)
                {
                    Sensor sensor = new Sensor(codigo, tipo, precio, datosOpcionales, codigoInstalacion);
                    sensores.Add(sensor);
                    GuardarSensorEnArchivo(sensor);

                    labelAltaExitoso.Text = "Alta exitoso.";
                    labelAltaExitoso.ForeColor = Color.Green;
                    labelAltaExitoso.Font = new Font("Calibri", 15);
                }
                else
                {
                    MessageBox.Show("Debe rellenar todos los campos obligatorios", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    labelAltaExitoso.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dar de alta el cliente: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelAltaExitoso.Visible = false;
            }
        }

        private void btnBusquedaCodigo_Click(object sender, EventArgs e)
        {
            // Crear columnas si no existen
            if (dataGridViewSensoresBusq.Columns.Count == 0)
            {
                dataGridViewSensoresBusq.Columns.Add("codigo", "Código");
                dataGridViewSensoresBusq.Columns.Add("tipo", "Tipo");
                dataGridViewSensoresBusq.Columns.Add("precio", "Precio");
                dataGridViewSensoresBusq.Columns.Add("alcance", "Alcance");
                dataGridViewSensoresBusq.Columns.Add("codigoInstalacion", "Código Instalación");
            }

            if (dataGridViewSensoresBusq != null)
            {
                // Limpiar el grid antes de mostrar datos
                dataGridViewSensoresBusq.Rows.Clear();
            }

            // Buscar y mostrar sensores que coincidan con el código
            foreach (Sensor sensor in sensores)
            {
                if (sensor.Codigo.ToUpper().Contains(txtBoxBusquedaCodigo.Text.ToUpper()))
                {
                    dataGridViewSensoresBusq.Rows.Add( // --> System.InvalidOperationException: 'Al control DataGridView no se puede agregar ninguna fila que no tenga columnas. Las columnas se deben agregar primero.'
                        sensor.Codigo,
                        sensor.Tipo,
                        sensor.Precio,
                        sensor.DatosOpcionales,
                        sensor.CodigoInstalacion
                    );
                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCodigo.Text = "";
            //comboBoxTipo.SelectedIndex = -1;
            textBoxPrecio.Text = "";
            textBoxTempAlcance.Text = "";
            textBoxCodigoInstalacion.Text = "";
        }

        private void buttonListado_Click(object sender, EventArgs e)
        {

            // VERIFICACIONES nullPointer!!
            if (dataGridViewSensoresList == null)
            {
                MessageBox.Show("Error: DataGridView no inicializado");
                return;
            }
            if (sensores == null)
            {
                MessageBox.Show("Error: coleccion sensores vacio");
                return;
            }

            // limpiar el grid antes de mostrar datos
            dataGridViewSensoresList.Rows.Clear();

            // crear columnas si no existen
            if (dataGridViewSensoresList.Columns.Count == 0)
            {
                dataGridViewSensoresList.Columns.Add("codigo", "Código");
                dataGridViewSensoresList.Columns.Add("tipo", "Tipo");
                dataGridViewSensoresList.Columns.Add("precio", "Precio");
                dataGridViewSensoresList.Columns.Add("alcance", "Alcance");
                dataGridViewSensoresList.Columns.Add("codigoInstalacion", "Código Instalación");
            }

            // mostrar todos los sensores
            foreach (Sensor sensor in sensores)
            {
                dataGridViewSensoresList.Rows.Add(
                    sensor.Codigo,
                    sensor.Tipo,
                    sensor.Precio.ToString("N2"),
                    sensor.DatosOpcionales,
                    sensor.CodigoInstalacion
                );
            }
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTipo.SelectedItem.ToString() == "INFRARROJO")
            {
                labelTempAlcance.Text = "Temperatura:";
            } else if(comboBoxTipo.SelectedItem.ToString() == "VOLUMETRICO")
            {
                labelTempAlcance.Text = "Alcance:";
            } else
            {
                labelTempAlcance.Visible = false;
                textBoxTempAlcance.Visible = false;
            }
        }

        private void GuardarSensorEnArchivo(Sensor sensor)
        {
            try
            {
                // Preparar el contenido a escribir
                StringBuilder contenido = new StringBuilder();
                contenido.AppendLine(sensor.Codigo);
                contenido.AppendLine(sensor.Tipo);
                contenido.AppendLine(sensor.Precio.ToString("F2"));
                if(textBoxTempAlcance != null) // si se han introducido los datos opcionales
                {
                    contenido.AppendLine(sensor.DatosOpcionales);
                }
                contenido.AppendLine(sensor.CodigoInstalacion);
                contenido.AppendLine(); // Linea vacia entre clientes

                // Escribir al final del archivo
                File.AppendAllText("sensores.txt", Environment.NewLine + contenido.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en archivo: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
