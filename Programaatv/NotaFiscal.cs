using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programaatv
{
    internal class NotaFiscal : Produto
    {
        public double numero;
        public Produto produto;

        public void criaNotaFiscal(Cliente cliente, Fornecedor fornecedor)
        {
            if (cliente.cpf != null && fornecedor.cnpj != null)
            {
                Console.WriteLine($"Nota num: {numero}\nCPF cliente: {cliente.cpf}\nCNPJ fornecedor: {fornecedor.cnpj}\n\n");
                Console.WriteLine("Nota criada");
            } 

            else
            {
                Console.WriteLine("Cliente ou fornecedor não foram encontrados");
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
