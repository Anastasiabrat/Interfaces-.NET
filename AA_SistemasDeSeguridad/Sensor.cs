using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA_SistemasDeSeguridad
{
    public class Sensor
    {
        private string codigo;
        private string tipo;
        private double precio;
        private string datosOpcionales; // Para temperatura o radio de acción
        private string codigoInstalacion;

        // Constructor principal con datos opcionales
        public Sensor(string codigo, string tipo, double precio, string datosOpcionales, string codigoInstalacion)
        {
            this.codigo = codigo;
            this.tipo = tipo;
            this.precio = precio;
            this.DatosOpcionales = datosOpcionales;
            this.codigoInstalacion = codigoInstalacion;
        }

        // Properties
        public string Codigo { get => codigo; set => codigo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Precio { get => precio; set => precio = value; }
        public string CodigoInstalacion { get => codigoInstalacion; set => codigoInstalacion = value; }
        public string DatosOpcionales { get => datosOpcionales; set => datosOpcionales = value; }

        // Método para obtener los datos opcionales según el tipo
        public string GetDatosOpcionales()
        {
            switch (tipo.ToUpper())
            {
                case "INFRARROJO":
                    return $"Temperatura: {DatosOpcionales}°";
                case "VOLUMETRICO":
                    return $"Radio: {DatosOpcionales}m";
                case "TACTIL":
                    return "N/A";
                default:
                    return DatosOpcionales;
            }
        }
    }
}
