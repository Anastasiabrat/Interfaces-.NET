// importo ADO
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace iText
{
    public partial class Form1 : Form
    {
        // Declaración de la conexión a la base de datos Northwind como atributo
        private OleDbConnection ctn;
        DataSet ds = new DataSet();
        OleDbDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creación de la conexión
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " +
                        "Data Source=C:\\Users\\34691\\OneDrive\\Documents\\AnastasiaCopiaSSD\\BratkivBratkivAnastasia\\2DAM\\Interfaces\\2doTrimestre\\Bases_de_datos-20250110\\Nwind\\Nwind.mdb";


            // Apertura de la conexión
            ctn.Open();


            OleDbCommand cmd = new OleDbCommand();

            cmd.Connection = ctn;

            cmd.CommandText = "SELECT p.ProductName, p.QuantityperUnit, p.UnitPrice, p.UnitsinStock, c.CategoryName from Products p, Categories c where c.CategoryID = p.CategoryID";

            da = new OleDbDataAdapter();

            OleDbCommandBuilder cb = new OleDbCommandBuilder(da); // Este objeto genera SQL de modificación

            da.SelectCommand = cmd;

            //da.FillSchema(ds, SchemaType.Mapped, "Clientes"); // Si queremos traer las restricciones de la tabla

            da.Fill(ds, "Productos");

            ctn.Close();

            dataGridView1.DataSource = ds.Tables["Productos"];

        }

        private void buttonPdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
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
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null) pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
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
                MessageBox.Show("No Record To Export !!!", "Info");
            }

        }
    }
}
