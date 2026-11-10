using System;

namespace PracticaMetodosYClases
{
    // Clase Cliente
    public class Cliente
    {
        private string nombre;
        private double cantidadTotal;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            this.cantidadTotal = 0;
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                cantidadTotal += cantidad;
            }
        }

        public void Sacar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= cantidadTotal)
            {
                cantidadTotal -= cantidad;
            }
        }

        public double GetCantidadTotal()
        {
            return cantidadTotal;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Cliente: {nombre} | Saldo: {cantidadTotal}€");
        }
    }

    // Clase Banco
    public class Banco
    {
        private Cliente cliente1;
        private Cliente cliente2;
        private Cliente cliente3;

        public Banco()
        {
            // El constructor crea tres instancias de Cliente con sus nombres
            cliente1 = new Cliente("Ana Martínez");
            cliente2 = new Cliente("Carlos Gómez");
            cliente3 = new Cliente("Lucía Fernández");
        }

        public void Operar()
        {
            // Simulación de ingresos
            cliente1.Ingresar(1500.50);
            cliente2.Ingresar(2300.00);
            cliente3.Ingresar(850.75);

            // Simulación de reintegro (opcional)
            cliente2.Sacar(300.00);
        }

        public void ObtenerEstado()
        {
            double totalBanco = cliente1.GetCantidadTotal() + cliente2.GetCantidadTotal() + cliente3.GetCantidadTotal();

            Console.WriteLine("===========================================");
            Console.WriteLine("           ESTADO DEL BANCO");
            Console.WriteLine("===========================================");
            Console.WriteLine($"Dinero total en el banco (suma de clientes): {totalBanco}€");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Detalle por cliente:");
            Console.WriteLine($"• {cliente1.GetCantidadTotal()}€");
            cliente1.MostrarInformacion();
            Console.WriteLine($"• {cliente2.GetCantidadTotal()}€");
            cliente2.MostrarInformacion();
            Console.WriteLine($"• {cliente3.GetCantidadTotal()}€");
            cliente3.MostrarInformacion();
            Console.WriteLine("===========================================");
        }

        // Método Main de la aplicación
        public static void Main(string[] args)
        {
            Banco miBanco = new Banco();
            miBanco.Operar();
            miBanco.ObtenerEstado();
        }
    }
}
