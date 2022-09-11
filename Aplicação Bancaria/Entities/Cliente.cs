using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_Bancaria
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Idade { get; set; }

        public ulong Cpf { get; set; }

        public int Rg { get; set; }

        public string Estado { get; set; }
        public string Endereco { get; set;}
        public string Cidade { get; set; }
        public int NumeroCasa { get; set; }
         

        public ContaCorrente contaCorrente { get; set; }

        public Cliente(int id, string name, int idade, ulong cpf, int rg, string estado, string endereco, string cidade, int numeroCasa, ContaCorrente contaCorrente)
        {
            Id = id;
            Name = name;
            Idade = idade;
            Cpf = cpf;
            Rg = rg;
            Estado = estado;
            Endereco = endereco;
            Cidade = cidade;
            NumeroCasa = numeroCasa;
            this.contaCorrente = contaCorrente;
        }

        public Cliente()
        {
        }

        /*
        public string toString()
        {

            return "Nome: " + this.Name + "\n" +
                  "Idade: " + this.Idade+ "\n" +
                  "Cpf: " + this.Cpf + "\n" +
                  "Rg: " + this.Rg+"\n"+
                  "Estado: " + this.Estado + "\n" + 
                  "Endereco: " + this.Endereco + "\n" +
                  "Cidade: " + this.Cidade + "\n" +
                  "Numero da residencia: " + this.NumeroCasa + "\n" +
                  "\n"+"Informacoes da conta: "+"\n"+
                  "Conta: \n"+ this.contaCorrente.toString()+"\n";
        }
        */
    }
}
