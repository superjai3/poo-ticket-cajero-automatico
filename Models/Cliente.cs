using System;

namespace TransferenciaBancaria.Models
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Dni { get; private set; }
        public string Direccion { get; private set; }
        public string Localidad { get; private set; }
        public string Provincia { get; private set; }
        public string CP { get; private set; }
        public int NumeroCliente { get; private set; }

        public Cliente(string nombre, string apellido, string dni, string direccion, string localidad, string provincia, string cp, int numeroCliente)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Localidad = localidad;
            Provincia = provincia;
            CP = cp;
            NumeroCliente = numeroCliente;
        }

        public string GetNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
