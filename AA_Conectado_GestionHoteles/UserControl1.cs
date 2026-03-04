using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_Conectado_GestionHoteles
{
    public partial class UserControl1 : UserControl
    {

        private List<Customer> clientes;
        // 1. Creo instancia del objeto Cliente
        private Customer customer;

        public UserControl1()
        {
            InitializeComponent();
        }

        //2 . (y hago la clase Customer publica)
        public Customer InputCustomer
        {
            get
            {
                return new Customer
                (
                    AsignarCostumerID(),
                    txtNombre.Text,
                    txtApellidos.Text,
                    txtDirecc.Text,
                    txtEmail.Text
                );
            }
            set
            {
                customer = value;
                if (value != null)
                {
                    AsignarCostumerID();
                    txtNombre.Text = value.FirstName1;
                    txtApellidos.Text = value.LastName1;
                    txtDirecc.Text = value.Address1;
                    txtEmail.Text = value.Email1;
                }
            }
        }


        // Método para recoger de FormClientes la coleccion de clientes (necesito en esta clase una lista clientes creada)
        public void SetListaClientes(List<Customer> clientesExistentes)
        {
            clientes = clientesExistentes;
        }

        private int AsignarCostumerID()
        {
            int nuevoID = clientes.Count() + 1;

            return nuevoID;
        }

        public void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDirecc.Text = "";
            txtEmail.Text = "";
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

