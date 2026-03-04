using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosHeredados  //--- NO ACABADO, falta vista.
{
    public partial class FormList : Form1 // He cambiado Form por Form1, para tener un formulario padre cuyo codigo se hereda en todos los hijos
    {
        string ciudadFiltro;
        string vistaFiltro;
        Boolean iconoVIP;

        public FormList()
        {
            InitializeComponent();
            //Seleccionar vista por defecto.
            CmbVista.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(Cliente cliente in coleccion)
            {
                if(!comboBoxCiudad.Items.Contains(cliente.Ciudad))
                {
                    comboBoxCiudad.Items.Add(cliente.Ciudad);
                }
            }
        }

        private void comboBoxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudadFiltro = comboBoxCiudad.SelectedItem.ToString();
            listView1.Items.Clear();

            foreach (Cliente cliente in coleccion)
            {
                int iconoVIP = 0;

                if(cliente.Ciudad == ciudadFiltro)  // Selecc. cada cliente de la ciudad escogida
                {
                    if(cliente.vip == true)
                    {
                        iconoVIP = 0;
                    }
                    else
                    {
                        iconoVIP = 1;
                    }

                    ListViewItem l = listView1.Items.Add(cliente.Nombre, iconoVIP);
                    l.SubItems.Add(cliente.Apellidos);
                    l.SubItems.Add(cliente.Email);

                }
            }

        }

        private void comboBoxVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            vistaFiltro = comboBoxVista.SelectedItem.ToString();

            if(vistaFiltro == "Large Icon")
            {
                listView1.View = View.LargeIcon;
            }
            else if (vistaFiltro == "Details")
            {
                // Set ListView view to Details
                listView1.View = View.Details;
            }
            else if (vistaFiltro == "Small Icon")
            {
                // Set ListView view to SmallIcon
                listView1.View = View.SmallIcon;
            }
            else if (vistaFiltro == "List")
            {
                // Set ListView view to List
                listView1.View = View.List;
            }
            else if (vistaFiltro == "Tile")
            {
                // Set ListView view to Tile
                listView1.View = View.Tile;
            }
        }
    }
}
//e nel padre,  cn colecioen, menu formulario. Hereda eso en todos
// Uso treeView

/*foreach(Form f in Application.OpenForms)
{
    if(f is Form3)
    {
        
    }
}*/
