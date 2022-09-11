using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_Bancaria.Entities
{
    internal class Administrador
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }

        public String Login;
        public String password;

        public List<Cliente> clientes = new List<Cliente>();

        public Administrador( string name, string email)
        {
            Name = name;
            Email = email;
            Login = "admin";
            password = "mudar@123";
        }

        public void criaCliente(int id, string name, int idade, ulong cpf, int rg, string observacao, ContaCorrente contaCorrente)
        { 
            Cliente cliente = new Cliente(id,name,idade,cpf,rg,observacao,contaCorrente);
            clientes.Add(cliente);
  
        }

        public void deletaCliente(ulong cpf)
        {
            foreach (var item in clientes)
            {
                if(item.Cpf == cpf)
                {
                    clientes.Remove(item);
                }
            }
            
        }


        public void listaClientes()
        {
            Console.WriteLine("Lista de clientes");
            Console.WriteLine("---------------------------------------");
            foreach (var item in clientes)
            {
                Console.WriteLine(item.toString());
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}
