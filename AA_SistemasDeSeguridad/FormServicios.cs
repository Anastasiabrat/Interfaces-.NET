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
    public partial class FormServicios : Form
    {
        private static List<Servicio> servicios = new List<Servicio>();
        private static List<String> sensoresInput = new List<String>();
        private List<Sistema> sistemas;
        int contadorSensor = 1;


        public FormServicios()
        {
            InitializeComponent();
        }

        private void FormServicios_Load(object sender, EventArgs e)
        {
            sistemas = FormSistemas.GetSistemas() != null ? FormSistemas.GetSistemas() : new List<Sistema>();
            servicios = new List<Servicio>();

            // LECTURA del archivo
            string[] lineasArchivoServicios = System.IO.File.ReadAllLines("servicios.txt", Encoding.UTF8);

            // Variables temporales SERVICIOS
            string codigoServicio = "", dniCliente = "", tipoServ = "", codSistAsoc = "";
            int minutos = 0, contador = 0;
            DateTime fechaServ = DateTime.MinValue;
            Servicio servicioTemp = null;
                        //int? minutos = null;


            // Leer linea x linea
            foreach (string linea in lineasArchivoServicios)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    // Si hay un servicio temporal montado, lo agrego a la lista
                    if (servicioTemp != null)
                    {
                        servicios.Add(servicioTemp);
                        servicioTemp = null;
                    }
                    contador = 0;
                    continue;
                }

                switch (contador)
                {
                    case 0: codigoServicio = linea.Trim(); break;
                    case 1: dniCliente = linea.Trim(); break;
                    case 2: tipoServ = linea.Trim(); break;
                    case 3: fechaServ = DateTime.Parse(linea.Trim()); break;
                    case 4:
                        codSistAsoc = linea.Trim();
                        // Creo el Servicio en este momento, después de tener los 5 datos obligatorios
                        servicioTemp = new Servicio(codigoServicio, dniCliente, tipoServ, fechaServ, codSistAsoc);
                        break;
                    case 5:
                        int valorMinutos;
                        if (int.TryParse(linea.Trim(), out valorMinutos))
                        {
                            servicioTemp.Minutos = valorMinutos;
                        }
                        else
                        {
                            servicioTemp.AgregarCodigoSensor(linea.Trim());
                        }
                        break;
                    default:
                        servicioTemp.AgregarCodigoSensor(linea.Trim());
                        break;
                }

                contador++;
            }

            // procesar el ultimo servicio si no terminó con linea vacia
            if (servicioTemp != null)
            {
                servicios.Add(servicioTemp);
            }
        }

        private void buttonAgregarSensor_Click(object sender, EventArgs e)
        {            
            if (textBoxCodigoSensor.Text != "")
            {
                // 1. Aniado a lista temporal.
                String codSensorInput = textBoxCodigoSensor.Text;
                sensoresInput.Add(codSensorInput);
                // 2. Pongo input en lnea, borro campos.
                labelCodSensores.Text += ("\n" + "Sensor " + contadorSensor + ": "+ codSensorInput);
                textBoxCodigoSensor.Text = "";
            }
            contadorSensor++;
        }

        private void buttonDarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean hayCampoVacio = false;
                String cod = textBoxCodServicio.Text;
                String dniCliente = textBoxDniCliente.Text;
                String tipo = comboBoxTipo.Text;
                DateTime fecha = dateTimePicker1.Value;  // <-- Ahora es DateTime real
                String codSistAsoc = textBoxCodSistAsoc.Text;
                        //int minutos = int.Parse(textBoxMinutos.Text);

                // Comprobacion campos llenos
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        if (textBox.Name != "textBoxMinutos" && textBox.Name != "textBoxCodigoSensor" && textBox.Text == "") // Mins y sensor es opcional
                        {
                            hayCampoVacio = true;
                            break;
                        }
                    }
                }

                if (!hayCampoVacio)
                {
                    // Validar que el sistema asociado exista
                    bool existeSistema = false;
                    foreach (Sistema sistema in sistemas)
                    {
                        if (sistema.Codigo == codSistAsoc)
                        {
                            existeSistema = true;
                            break;
                        }
                    }

                    if (!existeSistema)
                    {
                        MessageBox.Show("El código del sistema asociado no existe. Por favor, ingrese uno válido.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        labelAltaExitoso.Visible = false;
                        return;
                    }
                    Servicio servicio;
                    if (string.IsNullOrEmpty(textBoxMinutos.Text))
                    {
                        servicio = new Servicio(cod, dniCliente, tipo, fecha, codSistAsoc);
                    }
                    else
                    {
                        int minutos = int.Parse(textBoxMinutos.Text);
                        // 1. Creo objeto Servicio + 2. Agrego colecc temporal sensores a la lista del obj
                        servicio = new Servicio(cod, dniCliente, tipo, fecha, codSistAsoc, minutos);
                        foreach(String sens in sensoresInput)
                        {
                            servicio.AgregarCodigoSensor(sens);
                        }
                        // 3. Reseteo la colecc temporal de sensores.
                        sensoresInput.Clear();
                    }

                    servicios.Add(servicio);
                    GuardarServEnArchivo(servicio);

                    // Mostrar mensaje de exito
                    labelAltaExitoso.Text = "El servicio ha sido registrado exitosamente.";
                    labelAltaExitoso.ForeColor = Color.Green;
                    labelAltaExitoso.Font = new Font("Calibri", 15);
                    labelAltaExitoso.Visible = true;

                    // Limpiar campos despues del alta exitosa
                    LimpiarCampos();
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

        private void LimpiarCampos()
        {
            textBoxCodServicio.Text = "";
            textBoxDniCliente.Text = "";
            comboBoxTipo.SelectedIndex = -1;
            textBoxCodSistAsoc.Text = "";
            textBoxMinutos.Text = "";
            textBoxCodigoSensor.Text = "";
            labelAltaExitoso.Visible = false;
        }

        private void textBoxNombre_Validating(object sender, CancelEventArgs e)
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

        private void buttonListado_Click(object sender, EventArgs e)
        {
            // limpiar el grid antes de mostrar datos
            dataGridViewListadoServicios.Rows.Clear();

            // crear columnas si no existen
            if (dataGridViewListadoServicios.Columns.Count == 0)
            {
                dataGridViewListadoServicios.Columns.Add("codigo", "Código Servicio");
                dataGridViewListadoServicios.Columns.Add("dniCliente", "DNI Cliente");
                dataGridViewListadoServicios.Columns.Add("tipo", "Tipo Servicio");
                dataGridViewListadoServicios.Columns.Add("fecha", "Fecha");
                dataGridViewListadoServicios.Columns.Add("codSistemaAsoc", "Codigo Sistema seguridad Asociado");
                dataGridViewListadoServicios.Columns.Add("minutos", "Minutos");
            }

            // mostrar todos los sensores
            foreach (Servicio serv in servicios)
            {
                if (serv.Minutos != null && serv.CodigosSensores == null) // si hay minutos y NO hay Sens. asociados
                {
                    dataGridViewListadoServicios.Rows.Add(
                    serv.CodigoServicio,
                    serv.DniCliente,
                    serv.Tipo,
                    serv.Fecha,
                    serv.CodigoSistemaAsociado,
                    serv.Minutos);
                }else if (serv.Minutos == null && serv.CodigosSensores != null) // si NO hay minutos y hay Sens. asociados
                {
                    string codigosSensoresTexto = "";

                    foreach (string cod in serv.CodigosSensores)
                    {
                        codigosSensoresTexto += cod + "\n";
                    }

                    dataGridViewListadoServicios.Rows.Add(
                    serv.CodigoServicio,
                    serv.DniCliente,
                    serv.Tipo,
                    serv.Fecha,
                    serv.CodigoSistemaAsociado,
                    codigosSensoresTexto);
                }
                else if (serv.Minutos != null && serv.CodigosSensores != null) // si hay minutos y hay Sens. asociados
                {
                    string codigosSensoresTexto = "";

                    foreach (string cod in serv.CodigosSensores)
                    {
                        codigosSensoresTexto += cod + "\n";
                    }

                    dataGridViewListadoServicios.Rows.Add(
                    serv.CodigoServicio,
                    serv.DniCliente,
                    serv.Tipo,
                    serv.Fecha,
                    serv.CodigoSistemaAsociado,
                    serv.Minutos,
                    codigosSensoresTexto);
                }
                else // NO minutos + NO Sens. asociados
                {
                    dataGridViewListadoServicios.Rows.Add(
                    serv.CodigoServicio,
                    serv.DniCliente,
                    serv.Tipo,
                    serv.Fecha,
                    serv.CodigoSistemaAsociado);
                }
            }
        }

        private void btnVaciarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBusquedaDNI_Click(object sender, EventArgs e)
        {
            // Crear columnas si no existen
            if (dataGridViewBusquedaServ.Columns.Count == 0)
            {
                dataGridViewBusquedaServ.Columns.Add("codigo", "Código Servicio");
                dataGridViewBusquedaServ.Columns.Add("dniCliente", "DNI Cliente");
                dataGridViewBusquedaServ.Columns.Add("tipo", "Tipo Servicio");
                dataGridViewBusquedaServ.Columns.Add("fecha", "Fecha");
                dataGridViewBusquedaServ.Columns.Add("codSistemaAsoc", "Codigo Sistema seguridad Asociado");
                dataGridViewBusquedaServ.Columns.Add("minutos", "Minutos");
            }

            if (dataGridViewBusquedaServ != null)
            {
                // Limpiar el grid antes de mostrar datos
                dataGridViewBusquedaServ.Rows.Clear();
            }

            // Buscar y mostrar sensores que coincidan con el código
            foreach (Servicio servicio in servicios)
            {
                if (servicio.DniCliente.ToUpper().Contains(txtBoxBusquedaCodSensor.Text.ToUpper()))
                {
                    if (servicio.Tipo == "REPARACION" && servicio.CodigosSensores != null)
                    {
                        dataGridViewBusquedaServ.Columns.Add("sensores", "Sensores");
                        String sensoresConcat = "";

                        foreach(String sensor in servicio.CodigosSensores)
                        {
                            sensoresConcat = sensor + "\n";
                        }

                        dataGridViewBusquedaServ.Rows.Add( // --> System.InvalidOperationException: 'Al control DataGridView no se puede agregar ninguna fila que no tenga columnas. Las columnas se deben agregar primero.'
                        servicio.CodigoServicio,
                        servicio.DniCliente,
                        servicio.Tipo,
                        servicio.Fecha,
                        servicio.CodigoSistemaAsociado,
                        servicio.Minutos,
                        sensoresConcat
                    );

                    }

                    dataGridViewBusquedaServ.Rows.Add( // --> System.InvalidOperationException: 'Al control DataGridView no se puede agregar ninguna fila que no tenga columnas. Las columnas se deben agregar primero.'
                        servicio.CodigoServicio,
                        servicio.DniCliente,
                        servicio.Tipo,
                        servicio.Fecha,
                        servicio.CodigoSistemaAsociado,
                        servicio.Minutos
                    );
                }
            }
        }

        private void GuardarServEnArchivo(Servicio serv)
        {
            try
            {
                StringBuilder contenido = new StringBuilder();
                contenido.AppendLine(serv.CodigoServicio);
                contenido.AppendLine(serv.DniCliente);
                contenido.AppendLine(serv.Fecha.ToString("dd/MM/yyyy"));
                contenido.AppendLine(serv.CodigoSistemaAsociado);
                if (textBoxMinutos != null) // si se han introducido los minutos
                {
                    contenido.AppendLine(serv.Minutos.ToString());
                }
                if(sensoresInput != null)
                {
                    foreach(String sens in sensoresInput)
                    {
                        contenido.AppendLine(sens + "\n");
                    }
                }

                contenido.AppendLine(); // Linea vacia entre nuevos objetos

                // Escribir al final del archivo
                File.AppendAllText("servicios.txt", Environment.NewLine + contenido.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en archivo: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


/*

Codigo del servicio
DNI del cliente
Tipo
Fecha
Codigo del sistema de seguridad asociado
[minutos]
[código sensor 1]
...
[código sensor N]
Nota: Las líneas entre[] son opcionales

 ej:
            2
            40983175-D
            REPARACION
            5/10/2002
            g389
            3
            2345-K
            0185-J

 */