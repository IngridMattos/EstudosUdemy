using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Drawing;

namespace EstudosUdemy
{
    class ContaBanco {
        public int NumeroConta { get; private set; }
        public String NomeDoTitular { get; set; }
        public double Saldo { get; private set; }


        public ContaBanco(int numeroConta, string nomeDoTitular) 
            {
            NumeroConta = numeroConta;
            NomeDoTitular = nomeDoTitular;
            Saldo = 0.0; // Não precisa pois por padrão o double já seria 0
        }

        public ContaBanco(int numeroConta, string nomeDoTitular, double saldo) : this(numeroConta, nomeDoTitular) {
            Deposito(saldo);// quem tem a responsabilidade de adicionar o saldo é o método depósito
        }
        public void Deposito(double valor) {
            Saldo += valor;
        }
        public void Saque(double valor) {
            Saldo -= valor + 5.0;
        }
        override public string ToString() {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + NomeDoTitular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
