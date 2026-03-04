using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA_CreacionDeControles
{
    public class Incidencia
    {
        string id;
        string descincidencia;
        string descnivel;
        string fecha;
        string usuario;
        string equipo;
        string generaaveria;

        public Incidencia(string id, string descincidencia, string descnivel, string fecha, string usuario, string equipo, string generaaveria)
        {
            this.id = id;
            this.descincidencia = descincidencia;
            this.descnivel = descnivel;
            this.fecha = fecha;
            this.usuario = usuario;
            this.equipo = equipo;
            this.generaaveria = generaaveria;
        }

        public string Id { get => id; set => id = value; }
        public string Descincidencia { get => descincidencia; set => descincidencia = value; }
        public string Descnivel { get => descnivel; set => descnivel = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Equipo { get => equipo; set => equipo = value; }
        public string Generaaveria { get => generaaveria; set => generaaveria = value; }
    }
}
