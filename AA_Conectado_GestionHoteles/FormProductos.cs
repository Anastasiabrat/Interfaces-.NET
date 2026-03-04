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
    public partial class FormProductos : Form
    {
        private List<Product> productos;
        List<String> tipos = new List<String>();
        List<int> tiposIds = new List<int>();

        //Desconectado
        OleDbConnection ctn;
        DataSet ds = new DataSet();
        OleDbDataAdapter da;

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            productos = CargarProductosDesdeBD();
            CargarProductosEnDataSet(); // solo cargar en tabla ds, esto no muestra nada
            CrearRadioButtons();
        }

        private List<Product> CargarProductosDesdeBD() // lista con products
        {
            List<Product> lista = new List<Product>();

            using (OleDbConnection ctn = new ClaseExclusivaConexionBD().GetConnection())
            {
                ctn.Open();
                string query = "SELECT ProductID, Name, TypeID, Color, Tamaño FROM Product";
                OleDbCommand cmd = new OleDbCommand(query, ctn);
                OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Product p = new Product(
                    Convert.ToInt32(reader["ProductID"]),
                    reader["Name"].ToString(),
                    Convert.ToInt32(reader["TypeID"]),
                    reader["Color"].ToString(),
                    reader["Tamaño"].ToString()
                );
                lista.Add(p);
            }

                reader.Close();
            }

            return lista;

        }

        private void CrearRadioButtons()
        {
            int yPos = 50; //posicion inical para los rabioButtons

            using (OleDbConnection ctn = new ClaseExclusivaConexionBD().GetConnection())
            {
                ctn.Open();
                string query = "SELECT TypeID, TypeName FROM ProductType";
                OleDbCommand cmd = new OleDbCommand(query, ctn);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int tipoId = reader.GetInt32(0);
                    string tipoNombre = reader.GetString(1);

                    // Solo agregamos si el nombre no está  aun /> (para evitar duplicados)
                    if (!tipos.Contains(tipoNombre))
                    {
                        tipos.Add(tipoNombre);
                        tiposIds.Add(tipoId);
                    }
                }
            }
            for (int i = 0; i < tipos.Count; i++)
            {
                string nombre = tipos[i];
                int id = tiposIds[i];

                RadioButton radioButton = new RadioButton
                {
                    Text = nombre,
                    Location = new System.Drawing.Point(200, yPos),
                    AutoSize = true,
                    Tag = id 
                };

                radioButton.Click += new EventHandler(RadioButton_Click);
                this.Controls.Add(radioButton);

                yPos += 20; // Espacio entre botones
            }
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                int tipoIdSeleccionado = (int)radioButton.Tag; //para usar .Tag

                ds.Tables["Products"].DefaultView.RowFilter = "TypeID = '" + tipoIdSeleccionado + "'"; //Primero filtro, luego muestro
                dataGridView1.DataSource = ds.Tables["Products"];
            }
        }

        private void CargarProductosEnDataSet()
        {
            using (OleDbConnection ctn = new ClaseExclusivaConexionBD().GetConnection())
            {
                string query = "SELECT ProductID, Name, TypeID, Color, Tamaño FROM Product";
                da = new OleDbDataAdapter(query, ctn);
                ds.Tables.Clear();
                da.Fill(ds, "Products");
            }
        }
    }
}




//En vez de usar lo de .text, uo propiedad .tag para meetr a la vez q el array de tipos, e id de tipo, ueo acedo con getTag