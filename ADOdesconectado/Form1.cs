//ADODesconectadoCarolina

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 1. importo ADO
using System.Data.OleDb;

namespace ADOdesconectado
{
    public partial class Form1 : Form
    {
        // 2.  Declaración de la conexión a la base de datos Northwind como atributo
        private OleDbConnection ctn;
        private DataSet ds = new DataSet();
        OleDbDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 3. Creación de la conexión
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " +
                "Data Source=C:\\Users\\34691\\OneDrive\\Documents\\AnastasiaCopiaSSD\\BratkivBratkivAnastasia\\2DAM\\Interfaces\\2doTrimestre\\ADOdesconectado\\Bases de datos-20250110\\Nwind\\Nwind.mdb";
            //ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " +
            //"Data Source=C:\\Users\\vasil\\Desktop\\2\\Interfaces\\2EV\\ADOdesconectado\\nwind.mdb";

            // 4. Apertura de la conexión
            ctn.Open();

            // 5. Comprobación del estado de la conexión
            MessageBox.Show(ctn.State.ToString() + " - Carolina");
        }

        private void BtnTraerDatos_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = ctn;

            cmd.CommandText = "SELECT * from Customers";

            da = new OleDbDataAdapter();

            OleDbCommandBuilder cb = new OleDbCommandBuilder(da); // Este objeto genera SQL de modificación

            da.SelectCommand = cmd;

            //da.FillSchema(ds, SchemaType.Mapped, "Clientes"); // Si queremos traer las restricciones de la tabla

            da.Fill(ds, "Clientes");

            ctn.Close();
        }

        private void BtnRecorrer_Click(object sender, EventArgs e)
        {
            // Recorrer la tabla
            DataTable tabla = ds.Tables["Clientes"];

            foreach (DataRow registro in tabla.Rows)

            {

                this.listBox1.Items.Add(registro["ContactName"]);

            }
        }

        private void BtnEnlazarDatos_Click(object sender, EventArgs e)
        {
            DataTable tabla = ds.Tables["Clientes"];

            listBox2.DataSource = tabla;

            listBox2.DisplayMember = "ContactName";

            listBox2.ValueMember = "CustomerId";

        }

        private void BtnAccederElement_Click(object sender, EventArgs e)
        {
            DataRowView reg = (DataRowView)listBox2.SelectedItem;

            MessageBox.Show(reg["CustomerId"].ToString());
        }

        private void BtnModificarRegistro_Click(object sender, EventArgs e)
        {
            DataTable tabla = ds.Tables["Clientes"];

            DataRow reg = tabla.Rows[0];  // Nos posicionamos en el registro que queremos modificar

            reg.BeginEdit();

            reg["ContactName"] = "Prueba";

            reg.EndEdit();
        }

        private void BtnInsertarRegistro_Click(object sender, EventArgs e)
        {
            DataTable tabla = ds.Tables["Clientes"];

            DataRow reg = tabla.NewRow();

            reg["ContactName"] = "Paco";

            tabla.Rows.Add(reg);
        }

        private void BtnBorrarRegistro_Click(object sender, EventArgs e)
        {
            DataTable tabla = ds.Tables["Clientes"];

            DataRow reg = tabla.Rows[0];

            reg.Delete();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Insercion y borrado va a a dar error porque faltan claves primarias y errores relacionales
            ctn.Open();

            da.Update(ds, "Clientes");

            ds.AcceptChanges();

            ctn.Close();
        }

        private void BtnModificar2_Click(object sender, EventArgs e)
        {
            DataRowView reg = (DataRowView)listBox2.SelectedItem;

            reg.Row.BeginEdit();

            reg["ContactName"] = "Modificado";

            reg.EndEdit();
        }

        private void BtnSeleccionarPorClave_Click(object sender, EventArgs e)
        {
            listBox2.SelectedValue = "Frank";
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            DataTable tabla = ds.Tables["Clientes"];
            DataRow[] registros = tabla.Select("CustomerID='Frank'");
            MessageBox.Show(registros[0][0].ToString());
        }

        private void BtnGridView_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Clientes"];
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            ds.Tables["Clientes"].DefaultView.RowFilter = "City='Madrid'";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            MessageBox.Show(fila.Cells[0].Value.ToString());
        }

        private void BtnPersonalizar_Click(object sender, EventArgs e)
        {
            DataGridViewColumn titulo = dataGridView1.Columns[0];

            titulo.HeaderText = "TITULO";

            titulo.Visible = false;
        }
    }
}
