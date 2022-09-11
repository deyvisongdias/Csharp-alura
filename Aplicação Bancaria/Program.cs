using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aplicação_Bancaria.Entities;

namespace Aplicação_Bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Administrador adm = new Administrador("Deyvison Gregorio Dias", "deyvisondias@hotmail.com");
            ContaCorrente cc = new ContaCorrente(1, "Deyvison Gregorio Dias", 1345, 12345, 2791.9);
            ContaPoupanca cp = new ContaPoupanca(2, "Sonia Aparecida Gregorio", 1234, 9876, 1700.0, 100.0);
            adm.criaCliente(1, "Deyvison Gregorio Dias", 22, 14382336635, 21015819, "Desenvolvedor",cc);
            adm.criaCliente(2, "Sonia Aparecida Gregorio",45, 05519548684, 00000000, "cozinheira", cp);

            adm.listaClientes();


            /*
            List<ContaCorrente> lista = new List<ContaCorrente>();

            ContaCorrente cc = new ContaCorrente(1, "Deyvison Gregorio Dias", 1345, 12345, 2791.9);
            ContaPoupanca cp = new ContaPoupanca(2, "Sonia Aparecida Gregorio", 1234, 9876, 1700.0, 100.0);
            Cliente cliente = new Cliente(1, "Deyvison Gregorio Dias", 22, 14382336635, 21015819, "Desenvolvedor", cp);
            Console.WriteLine(cliente.toString());
    
             lista.Add(cp);

             string text=" ";
             foreach (var item in lista)
             {
                 // Console.WriteLine(item.toString());
                 text = item.toString();
                 //Console.WriteLine("\n");
             }


             File.WriteAllText("filename.txt",text);
             string readText = File.ReadAllText("filename.txt"); 
             Console.WriteLine(readText);*/




        }
    }
}
