using iTextSharp.text;
using iTextSharp.text.pdf;
//Project --> Manage NuGet Package --> Browse tab --> Search iTextSharp; then install.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// DESCONECTADO

namespace AA_OrdinariaDistancia
{
    public partial class FormConsulta : Form
    {
        //1.- Abrir la conexión
        //Necesitaremos como atributos de clase la conexión, un DataSet y tantos DataAdapter como tablas queramos traer.
        OleDbConnection ctn;
        DataSet ds = new DataSet();
        OleDbDataAdapter da;

        public FormConsulta()
        {
            InitializeComponent();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            //2. Load - abro la conexion
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\temp\\Biblioteca.mdb";
            ctn.Open();
            //MessageBox.Show(ctn.State.ToString());
        }

        private void toolStripButtonConsultar_Click(object sender, EventArgs e)
        {
            cargarLibrosDataGridView();
        }

        // LISTAR LIBROS EN DataGridView
        private void cargarLibrosDataGridView()
        {
            //ComboBox
            CargarEditor();

            // 3- Nos traemos los datos al DataSet
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = ctn;
            cmd.CommandText = "SELECT Titulo, Anyo, ISBN, EdID FROM Titulos";

            da = new OleDbDataAdapter(); // motor de datos
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da); // Este objeto genera SQL de MODIFICACION
            da.SelectCommand = cmd;
            // da.FillSchema(ds, SchemaType.Mapped, "Clientes"); // Si queremos traer las restricciones de la tabla
            da.Fill(ds, "Titulos"); // me traigo la info a DataSet

            // Enlazar al DataGridView
            dataGridView1.DataSource = ds.Tables["Titulos"];

            // Ocultar columnas de claves si existen
            OcultarEdID();

            ctn.Close();
        }


        private void OcultarEdID()
        {
            //Ocultar colunnas que cotengan "EdID" en su nombre
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name.Contains("EdID"))
                {
                    col.Visible = false;
                }
            }
        }

        private void CargarEditor()
        {
            // Cargar Editores
            OleDbCommand cmdCat = new OleDbCommand();
            cmdCat.Connection = ctn;
            cmdCat.CommandText = "SELECT EdID, Nombre FROM Editores";

            OleDbDataAdapter daCat = new OleDbDataAdapter();
            daCat.SelectCommand = cmdCat;
            daCat.Fill(ds, "Editores");

            comboBoxEditores.DataSource = ds.Tables["Editores"];
            comboBoxEditores.DisplayMember = "Nombre";
            comboBoxEditores.ValueMember = "EdID";
        }

        private void aplicarFiltros()
        {
            dataGridView1.DataSource = ds.Tables["Titulos"];

            if (!checkBoxFiltrarTexto.Checked && !checkBoxFiltrarEditores.Checked)
            {
                // NingUn filtro activo - mostrar todos
                ds.Tables["Titulos"].DefaultView.RowFilter = "";
            }
            else if (checkBoxFiltrarTexto.Checked && !checkBoxFiltrarEditores.Checked)
            {
                dataGridView1.DataSource = ds.Tables["Titulos"];
                ds.Tables["Titulos"].DefaultView.RowFilter = $"titulo LIKE '*{textBoxFiltrarTexto.Text}*'";
            }
            if (checkBoxFiltrarEditores.Checked && !checkBoxFiltrarTexto.Checked)
            {
                DataRowView idEditor = (DataRowView)comboBoxEditores.SelectedItem;
                int nroEditor = Convert.ToInt32(idEditor["EdID"]);
                dataGridView1.DataSource = ds.Tables["Titulos"];
                ds.Tables["Titulos"].DefaultView.RowFilter = $"EdID = {nroEditor}";

            }
            if (checkBoxFiltrarTexto.Checked && checkBoxFiltrarEditores.Checked)
            {
                DataRowView idEditor = (DataRowView)comboBoxEditores.SelectedItem;
                int nroEditor = Convert.ToInt32(idEditor["EdID"]);
                dataGridView1.DataSource = ds.Tables["Titulos"];
                ds.Tables["Titulos"].DefaultView.RowFilter = $"EdID = {nroEditor} AND Titulo = '{textBoxFiltrarTexto.Text}'";
            }
        }

        private void checkBoxFiltrarEditores_CheckedChanged(object sender, EventArgs e)
        {
            aplicarFiltros();
        }

        private void checkBoxFiltrarTexto_CheckedChanged(object sender, EventArgs e)
        {
            aplicarFiltros();
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "titulo.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No se puede guardar la información en el disco: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable
                            (dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment =
                            Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn column in
                            dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase
                                (column.HeaderText));
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in
                            dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in
                                row.Cells)
                                {
                                    //POR SI HAY VALORES NULOS
                                    if (cell.Value != null)
                                    { pdfTable.AddCell(cell.Value.ToString()); }
                                }
                            }
                            using (FileStream stream = new FileStream
                            (sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document
                                (PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("INFORMACIÓN EXPORTADA EXITOSAMENTE!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("NO EXISTE INFORMACIÓN PARA GRABAR!!!", "Info");
            }

        }
    }
}

/* CONSUTA / DESCONECTADO 
 * Al entrar se mostrará título, año e ISBN de todos los libros de la biblioteca. (1 punto)
Opciones de Consulta:
Texto: Buscará aquellos títulos que contengan el texto introducido. (1 punto)
Editor: Buscará aquellos títulos publicados por el editor elegido. (1,5 punto)
*/
