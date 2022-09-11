using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_Bancaria
{
    internal class ContaPoupanca : ContaCorrente
    {
        public Double JurosRendimento { get; set; }

        public ContaPoupanca(int id, string name, int numeroAgencia, int numero, double saldo,Double JurosRendimento)
        {
            Id = id;
            this.name = name;
            NumeroAgencia = numeroAgencia;
            Numero = numero;
            Saldo = saldo;
            this.JurosRendimento = JurosRendimento;
        }
        public ContaPoupanca(double jurosRendimento)
        {
            JurosRendimento = jurosRendimento;
        }

        public ContaPoupanca()
        {
        }

            public string toString()
            {
                return "Nome: " + this.name + "\n" +
                       "Numero da agencia: " + this.NumeroAgencia + "\n" +
                       "Numero: " + this.Numero + "\n" +
                       "Saldo: " + this.Saldo+"\n"+
                       "Taxa de rendimento de Juros: " + this.JurosRendimento;
            }
    }
}
