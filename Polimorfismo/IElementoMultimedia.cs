using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public interface IElementoMultimedia
    {
        Boolean buscar(String texto);
        void mostrar();
        String getTitulo();
    }
}
