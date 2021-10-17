using System;
using System.Globalization;

namespace Course_60 {
    class Conta {
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public Conta(int numConta, string titular) {
            NumeroConta = numConta;
            Titular = titular;
        }

        public Conta(int numConta, string titular, double depoIni) : this(numConta, titular) {
            Deposito(depoIni);
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= saque + 5.0;
        }

        public override string ToString() {
            return $"Conta {NumeroConta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
