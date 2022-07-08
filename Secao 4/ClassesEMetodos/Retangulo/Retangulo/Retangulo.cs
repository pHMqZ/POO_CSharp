using System;
using System.Collections.Generic;
using System.Text;

namespace Retangulo {
    class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {
            return Altura * Largura;
        }

        public double Perimetro() {
            return (Largura + Altura) * 2;
        }

        public double Diagonal() {
            return Math.Sqrt(Largura * Largura + Altura + Altura);

        }
    }
}
