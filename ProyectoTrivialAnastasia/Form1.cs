using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoTrivialAnastasia
{
    public partial class BoxPorcentaje : Form
    {

        //Declaro paises
        string[] paises = {
            "Argentina", "Brasil", "Canada", "China", "Egipto",
            "España", "Francia", "India", "Italia", "Japon",
            "Mexico", "Alemania", "Australia", "Colombia", "Peru",
            "Ucrania", "Sudafrica", "Suecia", "Reino Unido", "Estados Unidos"
        };

        //Declaro capitales
        string[] capitales = {
            "Buenos Aires", "Brasilia", "Ottawa", "Pekin", "El Cairo",
            "Madrid", "Paris", "Nueva Delhi", "Roma", "Tokio",
            "Ciudad de Mexico", "Berlin", "Canberra", "Bogota", "Lima",
            "Kyiv", "Pretoria", "Estocolmo", "Londres", "Washington D.C."
        };

        Random random = new Random();
        //Creo estas variables fuera del metodo ponerNombres() para poder usarla en mostrarMensaje().
        int cajaOpcionCorrecta;
        int posicionCorrecta;
        //Var para calcular el porcentaje y suma de respondida en mostrarMensaje().
        double totalAciertos = 0;
        double totalRespuestas = 0;
        double porcentaje = 0;

        Boolean escribirRespuesta = false;
        Boolean modoNombresCapitales = true;

        private void ponerNombres(object sender, EventArgs e)
        {
            //Almaceno textBoxes en un Array
            TextBox[] aTxtOpciones = { Txt1de4, Txt2de4, Txt3de4, Txt4de4 };

            if (modoNombresCapitales == true)
            {
                TituloCajaUnica.Text = "Pais";
                Titulo4Cajas.Text = "Capitales";

                //Limpio el textBox del mensaje
                TxtMessageCorrect.Text = "";

                posicionCorrecta = random.Next(paises.Length);

                //Relleno caja Pais
                TxtUnico.Text = paises[posicionCorrecta];

                //Lista temporal para almacenar indices ya usados
                List<int> usedIndices = new List<int>();
                //Relleno cada hueco con Capitales random
                for (int i = 0; i < aTxtOpciones.Length; i++)
                {
                    int ciudadRandom;
                    do
                    {
                        ciudadRandom = random.Next(capitales.Length);
                    } while (usedIndices.Contains(ciudadRandom));
                    usedIndices.Add(ciudadRandom);
                    aTxtOpciones[i].Text = capitales[ciudadRandom];
                }

                //Relleno con capital correcta, en uno de los cuatro
                //comprobando que no se repitan
                do
                {
                    cajaOpcionCorrecta = random.Next(aTxtOpciones.Length);
                } while (usedIndices.Contains(cajaOpcionCorrecta));
                usedIndices.Add(cajaOpcionCorrecta);
                aTxtOpciones[cajaOpcionCorrecta].Text = capitales[posicionCorrecta];

            }
            else if (modoNombresCapitales == false)
            {
                //modoNombresCapitales = false;
                
                TituloCajaUnica.Text = "Capital";
                Titulo4Cajas.Text = "Paises";

                TxtMessageCorrect.Text = "";

                posicionCorrecta = random.Next(paises.Length);

                //Relleno caja Capital
                TxtUnico.Text = capitales[posicionCorrecta];

                //Lista temporal para no repetir indices.
                List<int> usedIndices = new List<int>();
                //Relleno cada hueco con Pais random
                for (int i = 0; i < aTxtOpciones.Length; i++)
                {
                    int paisRandom;
                    do
                    {
                        paisRandom = random.Next(paises.Length);
                    } while (usedIndices.Contains(paisRandom));
                    usedIndices.Add(paisRandom);
                    aTxtOpciones[i].Text = paises[paisRandom];
                }

                //Relleno con Pais correcto, en uno de los cuatro
                //comprobando que no se repitan
                do
                {
                    cajaOpcionCorrecta = random.Next(aTxtOpciones.Length);
                } while (usedIndices.Contains(cajaOpcionCorrecta));
                usedIndices.Add(cajaOpcionCorrecta);
                aTxtOpciones[cajaOpcionCorrecta].Text = paises[posicionCorrecta];
            }
        }

        //Cada vez que pulso un textBox
        private void mostrarMensaje(object sender, MouseEventArgs e)
        {
            if (escribirRespuesta == false)
            {
                TextBox tbSeleccionado = sender as TextBox;
                totalRespuestas++;
                Boolean insercionCorrecta = false;

                if (modoNombresCapitales == true) //si esta en modo capitales...
                {
                    if (tbSeleccionado.Text == capitales[posicionCorrecta])
                    {
                        insercionCorrecta = true;
                    }
                }
                else if (modoNombresCapitales == false) //si esta en modo paises...
                {
                    if (tbSeleccionado.Text == paises[posicionCorrecta])
                    {
                        insercionCorrecta = true;
                    }
                }

                if (insercionCorrecta == true)
                {
                    TxtMessageCorrect.Text = "Correcto!";
                    //Recalculo y muestro porcentaje
                    totalAciertos++;
                    porcentaje = totalAciertos / totalRespuestas * 100;
                    TxtPorcentaje.Text = Math.Round(porcentaje) + "%";
                }
                else
                {
                    TxtMessageCorrect.Text = "Incorrecto!";
                    //Recalculo y muestro porcentaje
                    porcentaje = totalAciertos / totalRespuestas * 100;
                    TxtPorcentaje.Text = Math.Round(porcentaje) + "%";
                }
            }       
        }

        public BoxPorcentaje()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (escribirRespuesta == true)
            {
                opcEscRespuesta(sender, e);
            } else
            {
                ponerNombres(sender, e);
            }

        }

        private void opcMultiOpc(object sender, EventArgs e)
        {
            TxtMessageCorrect.Enabled = true;
            Txt2de4.Enabled = true;
            Txt3de4.Enabled = true;
            Txt4de4.Enabled = true;
            escribirRespuesta = false;
            ponerNombres(sender, e);
        }

        private void opcEscRespuesta(object sender, EventArgs e)
        {
            escribirRespuesta = true;

            ponerNombres(sender, e);
            Txt1de4.Text = "";
            Txt2de4.Text = "";
            Txt3de4.Text = "";
            Txt4de4.Text = "";
            TxtMessageCorrect.Enabled = false;
            TxtMessageCorrect.Text = "";
            Txt2de4.Enabled = false;
            Txt3de4.Enabled = false;
            Txt4de4.Enabled = false;

            String input = Console.ReadLine();

            Txt1de4_TextChanged(sender, e);
        }

        private void opcNombreCapitales_Click(object sender, EventArgs e)
        {
            modoNombresCapitales = true;
        }

        private void opcNombrePaises_Click(object sender, EventArgs e)
        {
            modoNombresCapitales = false;
        }

        private void Txt1de4_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Txt1de4.Text) && escribirRespuesta == true)
            {
                totalRespuestas++;
                if (Txt1de4.Text.ToUpper() == capitales[posicionCorrecta].ToUpper())
                {
                    posicionCorrecta = random.Next(paises.Length);
                    TxtUnico.Text = paises[posicionCorrecta];
                    Txt1de4.Text = "";

                    TxtMessageCorrect.Enabled = true;
                    TxtMessageCorrect.Text = "Correcto!";
                    // Recalculo y muestro porcentaje
                    totalAciertos++;
                    porcentaje = totalAciertos / totalRespuestas * 100;
                    TxtPorcentaje.Text = Math.Round(porcentaje) + "%";
                } else
                {
                    TxtMessageCorrect.Enabled = true;
                    TxtMessageCorrect.Text = "Incorrecto";
                }
            }

        }
    }
}