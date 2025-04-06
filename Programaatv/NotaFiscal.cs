using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programaatv
{
    internal class NotaFiscal : Produto
    {
        public double numero;
        public Produto produto;
        public Cliente cliente = new Cliente();
        public Fornecedor fornecedor = new Fornecedor();

        public void criaNotaFiscal()
        {
            Console.Write("Digite seu CPF: ");
            string cpf_cliente = Console.ReadLine();
            Console.Write("Digite seu CNPJ: ");
            string cnpj_fornecedor = Console.ReadLine();

            cliente.cpf = cpf_cliente;
            fornecedor.cnpj = cnpj_fornecedor;

            if (cliente.cpf != null && fornecedor.cnpj != null)
            {
                Console.WriteLine($"\n\nCPF cliente: {cliente.cpf}\nCNPJ fornecedor: {fornecedor.cnpj}\n\n");
                Console.WriteLine("Nota criada");
                Thread.Sleep(2000);
            } 

            else
            {
                Console.WriteLine("Cliente ou fornecedor não foram encontrados");
                Thread.Sleep(2000);
            }

        }

        public void adicionaProduto(Produto produto)
        {
            produto = new Produto();
            Console.WriteLine("Escreva o nome do produto: ");
            string nome = Console.ReadLine();
            double valor = double.Parse(Console.ReadLine());

            produto.criaProduto(nome,valor);

            Console.WriteLine("Produto adicionado");
        }

    }
}
