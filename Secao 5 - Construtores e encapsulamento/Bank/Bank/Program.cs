using System;
using System.Globalization;

namespace Bank {
    class Program {
        static void Main(string[] args) {

            Bank conta;
            
            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depInical = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Bank(num, titular, depInical);
            } else {
                conta = new Bank(num, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
        }
    }
}
