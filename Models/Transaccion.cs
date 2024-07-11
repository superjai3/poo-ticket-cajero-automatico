using System;

namespace TransferenciaBancaria.Models
{
    public class Transaccion
    {
        public decimal Monto { get; private set; }
        public string Tipo { get; private set; }
        public string Moneda { get; private set; }
        public DateTime Fecha { get; private set; }
        public Cliente Cliente { get; private set; }
        public Sucursal Sucursal { get; private set; }

        public Transaccion(decimal monto, string tipo, string moneda, DateTime fecha, Cliente cliente, Sucursal sucursal)
        {
            Monto = monto;
            Tipo = tipo;
            Moneda = moneda;
            Fecha = fecha;
            Cliente = cliente;
            Sucursal = sucursal;
        }

        public void ImprimirTicket()
        {
            Console.WriteLine("===== Ticket de Transferencia =====");
            Console.WriteLine($"Cliente: {Cliente.GetNombreCompleto()}");
            Console.WriteLine($"Número de Cliente: {Cliente.NumeroCliente}");
            Console.WriteLine($"Monto: {Monto} {Moneda} - Tipo: {Tipo}");
            Console.WriteLine($"Fecha de Transacción: {Fecha}");
            Console.WriteLine($"Sucursal Número: {Sucursal.Numero}");
            Console.WriteLine($"Dirección Sucursal: {Sucursal.Direccion}, {Sucursal.Localidad}, {Sucursal.Provincia}");
            Console.WriteLine("===================================");
        }
    }
}
