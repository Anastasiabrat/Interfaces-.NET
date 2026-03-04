using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormulariosHeredados
{
    public partial class FormClienteTree : Form1
    {
        public FormClienteTree()
        {
            InitializeComponent();
        }

        private void FormClienteTree_Load(object sender, EventArgs e)
        {
            List<String> ciudades = new List<String>();

            foreach (Cliente cliente in coleccion)   // Meto todas las ciudades en un array sin repetir.
            {
                if(!ciudades.Contains(cliente.Ciudad)) {
                    ciudades.Add(cliente.Ciudad);
                }
            }

            foreach(String ciudad in ciudades)
            {    // Mostar todas las ciudades

                // Agrego cada ciudad como nodo raiz del TreeView
                TreeNode ciudadNode = treeView1.Nodes.Add(ciudad, ciudad, 0 ,0);

                foreach (Cliente cliente in coleccion)
                {
                    if (cliente.Ciudad == ciudad)
                    {
                        ciudadNode.Nodes.Add(cliente.Nombre + " " + cliente.Apellidos, cliente.Nombre + " " + cliente.Apellidos, 1, 1);
                    }
                }

                //treeView1.Nodes.Add(ciudadNodeString, ciudadNodeString, 0, 1);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // treeView1.SelectedNode  -----> otra forma de acceder al nodo seleccionado.
            //e.Node.Nodes.Add("Dani Alvarez", "Jaime", 2, 2);

            //MessageBox(sender.ToString());
            string clienteSelecc = treeView1.SelectedNode.Text;

            foreach (Cliente cliente in coleccion)
            {
                if (clienteSelecc == (cliente.Nombre + " " + cliente.Apellidos))
                {
                    textBoxNombre.Text = cliente.Nombre;
                    textBoxApellidos.Text = cliente.Apellidos;
                    textBoxCiudad.Text = cliente.Ciudad;
                    textBoxEmail.Text = cliente.Email;
                    textBoxComentario.Text = cliente.Comentario;
                }
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            
        }
    }
}
