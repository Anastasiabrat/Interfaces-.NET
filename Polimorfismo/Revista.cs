using System;


namespace Polimorfismo
{
    class Revista : IElementoMultimedia
    {
        string titulo;
        int numero;
        string[] palabrasClave;
        DateTime fecha;
        string editorial;

        public string Titulo { get => titulo; set => titulo = value; }
        public int Numero { get => numero; set => numero = value; }
        public string[] PalabrasClave { get => palabrasClave; set => palabrasClave = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Editorial { get => editorial; set => editorial = value; }

        public Revista(string titulo, int numero, string[] palabrasClave, DateTime fecha, string editorial)
        {
            this.titulo = titulo;
            this.numero = numero;
            this.palabrasClave = palabrasClave;
            this.fecha = fecha;
            this.editorial = editorial;
        }

        public bool buscar(string texto)
        {
            bool encontrado = false;
            foreach(string pal in PalabrasClave)
            {
                if(pal.ToLower() == texto.ToLower())
                {
                    encontrado = true;
                }
            }
            return encontrado;
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
