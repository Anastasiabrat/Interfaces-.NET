//ADOconectadoAnastasia
// importo ADO

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ADO_Conectado
{
    public partial class Form1 : Form
    {
        // Declaración de la conexión a la base de datos Northwind como atributo
        private OleDbConnection ctn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Creación de la conexión
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " +
                "Data Source=C:\\Users\\34691\\OneDrive\\Documents\\AnastasiaCopiaSSD\\BratkivBratkivAnastasia\\2DAM\\Interfaces\\2doTrimestre\\Bases de datos-20250110\\Emple\\Emple.mdb";

            // Apertura de la conexión
            ctn.Open();

            // Comprobación del estado de la conexión
            MessageBox.Show(ctn.State.ToString());

            // DEPARTAMENTOS
            IDbCommand cmd;
            cmd = ctn.CreateCommand();
            cmd.CommandText = "SELECT DNOMBRE FROM DEPART";
            IDataReader lector;
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxDeptos.Items.Add(lector.GetString(0));
            }
            lector.Close();

            // LOCALIDAD
            cmd.CommandText = "SELECT LOC FROM DEPART";
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxLoc.Items.Add(lector.GetString(0));
            }
            lector.Close();
        }

        private void FillListBoxes(string query, string parameterName, string parameterValue)
        {
            // ***** comando y lector ******
            IDbCommand cmd;
            cmd = ctn.CreateCommand();
            IDataReader lector;

            // Limpiar los listBox antes de llenarlos
            listBoxApe.Items.Clear();
            listBoxOficio.Items.Clear();
            listBoxSalario.Items.Clear();
            listBoxFecha.Items.Clear();
            listBoxComision.Items.Clear();

            // APELLIDOS
            cmd.CommandText = $"SELECT APELLIDO FROM EMPLE WHERE DEPT_NO = ({query})";
            IDbDataParameter param = cmd.CreateParameter();
            param.ParameterName = parameterName;
            param.Value = parameterValue;
            cmd.Parameters.Add(param);

            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxApe.Items.Add(lector.GetString(0));
            }
            lector.Close();

            // OFICIO
            cmd.CommandText = $"SELECT OFICIO FROM EMPLE WHERE DEPT_NO = ({query})";
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxOficio.Items.Add(lector.GetString(0));
            }
            lector.Close();

            // SALARIO
            cmd.CommandText = $"SELECT SALARIO FROM EMPLE WHERE DEPT_NO = ({query})";
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxSalario.Items.Add(lector.GetDecimal(0));
            }
            lector.Close();

            // FECHA ALTA
            cmd.CommandText = $"SELECT FECHA_ALT FROM EMPLE WHERE DEPT_NO = ({query})";
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxFecha.Items.Add(lector.GetDateTime(0));
            }
            lector.Close();

            // COMISION
            cmd.CommandText = $"SELECT COMISION FROM EMPLE WHERE DEPT_NO = ({query})";
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxComision.Items.Add(lector.IsDBNull(0) ? "N/A" : lector.GetDecimal(0).ToString());
            }
            lector.Close();
        }

        private void listBoxDeptos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string depSelecc = listBoxDeptos.SelectedItem.ToString();
            string query = "SELECT DEPT_NO FROM DEPART WHERE DNOMBRE = @param";
            FillListBoxes(query, "@param", depSelecc);
        }

        private void listBoxLoc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string locSelecc = listBoxLoc.SelectedItem.ToString();
            string query = "SELECT DEPT_NO FROM DEPART WHERE LOC = @param";
            FillListBoxes(query, "@param", locSelecc);
        }

        private void UpdateButtonState()
        {
            buttonSubir.Enabled = listBoxApe.SelectedIndex > 0;
            buttonBajar.Enabled = listBoxApe.SelectedIndex < listBoxApe.Items.Count - 1;
        }

        private void listBoxApe_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateButtonState();
            
            string contenidoListBoxApe = listBoxApe.SelectedItem != null ? listBoxApe.SelectedItem.ToString() : "N/A";
            string contenidoListBoxOficio = listBoxOficio.SelectedItem != null ? listBoxOficio.SelectedItem.ToString() : "N/A";
            string contenidoListBoxSalario = listBoxSalario.SelectedItem != null ? listBoxSalario.SelectedItem.ToString() : "N/A";
            string contenidoListBoxFecha = listBoxFecha.SelectedItem != null ? listBoxFecha.SelectedItem.ToString() : "N/A";
            string contenidoListBoxComision = listBoxComision.SelectedItem != null ? listBoxComision.SelectedItem.ToString() : "N/A";
            
            listBoxApe.Text = contenidoListBoxApe;
            listBoxOficio.Text = contenidoListBoxOficio;
            listBoxSalario.Text = contenidoListBoxSalario;
            listBoxFecha.Text = contenidoListBoxFecha;
            listBoxComision.Text = contenidoListBoxComision;
        }


        private void button2_Click(object sender, System.EventArgs e)
        {
            // Seleccionamos el campo SIGUIENTE
            if (listBoxApe.SelectedIndex < listBoxApe.Items.Count - 1)
            {
                listBoxApe.SelectedIndex++;
                listBoxOficio.SelectedIndex = listBoxApe.SelectedIndex;
                listBoxSalario.SelectedIndex = listBoxApe.SelectedIndex;
                listBoxFecha.SelectedIndex = listBoxApe.SelectedIndex;
                listBoxComision.SelectedIndex = listBoxApe.SelectedIndex;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            // Seleccionamos el campo ANTERIOR
            if (listBoxApe.SelectedIndex > 0)
            {
                listBoxApe.SelectedIndex--;
                listBoxOficio.SelectedIndex = listBoxApe.SelectedIndex;
                listBoxSalario.SelectedIndex = listBoxApe.SelectedIndex;
                listBoxFecha.SelectedIndex = listBoxApe.SelectedIndex;
                listBoxComision.SelectedIndex = listBoxApe.SelectedIndex;
            }
        }

    }
}

/*
            // APELLIDOS
            cmd.CommandText = "SELECT APELLIDO FROM EMPLE";
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxApe.Items.Add(lector.GetString(0));
            }
            lector.Close();

            // OFICIO
            cmd.CommandText = "SELECT OFICIO FROM EMPLE";
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxOficio.Items.Add(lector.GetString(0));
            }
            lector.Close();

            // SALARIO
            cmd.CommandText = "SELECT SALARIO FROM EMPLE";
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxSalario.Items.Add(lector[0]);
            }
            lector.Close();

            // FECHA ALTA
            cmd.CommandText = "SELECT FECHA_ALT FROM EMPLE";
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxFecha.Items.Add(lector[0]);
            }
            lector.Close();

            // COMISION
            cmd.CommandText = "SELECT COMISION FROM EMPLE";
            lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                this.listBoxComision.Items.Add(lector[0]);
            }
            lector.Close();

            // Seleccionamos los primeros campos de cada listBox
            listBoxApe.SelectedIndex = 1;
            listBoxOficio.SelectedIndex = 1;
            listBoxSalario.SelectedIndex = 1;
            listBoxFecha.SelectedIndex = 0;
            listBoxComision.SelectedIndex = 0;*/