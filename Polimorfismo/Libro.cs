using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Libro : IElementoMultimedia
    {
        string titulo;
        string editorial;
        int ISBN;
        string resumen;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int ISBN1 { get => ISBN; set => ISBN = value; }
        public string Resumen { get => resumen; set => resumen = value; }

        public Libro(string titulo, string editorial, int iSBN, string resumen)
        {
            this.titulo = titulo;
            this.editorial = editorial;
            ISBN = iSBN;
            this.resumen = resumen;
        }

        public bool buscar(string texto)
        {
            if (string.IsNullOrEmpty(resumen))
            {
                return false;
            }
            else
            {
                return resumen.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;
            }
        }

        public void mostrar()
        {
            FrmVer1 verFormulario = new FrmVer1(this);
            verFormulario.ShowDialog();
        }

        public string getTitulo()
        {
            return Titulo;
        }

    }
}
