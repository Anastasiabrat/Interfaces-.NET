using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA_SistemasDeSeguridad
{
    public class Sistema
    {
        private string codigo;
        private string precio;
        private List<Sensor> sensores;

        public Sistema()
        {
            sensores = new List<Sensor>();
        }

        public Sistema(string codigo, string precio, List<Sensor> sensores)
        {
            this.Codigo = codigo;
            this.Precio = precio;
            this.sensores = new List<Sensor>();
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Precio { get => precio; set => precio = value; }
        public List<Sensor> Sensores { get => sensores; set => sensores = value; }

        // Métodos para gestionar los sensores
        public void AgregarSensor(Sensor sensor)
        {
            sensores.Add(sensor);
        }

        public void EliminarSensor(Sensor sensor)
        {
            sensores.Remove(sensor);
        }

        public List<Sensor> ObtenerSensores()
        {
            return sensores;
        }
    }
}
