using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2022
{
    interface IUsuario
    {
        DateTime CalcularFechaDevolucion(string ubicacionLibro);
        DateTime CalcularSancion(int diasRetraso);
    }
}
