using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class CD : IComparable<CD>
    {
        string titulo;
        string discografica;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Discografica { get => discografica; set => discografica = value; }

        public CD(string titulo, string discografica)
        {
            this.titulo = titulo;
            this.discografica = discografica;
        }

        public int CompareTo(CD other)
        {
            if (other == null) return 1;
            return this.Titulo.CompareTo(other.Titulo);
        }

        public bool buscar(string texto)
        {
            if (string.IsNullOrEmpty(titulo))
            {
                return false;
            }
            else
            {
                return titulo.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;
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
