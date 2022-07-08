using System;
using System.Collections.Generic;
using System.Text;

namespace Conversão {
    class ConversorDeMoedas {

        public static double IoF = 6.0;

        public static double DolarParaReal(double quantia, double cotacao) {
            double total = quantia * cotacao;
            return total += total * IoF / 100.0;
        } 
    }
}
