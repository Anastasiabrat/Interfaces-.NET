using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2022
{
    public class Devolucion
    {
        private string id;

        public Devolucion()
        {
        }

        public Devolucion(string id)
        {
            this.Id = id;
        }

        public string Id { get => id; set => id = value; }
    }
}
