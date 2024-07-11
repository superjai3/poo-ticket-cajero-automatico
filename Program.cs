using System;
using TransferenciaBancaria.Models;

namespace TransferenciaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia del Cliente
            Cliente cliente = new Cliente(
                "Susana",
                "Herrera",
                "24155210",
                "Lavalle 1250",
                "Diamante",
                "Entre Ríos",
                "3105",
                10544
            );

            // Instancia de la Sucursal
            Sucursal sucursal = new Sucursal(
                1670,
                "Nación",
                "Gral. Dr. Pascual Echagüe 350",
                "Diamante",
                "Entre Ríos"
            );

            // Instancia de la Transacción
            Transaccion transaccion = new Transaccion(
                15000,
                "Retiro",
                "Pesos",
                new DateTime(2024, 6, 20),
                cliente,
                sucursal
            );

            // Imprimir el ticket de la transacción
            transaccion.ImprimirTicket();
        }
    }
}
