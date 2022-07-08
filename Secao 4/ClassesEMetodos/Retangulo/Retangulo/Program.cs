using System;
using System.Globalization;

namespace Retangulo {
    class Program {
        static void Main(string[] args) {

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
