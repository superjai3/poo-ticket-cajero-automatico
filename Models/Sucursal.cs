using System;

namespace TransferenciaBancaria.Models
{
    public class Sucursal
    {
        public int Numero { get; private set; }
        public string NombreBanco { get; private set; }
        public string Direccion { get; private set; }
        public string Localidad { get; private set; }
        public string Provincia { get; private set; }

        public Sucursal(int numero, string nombreBanco, string direccion, string localidad, string provincia)
        {
            Numero = numero;
            NombreBanco = nombreBanco;
            Direccion = direccion;
            Localidad = localidad;
            Provincia = provincia;
        }
    }
}
