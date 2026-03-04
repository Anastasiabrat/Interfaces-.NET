using System;
using System.Collections.Generic;

namespace AA_SistemasDeSeguridad
{
    public class Servicio
    {
        // Propiedades principales
        public string CodigoServicio { get; set; }
        public string DniCliente { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoSistemaAsociado { get; set; }

        // Propiedades opcionales
        public int? Minutos { get; set; } // Puede ser nulo
        public List<string> CodigosSensores { get; set; }

        // Constructor
        public Servicio(string codigoServicio, string dniCliente, string tipo, DateTime fecha, string codigoSistemaAsociado, int? minutos = null, List<string> codigosSensores = null)
        {
            CodigoServicio = codigoServicio;
            DniCliente = dniCliente;
            Tipo = tipo;
            Fecha = fecha;
            CodigoSistemaAsociado = codigoSistemaAsociado;
            Minutos = minutos; // Opcional
            CodigosSensores = codigosSensores ?? new List<string>(); // Opcional
        }

        public Servicio()
        {
        }

        // metodo para agregar un sensor
        public void AgregarCodigoSensor(string codigoSensor)
        {
            if (!string.IsNullOrWhiteSpace(codigoSensor))
            {
                CodigosSensores.Add(codigoSensor);
            }
        }

        /*public override string ToString()
        {
            string sensores = CodigosSensores.Count > 0 ? string.Join(", ", CodigosSensores) : "Sin sensores asociados";
            return $"Código Servicio: {CodigoServicio}\nDNI Cliente: {DniCliente}\nTipo: {Tipo}\nFecha: {Fecha.ToShortDateString()}\nSistema Asociado: {CodigoSistemaAsociado}\nMinutos: {(Minutos.HasValue ? Minutos.Value.ToString() : "No especificado")}\nSensores: {sensores}";
        } */
    }
}

/*

Codigo del servicio
DNI del cliente
Tipo
Fecha
Codigo del sistema de seguridad asociado
[minutos]
[código sensor 1]
...
[código sensor N]
Nota: Las líneas entre[] son opcionales

 ej:
            2
            40983175-D
            REPARACION
            5/10/2002
            g389
            3
            2345-K
            0185-J

 */