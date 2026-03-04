using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AA_Conectado_GestionHoteles
{
    public partial class FormClientes : Form
    {
        
        List<Customer> clientes;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            clientes = CargarClientesDesdeBD();
            MostrarClientesEnListbox();

            //puedo pasar la coleccion clientes al UserControl dentro del metodo load?
            userControl11.SetListaClientes(clientes);
        }

        // Metodo que carga los obj. Clientes directamente a una lista 
        private List<Customer> CargarClientesDesdeBD()
        {
            List<Customer> lista = new List<Customer>();

            using(OleDbConnection ctn = new ClaseExclusivaConexionBD().GetConnection())
            {
                ctn.Open();
                string query = "SELECT CustomerID, FirstName, LastName, Address, Email FROM Customer";
                OleDbCommand cmd = new OleDbCommand(query, ctn);
                OleDbDataReader reader = cmd.ExecuteReader(); 

                while (reader.Read())
                {
                    Customer c = new Customer(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4)
                    );

                    lista.Add(c);
                }

                reader.Close();
            }

            return lista;
        }

        private void MostrarClientesEnListbox()
        {
            listBoxClientes.Items.Clear();

            foreach(Customer c in clientes)
            {
                String lineaCliente = $"{c.FirstName1} {c.LastName1} - {c.Email1}";

                listBoxClientes.Items.Add(lineaCliente);
            }
        }

        private void toolStripButtonNuevo_Click(object sender, EventArgs e)
        {
            // Comprobacion campos completos
            if (string.IsNullOrWhiteSpace(userControl11.InputCustomer.FirstName1) ||
                string.IsNullOrWhiteSpace(userControl11.InputCustomer.LastName1) ||
                string.IsNullOrWhiteSpace(userControl11.InputCustomer.Address1) ||
                string.IsNullOrWhiteSpace(userControl11.InputCustomer.Email1))
            {
                MessageBox.Show("Debe rellenar todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Obtener el nuevo cliente desde el UserControl (ya recoge tdos los datos)
            Customer nuevoCliente = userControl11.InputCustomer;

            // 2. Agregamos a la lista
            clientes.Add(nuevoCliente);

            // 3. Actualizarmos + Mostramos en el listBox
            CargarClientesDesdeBD();
            MostrarClientesEnListbox();

            // INSERTS A LA BD.
            int idUser = userControl11.InputCustomer.CustomerID1;
            String nombreUser = userControl11.InputCustomer.FirstName1;
            String apellidosUser = userControl11.InputCustomer.LastName1;
            String direccUser = userControl11.InputCustomer.Address1;
            String emailUser = userControl11.InputCustomer.Email1;
            using (OleDbConnection ctn = new ClaseExclusivaConexionBD().GetConnection())
            {
                ctn.Open();
                string query = "INSERT INTO Customer (CustomerID, FirstName, LastName, Address, Email) VALUES (?, ?, ?, ?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(query, ctn))
                {
                    cmd.Parameters.AddWithValue("CustomerID", idUser);
                    cmd.Parameters.AddWithValue("FirstName", nombreUser);
                    cmd.Parameters.AddWithValue("LastName", apellidosUser);
                    cmd.Parameters.AddWithValue("Address", direccUser);
                    cmd.Parameters.AddWithValue("Email", emailUser);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        labelMensaje.Text = "Cliente agregado con exito";
                    }
                    // puedo asegurarme de que se insertó correctamente
                }
            }
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        { }

        private void userControl11_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
            {
                errorProvider1.SetError(tb, "Debe rellenar este campo");
                e.Cancel = true; // evita que pierda el foco si está vacio
            }
            else
            {
                errorProvider1.SetError((Control)sender, ""); // limpia el error
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
