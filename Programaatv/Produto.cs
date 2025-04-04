using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programaatv
{
    internal class Produto
    {
        public string descricao;
        public double valor;

        public void criaProduto (string descricao, double valor)
        {
            this.descricao = descricao;
            this.valor = valor;

            Console.WriteLine("Produto criado");
        }
    }
}
