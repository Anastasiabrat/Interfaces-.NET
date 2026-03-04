using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormulariosHeredados  //--- ACABADO


{
    public partial class FormAlta : Form1
    {
        public Boolean esVip = false;

        public FormAlta()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            actualizarListBox();
        }

        private void toolStripButtonNuevo_Click(object sender, EventArgs e)
        {

            if (textBoxNombre.Text == "" ||
                textBoxApellidos.Text == "" ||
                textBoxCiudad.Text == "" ||
                textBoxEmail.Text == "" ||
                textBoxComentario.Text == "")
            {
                MessageBox.Show("Rellene todos los campos por favor");
            }
            else
            {
                // EMAIL
                string emailInput = textBoxEmail.Text;
                // Verifico si no existe el email
                foreach (Cliente cliente in coleccion)
                {
                    string emailExistente = cliente.Email;
                    if(emailInput == emailExistente)
                    {
                        MessageBox.Show("Este correo ya este registrado. Se actualizara la informacion.");
                        toolStripButtonGuardar_Click(sender, e);
                        return;
                        // AQUI quiero salir del metodo toolStripButtonNuevo_Click
                    }
                }
                //verifico si el email es valido
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";


                if (!Regex.IsMatch(emailInput, pattern))
                {
                    // El formato del correo electrónico no es válido
                    MessageBox.Show("Por favor, introduce un correo electrónico válido.");
                } else
                {
                    if (checkBoxVIP.Checked)
                    {
                         esVip = true;
                    }
                    else
                    {
                        esVip = false;
                    }
                }
            }

            coleccion.Add(new Cliente(textBoxNombre.Text, textBoxApellidos.Text, textBoxCiudad.Text, textBoxEmail.Text, textBoxComentario.Text, esVip));

            actualizarListBox();
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            string emailInput = textBoxEmail.Text;
            Boolean emailExiste = false;

            foreach (Cliente cliente in coleccion)
            {
                if (cliente.Email == emailInput) // email ya registrado
                {
                    cliente.Nombre = textBoxNombre.Text;
                    cliente.Apellidos = textBoxApellidos.Text;
                    cliente.Ciudad = textBoxCiudad.Text;
                    cliente.Comentario = textBoxComentario.Text;
                    actualizarListBox();
                    emailExiste = true;
                    return;
                } 
            }

            if(!emailExiste)
            {
                MessageBox.Show("Este email no estaba registrado en nuestra base de datos. Se ha creado un nuevo usuario.");
                toolStripButtonNuevo_Click(sender, e);
            }
        }

        private void actualizarListBox()
        {
            listView1.Items.Clear();
            foreach (Cliente cliente in coleccion)
            {
                ListViewItem item = new ListViewItem(cliente.Apellidos);
                item.SubItems.Add(cliente.Nombre);

                listView1.Items.Add(item);
            }
        }

        private void toolStripButtonBorrar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxApellidos.Text = "";
            textBoxCiudad.Text = "";
            textBoxEmail.Text = "";
            textBoxComentario.Text = "";
            checkBoxVIP.Checked = false;
        }
    }
}