using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_Bancaria
{
    internal class ContaEmpresarial : ContaCorrente
    {
        public double ValorInvestimento { get; set; }
        public ContaEmpresarial(double valorInvestimento)
        {
            ValorInvestimento = valorInvestimento;
        }

        public void aumentaInvestimento(double value)
        {
            this.ValorInvestimento += value;
        }

        public void diminuiInvestimento(double value)
        {
            if (this.ValorInvestimento - value >= 0)
            {
                this.ValorInvestimento += value;
            }
        }

        public string toString()
        {
            return "Nome: " + this.name + "\n" +
                   "Numero da agencia: " + this.NumeroAgencia + "\n" +
                   "Numero: " + this.Numero + "\n" +
                   "Saldo: " + this.Saldo + "\n" +
                   "Valor de investimento :" + this.ValorInvestimento + "\n";
        }
    }
}
