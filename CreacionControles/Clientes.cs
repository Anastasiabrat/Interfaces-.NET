using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreacionControles
{
    public partial class Clientes : Form
    {

        private List<Cliente> clientes = new List<Cliente>();


        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarComboBox();

        }

        private void CargarClientes()
{
            string path = "Clientes.txt"; // Ruta
            string line;

            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("El archivo Clientes.txt no existe");
                    return;
                }

                using (StreamReader sr = new StreamReader(path))
                {
                    int count = 0;
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        // Dividir la línea usando el separador '#'
                        string[] datos = line.Split('#');
                        if (datos.Length == 4)
                        {
                            // Crear y añadir un nuevo cliente a la lista
                            Cliente cliente = new Cliente(
                                nombre: datos[0].Trim(),
                                apellidos: datos[1].Trim(),
                                telefono: datos[2].Trim(),
                                comentarios: datos[3].Trim()
                            );
                            clientes.Add(cliente);
                            count++;
                        }
                        line = sr.ReadLine();
                    }
                    Console.WriteLine($"Clientes cargados: {count}");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al cargar clientes: {e.Message}");
            }
        }

        private void CargarComboBox()
        {
            // Ordenar la lista por nombre y guardar la lista ordenada
            clientes = clientes.OrderBy(c => c.Nombre).ToList();

            // Limpiar el combobox
            comboBoxClientes.Items.Clear();

            // Agregar los clientes al combobox
            foreach (Cliente cliente in clientes)
            {
                string nombreCompleto = $"{cliente.Nombre} {cliente.Apellidos}";
                comboBoxClientes.Items.Add(nombreCompleto);
            }
        }

        private void comboBoxClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedIndex != -1)
            {
                // Obtener el cliente seleccionado
                Cliente clienteSeleccionado = clientes[comboBoxClientes.SelectedIndex];

                // Actualizar los campos del control personalizado
                controlCliente1.SetDatos(
                    clienteSeleccionado.Nombre,
                    clienteSeleccionado.Apellidos,
                    clienteSeleccionado.Telefono,
                    clienteSeleccionado.Comentarios
                );

                // Establecer la clave del cliente en el control
                controlCliente1.ClaveUsuario = comboBoxClientes.SelectedIndex.ToString();
            }
        }

        private void toolStripButtonNuevo_Click(object sender, EventArgs e)
        {
            // Limpiar el control
            controlCliente1.SetDatos("", "", "", "");
            controlCliente1.ClaveUsuario1 = clientes.Count.ToString(); // Nueva clave será el siguiente índice
            comboBoxClientes.SelectedIndex = -1; // Deseleccionar el combobox
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del control
            string nombre = controlCliente1.GetNombre();
            string apellidos = controlCliente1.GetApellidos();
            string telefono = controlCliente1.GetTelefono();
            string comentarios = controlCliente1.GetComentarios();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellidos))
            {
                MessageBox.Show("Los campos Nombre y Apellidos son obligatorios");
                return;
            }

            // Crear nuevo cliente
            Cliente cliente = new Cliente(nombre, apellidos, telefono, comentarios);

            if (comboBoxClientes.SelectedIndex == -1) // Es un cliente nuevo
            {
                clientes.Add(cliente);
            }
            else // Es una modificación
            {
                clientes[comboBoxClientes.SelectedIndex] = cliente;
            }

            // Guardar todos los clientes en el archivo
            GuardarClientes();

            // Recargar el combobox
            CargarComboBox();
        }

        private void toolStripButtonBorrar_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedIndex != -1)
            {
                if (MessageBox.Show("¿Está seguro de que desea borrar este cliente?", "Confirmar borrado",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Eliminar el cliente de la lista
                    clientes.RemoveAt(comboBoxClientes.SelectedIndex);

                    // Guardar los cambios
                    GuardarClientes();

                    // Recargar el combobox
                    CargarComboBox();

                    // Limpiar el control
                    controlCliente1.SetDatos("", "", "", "");
                    controlCliente1.ClaveUsuario1 = "";
                }
            }
        }

        private void GuardarClientes()
        {
            string path = "Clientes.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    foreach (Cliente cliente in clientes)
                    {
                        string linea = $"{cliente.Nombre}#{cliente.Apellidos}#{cliente.Telefono}#{cliente.Comentarios}";
                        sw.WriteLine(linea);
                    }
                }
                MessageBox.Show("Los cambios se han guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar clientes: {ex.Message}");
            }
        }
    }
}
