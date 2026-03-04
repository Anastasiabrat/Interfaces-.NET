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
    public partial class FrmVer1 : Form
    {
        public FrmVer1(IElementoMultimedia elemento)
        {
            InitializeComponent();
            CargarDatos(elemento);
        }

        private void CargarDatos(IElementoMultimedia elemento)
        {
            if (elemento is Libro libro)
            {
                textBox1.Text = libro.getTitulo();
                textBox2.Text = libro.Editorial;
                label2.Text = "Editorial";
                textBox3.Text = libro.ISBN1.ToString();
                label3.Text = "ISBN";
                textBox4.Text = libro.Resumen;
                label4.Text = "Resumen";

                label3.Show();
                textBox3.Show();
                label4.Show();
                textBox4.Show();
                labelFecha.Hide();
                dateTimePicker1.Hide();
            }
            else if (elemento is CD cd)
            {
                textBox1.Text = cd.getTitulo();
                textBox2.Text = cd.Discografica;
                label2.Text = "Discografia";

                dateTimePicker1.Hide();
                labelFecha.Hide();
                label3.Hide();
                textBox3.Hide();
                label4.Hide();
                textBox4.Hide();
            }
            else if (elemento is Revista revista)
            {
                textBox1.Text = revista.getTitulo();
                textBox2.Text = revista.Numero.ToString();
                label2.Text = "Número";
                textBox2.Text = revista.Editorial;
                label2.Text = "Editorial";
                dateTimePicker1.Value = revista.Fecha;
                labelFecha.Text = "Fecha";
                textBox4.Text = string.Join(", ", revista.PalabrasClave.ToArray());
                label4.Text = "Palabras Clave";

                labelFecha.Show();
                dateTimePicker1.Show();
                label3.Show();
                textBox3.Show();
                label4.Show();
                textBox4.Show();
            }
        }
    }
}
