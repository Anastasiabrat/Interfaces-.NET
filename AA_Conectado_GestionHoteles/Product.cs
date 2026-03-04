using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA_Conectado_GestionHoteles
{
    class Product
    {
        private int ProductID;
        private String Name;
        private int TypeID;
        private String Color;
        private String Tamanio;

        public Product()
        {
        }

        public Product(int productID, string name, int typeID, string color, string tamanio)
        {
            ProductID1 = productID;
            Name1 = name;
            TypeID1 = typeID;
            Color1 = color;
            Tamanio1 = tamanio;
        }

        public int ProductID1 { get => ProductID; set => ProductID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int TypeID1 { get => TypeID; set => TypeID = value; }
        public string Color1 { get => Color; set => Color = value; }
        public string Tamanio1 { get => Tamanio; set => Tamanio = value; }
    }
}
