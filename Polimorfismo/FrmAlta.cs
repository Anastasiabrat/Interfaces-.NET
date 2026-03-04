using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class FrmAlta : Form
    {
        string inputTitulo;
        string inputEditorial;
        string inputISBN;
        string inputResumen;


        public FrmAlta()
        {
            InitializeComponent();
        }


        private void FrmAlta_Load(object sender, EventArgs e)
        {
            
        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Limpiar controles anteriores
            LimpiarControlesDinamicos();

            if (radioButtonLibro.Checked)
            {
                crearAltaLibro();
            }
            else if (radioButtonRevista.Checked)
            {
                crearAltaRevista();
            }
            else if (radioButtonCD.Checked)
            {
                crearAltaCD();
            }
        }

        private void LimpiarControlesDinamicos()
        {
            // Eliminar controles dinámicos anteriores
            var controlsToRemove = this.Controls.OfType<Control>().Where(c => c.Tag != null && c.Tag.ToString() == "dynamic").ToList();
            foreach (var control in controlsToRemove)
            {
                this.Controls.Remove(control);
            }
        }

        private void crearAltaLibro()
        {
            label2.Text = "Editorial";
            label3.Text = "ISBN";
            label4.Text = "Resumen";
            labelFecha.Visible = false;
            dateTimePicker1.Visible = false;
            TxtBox4.Multiline = true; // luego hay que volver a ponerlo False

            label3.Visible = true;
            label4.Visible = true;
            TxtBox3.Visible = true;
            TxtBox4.Visible = true;
        }

        private void crearAltaRevista()
        {
            label2.Text = "Numero";
            label3.Text = "Palabras Clave";
            label4.Text = "Editorial";
            TxtBox3.Multiline = true;
            labelFecha.Visible = true;
            dateTimePicker1.Visible = true;

            label3.Visible = true;
            label4.Visible = true;
            TxtBox3.Visible = true;
            TxtBox4.Visible = true;
        }

        private void crearAltaCD()
        {
            label2.Text = "Discografica";

            label3.Visible = false;
            label4.Visible = false;
            TxtBox3.Visible = false;
            TxtBox4.Visible = false;
            labelFecha.Visible = false;
            dateTimePicker1.Visible = false;

            TxtBox4.Multiline = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonLibro.Checked)
                {
                    string input1 = TxtBox1.Text;
                    string input2 = TxtBox2.Text;
                    int input3 = int.Parse(TxtBox3.Text);
                    string input4 = TxtBox4.Text;

                    Libro l = new Libro(input1, input2, input3, input4);
                    ((FrmPrincipal)this.MdiParent).AddItem(l);
                }
                else if (radioButtonRevista.Checked)
                {
                    string input1 = TxtBox1.Text;
                    int input2 = int.Parse(TxtBox2.Text);
                    string[] input3 = TxtBox3.Text.Split(',');
                    DateTime input4 = dateTimePicker1.Value;
                    string input5 = TxtBox4.Text;

                    Revista r = new Revista(input1, input2, input3, input4, input5);
                    ((FrmPrincipal)this.MdiParent).AddItem(r);
                }
                else if (radioButtonCD.Checked)
                {
                    string input1 = TxtBox1.Text;
                    string input2 = TxtBox2.Text;

                    CD c = new CD(input1, input2);
                    ((FrmPrincipal)this.MdiParent).AddItem(c);
                }


                MessageBox.Show("Elemento añadido exitosamente al inventario.");
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es un numero valido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número ingresado es demasiado grande o demasiado pequeño.", "Error de Desbordamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            TxtBox1.Text = "";
            TxtBox2.Text = "";
            TxtBox3.Text = "";
            TxtBox4.Text = "";            
        }
    }
}
