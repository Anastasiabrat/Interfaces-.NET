using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_SistemasDeSeguridad
{
    public partial class FormSistemas : Form
    {

        private static List<Sistema> sistemas;
        private static List<Sensor> sensoresSist;

        // ara acceder a sistemas desde FormServicios
        public static List<Sistema> GetSistemas()
        {
            return sistemas;
        }

        public FormSistemas()
        {
            InitializeComponent();
        }

        private void FormSistemas_Load(object sender, EventArgs e)
        {
            sistemas = new List<Sistema>();
            sensoresSist = new List<Sensor>();

            // LECTURA del archivo
            string[] lineasArchivoSistema = System.IO.File.ReadAllLines("sistemas.txt", Encoding.UTF8);
            string[] lineasArchivoSensores = System.IO.File.ReadAllLines("sensores.txt", Encoding.UTF8);

            // Variables temporales SISTEMAS
            string codigoSistema = "", precioSistema = "";

            // Variables temporales SENSORES
            string codigo = "", tipo = "", alcance = "", codigoInstalacion = "";
            double precio = 0;
            int contador = 0;

            // ****SENSORES*******
            foreach (string linea in lineasArchivoSensores)
            {
                if (string.IsNullOrEmpty(linea))
                {
                    if (contador > 0)
                    {
                        Sensor sensor = new Sensor(codigo, tipo, precio, alcance, codigoInstalacion);
                        sensoresSist.Add(sensor);

                        // Reiniciar variables
                        codigo = ""; tipo = ""; alcance = ""; codigoInstalacion = ""; precio = 0;
                        contador = 0;
                    }
                    continue;
                }

                // Asignar valores segun el contador
                switch (contador)
                {
                    case 0: codigo = linea.Trim(); break;
                    case 1: tipo = linea.Trim(); break;
                    case 2: precio = double.Parse(linea.Trim()); break;
                    case 3: alcance = linea.Trim(); break; // Solo existe si no empieza con letra. ****!!!!!!!!!!!!!!!! CAMBIAR
                    case 4: codigoInstalacion = linea.Trim(); break;
                }
                contador++;
            }

            // Procesar ultimo sensor si existe
            if (contador > 0)
            {
                Sensor sensor = new Sensor(codigo, tipo, precio, alcance, codigoInstalacion);
                sensoresSist.Add(sensor);
                contador = 0;
            }

            // ****SISTEMAS*******
            foreach (string linea in lineasArchivoSistema)
            {
                if (string.IsNullOrEmpty(linea))
                {
                    if (contador > 0)
                    {
                        Sistema sistema = new Sistema(codigoSistema, precioSistema, sensoresSist);
                        sistemas.Add(sistema);

                        // Reiniciar variables
                        codigoSistema = ""; precioSistema = "";
                        contador = 0;
                    }
                    continue;
                }

                // Asignar valores segun el contador
                switch (contador)
                {
                    case 0: codigoSistema = linea.Trim(); break;
                    case 1: precioSistema = linea.Trim(); break;
                }
                contador++;
            }

            // Procesar ultimo sistema si existe
            if (contador > 0)
            {
                Sistema sistema = new Sistema(codigoSistema, precioSistema, sensoresSist);
                sistemas.Add(sistema);
            }
        }

        private void btnAgregarColeccSensores_Click(object sender, EventArgs e)
        {
            String codigo = textBoxCodSensor.Text;
            String tipo = comboBoxTipoSensor.Text;
            double precio = double.Parse(textBoxPrecioSens.Text);
            String alcance = textBoxAlcanceSensor.Text;
            String codigoInstalacion = textBoxCodInstalSensor.Text; // esto es Cod. del Sistema

            Sensor sensor = new Sensor(codigo, tipo, precio, alcance, codigoInstalacion);
            sensoresSist.Add(sensor);

            labelAltaExitoso.Text = "El sensor ha sido registrado dentro del sistema ";
            labelAltaExitoso.ForeColor = Color.Green;
            labelAltaExitoso.Font = new Font("Calibri", 15);
        }

        private void btnGuardarSistema_Click(object sender, EventArgs e)
        {
            // El acceso a los sensorees debe ser usando el atributo del objeto
            String codigoSist = txtBoxCodSist.Text;
            String precioSist = txtBoxPrecioSist.Text;
            Sistema sistNuevo = new Sistema(codigoSist, precioSist, sensoresSist);
            sistemas.Add(sistNuevo);
        }

        private void btnCargarSistemas_Click(object sender, EventArgs e)
        {
            // limpiar el grid antes de mostrar datos
            dataGridViewListadoSistemas.Rows.Clear();

            // crear columnas si no existen
            if (dataGridViewListadoSistemas.Columns.Count == 0)
            {
                dataGridViewListadoSistemas.Columns.Add("codigo", "Código");
                dataGridViewListadoSistemas.Columns.Add("precio", "Precio");
            }

            // mostrar todos los sensores
            foreach (Sistema sist in sistemas)
            {
                dataGridViewListadoSistemas.Rows.Add(
                    sist.Codigo,
                    sist.Precio
                );
            }
        }

        private void dataGridViewListadoSistemas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string codigoSistemaSeleccionado = dataGridViewListadoSistemas.Rows[e.RowIndex].Cells[0].Value.ToString();
            dataGridViewListadoSens.Rows.Clear();

            if (dataGridViewListadoSens.Columns.Count == 0)
            {
                dataGridViewListadoSens.Columns.Add("codigo", "Código");
                dataGridViewListadoSens.Columns.Add("tipo", "Tipo");
                dataGridViewListadoSens.Columns.Add("precio", "Precio");
                dataGridViewListadoSens.Columns.Add("datosOpcionales", "Datos Específicos");
            }

            foreach (Sensor sensor in sensoresSist)
            {
                if (sensor.CodigoInstalacion.Trim().ToUpper() == codigoSistemaSeleccionado.Trim().ToUpper())
                {
                    dataGridViewListadoSens.Rows.Add(
                        sensor.Codigo,
                        sensor.Tipo,
                        sensor.Precio.ToString("F2"),
                        sensor.GetDatosOpcionales()
                    );
                }
            }
        }

        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            // Vaciar los TextBox
            txtBoxCodSist.Clear();
            txtBoxPrecioSist.Clear();
            textBoxCodSensor.Clear();
            textBoxPrecioSens.Clear();
            textBoxAlcanceSensor.Clear();
            textBoxCodInstalSensor.Clear();

            // Resetear el ComboBox
            comboBoxTipoSensor.SelectedIndex = -1; // ninguna opcion seleccionada

            // Limpiar etiquetas de estado
            labelAltaExitoso.Text = "";
        }

        private void btnBusquedaSistemas_Click(object sender, EventArgs e)
        {
            // Crear columnas si no existen
            if (dataGridViewBusquedaSistemas.Columns.Count == 0)
            {
                dataGridViewBusquedaSistemas.Columns.Add("codigoSistema", "Código Sistema");
                dataGridViewBusquedaSistemas.Columns.Add("precioSistema", "Precio");
            }

            if (dataGridViewBusquedaSistemas != null)
            {
                // Limpiar el grid antes de mostrar datos
                dataGridViewBusquedaSistemas.Rows.Clear();
            }

            // Buscar y mostrar sistemas que coincidan con el código
            foreach (Sistema sistema in sistemas)
            {
                if (sistema.Codigo.ToUpper().Contains(txtBoxBusquedaCodSist.Text.ToUpper()))
                {
                    dataGridViewBusquedaSistemas.Rows.Add(
                        sistema.Codigo,
                        sistema.Precio
                    );
                }
            }
        }

        private void btnVaciarCamposSensor_Click(object sender, EventArgs e)
        {
            textBoxCodSensor.Text = "";
            textBoxPrecioSens.Text = "";
            textBoxAlcanceSensor.Text = "";
            textBoxCodInstalSensor.Text = "";
            comboBoxTipoSensor.SelectedIndex = -1;
        }

        private void txtBoxCodSist_Validating(object sender, CancelEventArgs e)
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

        private void GuardarSistEnArchivo(Sistema sist)
        {
            try
            {
                StringBuilder contenido = new StringBuilder();
                contenido.AppendLine(sist.Codigo);
                contenido.AppendLine(sist.Precio);

                contenido.AppendLine(); // Linea vacia entre nuevos objetos

                // Escribir al final del archivo
                File.AppendAllText("sistemas.txt", Environment.NewLine + contenido.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en archivo: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxTipoSensor_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null) return;  // Safety check

            string selected = comboBox.SelectedItem?.ToString();

            if (selected == "INFRARROJO")
            {
                labelVariable.Text = "Temperatura";
                labelVariable.Visible = true;
                textBoxAlcanceSensor.Visible = true;
            }
            else if (selected == "VOLUMETRICO")
            {
                labelVariable.Text = "Alcance";
                labelVariable.Visible = true;
                textBoxAlcanceSensor.Visible = true;
            }
            else if (selected == "TACTIL")
            {
                labelVariable.Visible = false;
                textBoxAlcanceSensor.Visible = false;
            }
        }


    }
}

//Codigo del sistema en Sensor es codigoInstalacion

//Sensor sensor = new Sensor(codigo, tipo, precio, alcance, codigoInstalacion);
//sensores.Add(sensor);

// Reiniciar variables
//codigo = ""; tipo = ""; alcance = ""; codigoInstalacion = ""; precio = 0;