using System;

namespace Banco
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre del titular de la cuenta:");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("Numero de la cuenta:");
            int numeroCuenta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saldo de la cuenta:");
            double saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cantidad a depositar:");
            double deposito = Convert.ToDouble(Console.ReadLine());            

            CuentaBancaria cuenta = new CuentaBancaria(nombre, numeroCuenta, saldo, deposito);

            cuenta.Deposito(deposito);
            cuenta.MostrarInfo();

            while (true)
            {
                Console.WriteLine("Desea hacer otro deposito? (s/n)");
                string respuesta = Console.ReadLine();

                if (respuesta == "s")
                {
                    Console.WriteLine("Cantidad a depositar:");
                    double deposito2 = Convert.ToDouble(Console.ReadLine());
                    cuenta.Deposito(deposito2);
                    Console.WriteLine($"El saldo actual es: {cuenta.saldoActual}");
                }
                else
                {
                    break;
                }
            }
        }
    }

    public class CuentaBancaria
    {
        public string nombre;
        public int numeroCuenta;
        public double saldo, deposito, saldoActual;

        public CuentaBancaria(string nombre, int numeroCuenta, double saldo, double deposito)
        {
            this.nombre = nombre;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
            this.deposito = deposito;
            this.saldoActual = saldo;
        }

        public void Deposito(double deposito)
        {
            saldoActual += deposito;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"El titular se llama: {nombre}");
            Console.WriteLine($"El numero de cuenta es: {numeroCuenta}");
            Console.WriteLine($"El saldo actual es: {saldo}");
            Console.WriteLine($"El deposito fue de: {deposito}");
            Console.WriteLine($"El saldo actual es: {saldoActual}");
        }
    }
}