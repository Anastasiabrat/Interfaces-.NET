using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA_Conectado_GestionHoteles
{
    class ProductType
    {

        private int TypeID;
        private String TypeName;
        private String Description;

        public ProductType()
        {
        }

        public ProductType(int typeID, string typeName, string description)
        {
            TypeID1 = typeID;
            TypeName1 = typeName;
            Description1 = description;
        }

        public int TypeID1 { get => TypeID; set => TypeID = value; }
        public string TypeName1 { get => TypeName; set => TypeName = value; }
        public string Description1 { get => Description; set => Description = value; }
    }
}
