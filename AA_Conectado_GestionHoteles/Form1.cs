using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// importo ADO
using System.Data.OleDb;

namespace AA_Conectado_GestionHoteles
{
    public partial class Form1 : Form
    {
        // Declaración de la conexión a la base de datos como atributo
        private OleDbConnection ctn;

        public Form1()
        {
            InitializeComponent();

            // --> MDI
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Creación de la conexión
            ctn = new OleDbConnection();
            ctn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; " +
                "Data Source=C:\\Temp\\xtreme.mdb";

            // Apertura de la conexión
            ctn.Open();

            // Comprobación del estado de la conexión
            //MessageBox.Show(ctn.State.ToString());
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes f = new FormClientes();
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }

        private void PRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos f = new FormProductos();
            f.WindowState = FormWindowState.Maximized;
            f.MdiParent = this;
            f.Show();
        }
    }
}
