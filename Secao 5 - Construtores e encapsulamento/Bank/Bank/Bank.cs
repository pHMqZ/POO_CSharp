using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Bank {
    class Bank {

        public int Numero { get; private set; }
        public String Titular { get; set; }
        public double Saldo { get; private set; }

        public Bank(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public Bank (int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular"
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
