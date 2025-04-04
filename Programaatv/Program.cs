using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programaatv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            char voltar = 'i';

            while (voltar != 'Q')
            {
            Console.WriteLine("\t\t----Menu----\t\t\n\nBem vindo ao menu principal, aqui você conseguirá" +
                "\ncriar um novo cliente, fornecedor, produto ou uma\nnota fiscal\n\n" +
                "Digite abaixo oque deseja fazer: \n\n" +
                "1 - Criar um novo fornecedor\n" +
                "2 - Criar um novo cliente\n" +
                "3 - Criar uma nota fiscal\n " +
                "4 - Tudo de uma vez\n" +
                "5 - Sair\n\n");

                Console.Write("Escolha: ");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1": 
                        Fornecedor fornecedor = new Fornecedor();

                        Console.Write("Digite seu nome: ");
                        string nome_fornecedor = Console.ReadLine();
                        Console.Write("Digite seu CNPJ: ");
                        string cnpj_fornecedor = Console.ReadLine();
                        
                        fornecedor.criaFornecedor(nome_fornecedor, cnpj_fornecedor);
                    break;

                    case "2":
                        Cliente cliente = new Cliente();

                        Console.Write("Digite seu nome: ");
                        string nome_cliente = Console.ReadLine();
                        Console.Write("Digite seu CNPJ: ");
                        string cpf_cliente = Console.ReadLine();

                        cliente.criaCliente(nome_cliente, cpf_cliente);
                        break;

                    case "3":
                        NotaFiscal nota_fiscal = new NotaFiscal();


                        nota_fiscal.criaNotaFiscal(Cliente cliente.cpf,Fornecedor fornecedor.cnpj);
                        
                        
                        break;
                }
            }

        }
    }
}
