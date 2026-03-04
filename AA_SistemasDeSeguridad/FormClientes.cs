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
    public partial class FormClientes : Form
    {
        private static List<Cliente> clientes;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            clientes = new List<Cliente>();

            // LECTURA del archivo
            string[] lineasArchivo = System.IO.File.ReadAllLines("clientes.txt", Encoding.UTF8);

            // Vars para almacenar temporalente los datos del cliente
            string nombre = "", apellidos = "", dni = "", direccion = "", poblacion = "", tel1 = "", tel2 = "";
            int contador = 0;

            // Recorrer las lineas del archivo
            foreach (string linea in lineasArchivo)
            {
                if (string.IsNullOrEmpty(linea)) // if (linea=="")
                {
                    // Si encontramos una linea vacia, creamos el cliente y reiniciamos
                    if (contador > 0)
                    {
                        Cliente cliente;
                        if (string.IsNullOrEmpty(tel2))
                        {
                            cliente = new Cliente(nombre, apellidos, dni, direccion, poblacion, tel1);
                        }
                        else
                        {
                            cliente = new Cliente(nombre, apellidos, dni, direccion, poblacion, tel1, tel2);
                        }
                        clientes.Add(cliente);

                        // Reiniciar variables
                        nombre = ""; apellidos = ""; dni = ""; direccion = ""; poblacion = ""; tel1 = ""; tel2 = "";
                        contador = 0;
                    }
                    continue;
                }

                // Asignar valores segun el contador
                switch (contador)
                {
                    case 0: nombre = linea.Trim(); break;
                    case 1: apellidos = linea.Trim(); break;
                    case 2: dni = linea.Trim(); break;
                    case 3: direccion = linea.Trim(); break;
                    case 4: poblacion = linea.Trim(); break;
                    case 5: tel1 = linea.Trim(); break;
                    case 6: tel2 = linea.Trim(); break;
                }
                contador++;
            }

            // Procesamos ultimo cliente si existe
            if (contador > 0)
            {
                Cliente cliente;
                if (string.IsNullOrEmpty(tel2))
                {
                    cliente = new Cliente(nombre, apellidos, dni, direccion, poblacion, tel1);
                }
                else
                {
                    cliente = new Cliente(nombre, apellidos, dni, direccion, poblacion, tel1, tel2);
                }
                clientes.Add(cliente);
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
                String nombre = textBoxNombre.Text;
                String apellidos = textBoxApellidos.Text;
                String dni = textBoxDNI.Text;
                String direccion = textBoxDireccion.Text;
                String poblacion = textBoxPoblacion.Text;
                String tel1 = textBoxTel1.Text;
                String tel2 = textBoxTel2.Text;
                
                // Comprobacion campos llenos
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        if(textBox.Name != "textBoxTel2" && textBox.Text == "") // Tel2 es opcional
                        {
                            hayCampoVacio = true;
                            break;
                        }
                    }
                }

                if (!hayCampoVacio)
                {
                    Cliente cliente;
                    if (string.IsNullOrEmpty(tel2))
                    {
                        cliente = new Cliente(nombre, apellidos, dni, direccion, poblacion, tel1);
                    }
                    else
                    {
                        cliente = new Cliente(nombre, apellidos, dni, direccion, poblacion, tel1, tel2);
                    }

                    // Añadir el cliente a la lista
                    clientes.Add(cliente);
                    // Modifico el fichero
                    GuardarClienteEnArchivo(cliente);

                    // Mostrar mensaje de exito
                    labelAltaExitoso.Text = "El cliente ha sido dado de alta exitosamente.";
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
            textBoxNombre.Text = "";
            textBoxApellidos.Text = "";
            textBoxDNI.Text = "";
            textBoxDireccion.Text = "";
            textBoxPoblacion.Text = "";
            textBoxTel1.Text = "";
            textBoxTel2.Text = "";
        }

        private void buttonListado_Click(object sender, EventArgs e)
        {
           if(dataGridViewListado.RowCount == 0)
            {
                // Creo las columnas del DataGridView en tiempo de ejecucion
                if (dataGridViewListado.Columns.Count == 0)
                {
                    dataGridViewListado.Columns.Add("nombre", "Nombre");
                    dataGridViewListado.Columns.Add("apellidos", "Apellidos");
                    dataGridViewListado.Columns.Add("dni", "DNI");
                    dataGridViewListado.Columns.Add("direccion", "Direccion");
                    dataGridViewListado.Columns.Add("poblacion", "Poblacion");
                    dataGridViewListado.Columns.Add("tel1", "Telefono 1");
                    dataGridViewListado.Columns.Add("tel2", "Telefono 2");
                }

                //DataGridView
                foreach (Cliente cliente in clientes)
                {
                    dataGridViewListado.Rows.Add(cliente.Nombre, cliente.Apellidos, cliente.DNI1, cliente.Direccion, cliente.Poblacion, cliente.Telefono11, cliente.Telefono21);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxApellidos.Text = "";
            textBoxDNI.Text = "";
            textBoxDireccion.Text = "";
            textBoxPoblacion.Text = "";
            textBoxTel1.Text = "";
            textBoxTel2.Text = "";
        }

        private void btnBusquedaDNI_Click(object sender, EventArgs e)
        {
            if (dataGridViewBusq.RowCount == 0)
            {
                // Creo las columnas del DataGridView en tiempo de ejecucion
                if (dataGridViewBusq.Columns.Count == 0)
                {
                    dataGridViewBusq.Columns.Add("nombre", "Nombre");
                    dataGridViewBusq.Columns.Add("apellidos", "Apellidos");
                    dataGridViewBusq.Columns.Add("dni", "DNI");
                    dataGridViewBusq.Columns.Add("direccion", "Direccion");
                    dataGridViewBusq.Columns.Add("poblacion", "Poblacion");
                    dataGridViewBusq.Columns.Add("tel1", "Telefono 1");
                    dataGridViewBusq.Columns.Add("tel2", "Telefono 2");
                }
            }

            if (dataGridViewBusq != null)
            {
                // Limpiar el grid antes de mostrar datos
                dataGridViewBusq.Rows.Clear();
            }

            //DataGridView: busqeda que coincidan con DNI
            foreach (Cliente cliente in clientes)
            {
                if (cliente.DNI1.ToUpper().Contains(txtBoxBusquedaDNI.Text)) // Filtrar por DNI
                {
                    dataGridViewBusq.Rows.Add(cliente.Nombre, cliente.Apellidos, cliente.DNI1, cliente.Direccion, cliente.Poblacion, cliente.Telefono11, cliente.Telefono21);
                }
            }
        }

        private void GuardarClienteEnArchivo(Cliente cliente)
        {
            try
            {
                // Preparar el contenido a escribir
                StringBuilder contenido = new StringBuilder();
                contenido.AppendLine(cliente.Nombre);
                contenido.AppendLine(cliente.Apellidos);
                contenido.AppendLine(cliente.DNI1);
                contenido.AppendLine(cliente.Direccion);
                contenido.AppendLine(cliente.Poblacion);
                contenido.AppendLine(cliente.Telefono11);
                if (!string.IsNullOrEmpty(cliente.Telefono21))
                {
                    contenido.AppendLine(cliente.Telefono21);
                }
                contenido.AppendLine(); // Linea vacia entre clientes

                // Escribir al final del archivo
                File.AppendAllText("clientes.txt", Environment.NewLine + contenido.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en archivo: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


