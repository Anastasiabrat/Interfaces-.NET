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

// CONECTADO

namespace AA_OrdinariaDistancia
{
    public partial class FormAltas : Form
    {
        //Declaracion de la conexiona a la BBDD como atributo
        private OleDbConnection ctn;

        public FormAltas()
        {
            InitializeComponent();
        }

        private void FormAltas_Load(object sender, EventArgs e)
        {
            // Creación de la conexión
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " +
                "Data Source = C:\\temp\\Biblioteca.mdb";

            // Apertura de la conexión
            ctn.Open();

            crearToolStrip();
            // Cargar Editores en ListBox
            CargarEditores();
        }

        private void crearToolStrip()
        {
            // Creo ToolStrip
            ToolStrip toolStrip = new ToolStrip();
            toolStrip.Dock = DockStyle.Top;

            ToolStripButton ToolStripBtn1 = new ToolStripButton();
            ToolStripBtn1.Text = "Nuevo";
            ToolStripBtn1.Click += toolStripButtons_Click;

            ToolStripButton ToolStripBtn2 = new ToolStripButton();
            ToolStripBtn2.Text = "Guardar";
            ToolStripBtn2.Click += toolStripButtons_Click;

            ToolStripButton ToolStripBtn3 = new ToolStripButton();
            ToolStripBtn3.Text = "Borrar";
            ToolStripBtn3.Click += toolStripButtons_Click;

            toolStrip.Items.Add(ToolStripBtn1);
            toolStrip.Items.Add(ToolStripBtn2);
            toolStrip.Items.Add(ToolStripBtn3);

            // Asimilar toolStrip a mi Formulario!!
            this.Controls.Add(toolStrip);
        }

        private void CargarEditores()
        {
            try
            {
                // Reabrir conexión si esta cerrada
                if (ctn.State == ConnectionState.Closed)
                    ctn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = ctn;
                cmd.CommandText = "SELECT EdID, Nombre FROM Editores ORDER BY Nombre";

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader); // Cargar reader al DataTable

                // LIMPIAR DataSource primero, NO los Items
                listBoxEditores.DataSource = null;

                // Luego asignar el nuevo DataSource
                listBoxEditores.DataSource = dt;
                listBoxEditores.DisplayMember = "Nombre";
                listBoxEditores.ValueMember = "EdID";

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (ctn.State == ConnectionState.Open)
                    ctn.Close();
            }
        }

        private void toolStripButtons_Click(object sender, EventArgs e)
        {
            if (sender.ToString() == "Nuevo")
            {
                // NUEVO EDITOR CON ID MANUAL
                try
                {
                    if (ctn.State == ConnectionState.Closed)
                        ctn.Open();

                    // 1. Obtener el siguiente ID disponible
                    OleDbCommand cmdMax = new OleDbCommand();
                    cmdMax.Connection = ctn;
                    cmdMax.CommandText = "SELECT MAX(EdID) FROM Editores";

                    object resultado = cmdMax.ExecuteScalar();
                    int siguienteId = (resultado == DBNull.Value) ? 1 : Convert.ToInt32(resultado) + 1;

                    // 2. Insertar el nuevo editor
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = ctn;

                    String sql = "INSERT INTO Editores (EdID, Nombre, Direccion, Ciudad) VALUES (?, ?, ?, ?)";
                    cmd.CommandText = sql;

                    cmd.Parameters.AddWithValue("@id", siguienteId);
                    cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                    cmd.Parameters.AddWithValue("@direccion", textBox2.Text);
                    cmd.Parameters.AddWithValue("@ciudad", textBox3.Text);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show($"Editor insertado exitosamente con ID: {siguienteId}");
                        CargarEditores(); // Recargar lista
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el editor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar: " + ex.Message);
                }
                finally
                {
                    if (ctn.State == ConnectionState.Open)
                        ctn.Close();
                }
            }
            else if (sender.ToString() == "Guardar")
            {
                //MODIFICAR
                if (listBoxEditores.SelectedItem != null)
                {
                    DataRowView filaSeleccionada = (DataRowView)listBoxEditores.SelectedItem;
                    int idElemSeleccionado = Convert.ToInt32(filaSeleccionada["EdID"]);

                    try
                    {
                        // Reabrir conexión si esta cerrada
                        if (ctn.State == ConnectionState.Closed)
                            ctn.Open();

                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = ctn;

                        String sql = "UPDATE Editores SET Nombre = ?, Direccion = ?, Ciudad = ? WHERE EdID = ?";
                        cmd.CommandText = sql;

                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                        cmd.Parameters.AddWithValue("@direccion", textBox2.Text);
                        cmd.Parameters.AddWithValue("@ciudad", textBox3.Text);
                        cmd.Parameters.AddWithValue("@EdID", idElemSeleccionado);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto modificado exitosamente!");
                            CargarEditores(); // Recargar lista
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el producto.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar: " + ex.Message);
                    }
                    finally
                    {
                        if (ctn.State == ConnectionState.Open)
                            ctn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un editor para modificar."); // ✅ Cambiar "producto" por "editor"
                }
            }
            else if (sender.ToString() == "Borrar")
            {
                // ELIMINAR EDITOR SELECCIONADO
                if (listBoxEditores.SelectedItem != null)
                {
                    // Confirmar eliminación
                    DialogResult resultado = MessageBox.Show(
                        "¿Estás seguro de que quieres eliminar este editor?",
                        "Confirmar eliminacion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            // Reabrir conexión si está cerrada
                            if (ctn.State == ConnectionState.Closed)
                                ctn.Open();

                            // Obtener ID del editor seleccionado
                            DataRowView filaSeleccionada = (DataRowView)listBoxEditores.SelectedItem;
                            int idElemSeleccionado = Convert.ToInt32(filaSeleccionada["EdID"]);

                            // Crear comando DELETE
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.Connection = ctn;
                            cmd.CommandText = "DELETE FROM Editores WHERE EdID = ?";
                            cmd.Parameters.AddWithValue("@EdID", idElemSeleccionado);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Editor eliminado exitosamente!");

                                // Limpiar los TextBoxes
                                LimpiarControles();

                                // Recargar la lista de editores
                                CargarEditores();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el editor.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un editor para eliminar.");
                }
            }
            else
            {
                MessageBox.Show("Opcion no valida.");
            }
        }

        private void listBoxEditores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEditores.SelectedItem != null)
            {
                // System.InvalidCastException: 'No se puede convertir un objeto de tipo 'System.Data.DataRowView' al tipo 'System.IConvertible'.'
                //El error se produce porque cuando usas un DataTable como DataSource, SelectedValue devuelve un objeto DataRowView, no el valor real. Soluciones:
                // 1. Convertir a DataRowView primero, luego obtener el valor
                // 2. Reabrir conexión si está cerrada                
                DataRowView filaSeleccionada = (DataRowView)listBoxEditores.SelectedItem;
                int idElemSeleccionado = Convert.ToInt32(filaSeleccionada["EdID"]);
                if (ctn.State == ConnectionState.Closed) {
                    ctn.Open();
                }

                // Consultar datos completos del producto seleccionado
                IDbCommand cmd = ctn.CreateCommand();
                cmd.CommandText = "SELECT Nombre, Direccion, Ciudad " +
                                 "FROM Editores WHERE EdID = ?";

                OleDbCommand oleCmd = (OleDbCommand)cmd;
                oleCmd.Parameters.AddWithValue("@EdID", idElemSeleccionado);

                IDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    // Llenar TextBoxes
                    textBox1.Text = lector["Nombre"].ToString();
                    textBox2.Text = lector["Direccion"].ToString();
                    textBox3.Text = lector["Ciudad"].ToString();
                }
                lector.Close();
            }
        }

        private void LimpiarControles()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBoxEditores.ClearSelected(); // Solo limpio seleción, no Items cuando hay DataSource
        }
    }
}
/*
 COMANDOS-CONECTADO
Los tres botones Nuevo Guardar y Borrar se crearán en tiempo de ejecución y su evento click se gestionará por un único método. (2,5 puntos)
Al entrar al formulario aparecen los nombres de los editores en el listbox y al pulsar en un editor se rellenan sus datos en los textbox. (1 punto)
El botón Nuevo da de alta un nuevo editor en la base de datos con los datos de los textboxes. (0,5)
El botón Modificar actualiza en la base de datos el editor que previamente hemos seleccionado. (0,5)
El botón borrar elimina el editor seleccionado de la base de datos. (0,5)
Después de cada alta, borrado o modificación el listbox debe ser actualizado (0,5)
*/
