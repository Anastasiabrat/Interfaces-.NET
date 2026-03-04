using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//DataSet - DESCONNECTADO
namespace AA_ExtraordinariaInstituto
{
    public partial class Form1 : Form
    {
        List<String> instructors = new List<String>();
        List<int> instructorsID= new List<int>();
        List<String> departments = new List<String>();
        List<int> departmentsID = new List<int>();
        List<String> profesoresEmail = new List<String>();
        List<int> profesoresID = new List<int>();

        //1.- Abrir la conexión
        //Necesitaremos como atributos de clase la conexión, un DataSet y tantos DataAdapter como tablas queramos traer.
        OleDbConnection ctn;
        DataSet ds = new DataSet();
        OleDbDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //2. Load - abro la conexion
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\temp\\Instituto.mdb";
            ctn.Open();
            MessageBox.Show(ctn.State.ToString());

            //RadioButtons
            CrearRadioButtonsInst();
            CrearRadioButtonsDepa();

            // Cargar tabla de Clases
            CargarClases();

            //Listar Profesores (EmailName)
            ListarProfesores();

            ctn.Close();
        }

        private void CrearRadioButtonsInst()
        {
            // MODO CONECTADO - usa DataReader
            int yPos = 32; //posicion inical para los rabioButtons//17 32 ----

            //ctn.Open();
            string query = "SELECT InstructorID, Instructor FROM Instructors";
            OleDbCommand cmd = new OleDbCommand(query, ctn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int tipoId = reader.GetInt32(0);
                string tipoNombre = reader.GetString(1);

                // Solo agregamos si el nombre no está  aun /> (para evitar duplicados)
                if (!instructors.Contains(tipoNombre))
                {
                    instructors.Add(tipoNombre);
                    instructorsID.Add(tipoId);
                }
            }

            for (int i = 0; i < instructors.Count; i++)
            {
                string nombre = instructors[i];
                int id = instructorsID[i];

                RadioButton radioButton = new RadioButton
                {
                    Text = nombre,
                    Location = new System.Drawing.Point(17, yPos),
                    AutoSize = true,
                    Tag = id
                };

                radioButton.Click += new EventHandler(RadioButton_Click_Instruct);
                groupProfesores.Controls.Add(radioButton);

                yPos += 20; // Espacio entre botones
            }
        }

        private void CrearRadioButtonsDepa()
        {
            int yPos = 32; //posicion inical para los rabioButtons//29 32 ----

            //ctn.Open();
            string query = "SELECT DepartmentID, DepartmentName FROM Departments";
            OleDbCommand cmd = new OleDbCommand(query, ctn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int tipoId = reader.GetInt32(0);
                string tipoNombre = reader.GetString(1);

                // Solo agregamos si el nombre no está  aun /> (para evitar duplicados)
                if (!departments.Contains(tipoNombre))
                {
                    departments.Add(tipoNombre);
                    departmentsID.Add(tipoId);
                }
            }

            for (int i = 0; i < departments.Count; i++)
            {
                string nombre = departments[i];
                int id = departmentsID[i];

                RadioButton radioButton = new RadioButton
                {
                    Text = nombre,
                    Location = new System.Drawing.Point(17, yPos),
                    AutoSize = true,
                    Tag = id
                };

                radioButton.Click += new EventHandler(RadioButton_Click_Depa);
                groupDepartamentos.Controls.Add(radioButton);

                yPos += 20; // Espacio entre botones
            }
        }

        private void CargarClases()
        {
            // 3- Nos traemos los datos al DataSet
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = ctn;
            cmd.CommandText = "SELECT * FROM Classes";

            da = new OleDbDataAdapter(); // motor de datos
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da); // Este objeto genera SQL de MODIFICACION
            da.SelectCommand = cmd;
            // da.FillSchema(ds, SchemaType.Mapped, "Clientes"); // Si queremos traer las restricciones de la tabla
            da.Fill(ds, "Classes"); // me traigo la info a DataSet

            // Enlazar al DataGridView
            dataGridView1.DataSource = ds.Tables["Classes"];

            // Ocultar columnas de claves si existen
            OcultarClaves();
        }

        private void ListarProfesores()
        {
            // MODO CONECTADO - usa DataReader
            listBox1.Items.Clear();
            profesoresEmail.Clear();
            profesoresID.Clear();

            IDbCommand cmd = ctn.CreateCommand();
            cmd.CommandText = "SELECT InstructorID, EmailName FROM Instructors";
            IDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                int id = lector.GetInt32(0);
                string email = lector.GetString(1);

                profesoresID.Add(id);
                profesoresEmail.Add(email);
                listBox1.Items.Add(email);
            }
            lector.Close();
        }

        //Con est emetodo deberia de eusar seleccion para filr clase
        private void RadioButton_Click_Instruct(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                int tipoProfeIdSeleccionado = (int)radioButton.Tag; //para usar .Tag

                ds.Tables["Classes"].DefaultView.RowFilter = "InstructorID = '" + tipoProfeIdSeleccionado + "'"; //Primero filtro, luego muestro
                dataGridView1.DataSource = ds.Tables["Classes"];
            }
        }

        private void RadioButton_Click_Depa(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                int tipoDepaIdSeleccionado = (int)radioButton.Tag; //para usar .Tag

                ds.Tables["Classes"].DefaultView.RowFilter = "DepartmentID = '" + tipoDepaIdSeleccionado + "'"; //Primero filtro, luego muestro
                dataGridView1.DataSource = ds.Tables["Classes"];
            }
        }

        private void OcultarClaves()
        {
            //Ocultar colunnas que cotengan "ID" en su nombre
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name.Contains("ID"))
                {
                    col.Visible = false;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex >= 0)
            {
                int profesorID = profesoresID[listBox1.SelectedIndex];
                CargarDatosProfesor(profesorID);
            }
        }

        private void CargarDatosProfesor(int instructorID)
        {
            // MODO CONECTADO - Nueva consulta para obtener todos los datos
            ctn.Open();

            IDbCommand cmd = ctn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Instructors WHERE InstructorID = " + instructorID;
            IDataReader lector = cmd.ExecuteReader();

            if (lector.Read())
            {
                // Rellenar textboxes
                txtNombre.Text = lector["Instructor"].ToString();
                txtEmail.Text = lector["EmailName"].ToString();
                txtTelefono.Text = lector["PhoneNumber"].ToString();
            }
            lector.Close();
            ctn.Close();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ActualizarProfesor();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GuardarProfesor();
            }
        }

        private void ActualizarProfesor()
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un profesor de la lista para modificar");
                return;
            }

            try
            {
                ctn.Open();

                // Obtener el ID del profesor seleccionado
                int profesorID = profesoresID[listBox1.SelectedIndex];

                // Actualizar profesor
                IDbCommand cmd = ctn.CreateCommand();
                cmd.CommandText = "UPDATE Instructors SET Instructor = ?, EmailName = ?, PhoneNumber = ? WHERE InstructorID = ?";

                OleDbParameter paramNombre = new OleDbParameter("@Instructor", txtNombre.Text.Trim());
                OleDbParameter paramEmail = new OleDbParameter("@EmailName", txtEmail.Text.Trim());
                OleDbParameter paramTelefono = new OleDbParameter("@PhoneNumber", txtTelefono.Text.Trim());
                OleDbParameter paramId = new OleDbParameter("@InstructorID", profesorID);

                cmd.Parameters.Add(paramNombre);
                cmd.Parameters.Add(paramEmail);
                cmd.Parameters.Add(paramTelefono);
                cmd.Parameters.Add(paramId);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Profesor actualizado correctamente");

                    // Actualizar la lista de profesores
                    ListarProfesores();

                    // Actualizar los RadioButtons de instructores
                    ActualizarRadioButtonsInstructores();

                    // Mantener la selecc actualizada
                    int indiceAnterior = listBox1.SelectedIndex;
                    if (indiceAnterior < listBox1.Items.Count)
                    {
                        listBox1.SelectedIndex = indiceAnterior;
                    }
                }

                ctn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar profesor: " + ex.Message);
                if (ctn.State == ConnectionState.Open)
                    ctn.Close();
            }
        }

        private void GuardarProfesor()
        {
            try
            {
                ctn.Open();

                //Obtener el próximo ID disponiblee
                IDbCommand cmdMaxId = ctn.CreateCommand();
                cmdMaxId.CommandText = "SELECT MAX(InstructorID) FROM Instructors";
                object result = cmdMaxId.ExecuteScalar();
                int nuevoId = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;

                IDbCommand cmd = ctn.CreateCommand();
                cmd.CommandText = "INSERT INTO Instructors (InstructorID, Instructor, EmailName, PhoneNumber) VALUES (?, ?, ?, ?)";

                OleDbParameter paramId = new OleDbParameter("@InstructorID", nuevoId);
                OleDbParameter paramNombre = new OleDbParameter("@Instructor", txtNombre.Text.Trim());
                OleDbParameter paramEmail = new OleDbParameter("@EmailName", txtEmail.Text.Trim());
                OleDbParameter paramTelefono = new OleDbParameter("@PhoneNumber", txtTelefono.Text.Trim());

                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramNombre);
                cmd.Parameters.Add(paramEmail);
                cmd.Parameters.Add(paramTelefono);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Profesor agregado correctamente");
                    LimpiarCampos();

                    // Actualizar  lista de profesores
                    ListarProfesores();

                    // Actualizar los RadioButtons de instructores
                    ActualizarRadioButtonsInstructores();
                }

                ctn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar profesor: " + ex.Message);
                if (ctn.State == ConnectionState.Open)
                    ctn.Close();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El campo Email es obligatorio");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El campo Teléfono es obligatorio");
                txtTelefono.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            listBox1.ClearSelected();
        }

        private void ActualizarRadioButtonsInstructores()
        {
            // Limpiar RadioButtons existentes
            groupProfesores.Controls.Clear();
            instructors.Clear();
            instructorsID.Clear();

            // Recrear RadioButtons
            CrearRadioButtonsInst();
        }
    }
}
