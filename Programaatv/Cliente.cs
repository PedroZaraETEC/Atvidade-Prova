using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programaatv
{
    internal class Cliente : Pessoa
    {
        public string cpf;
        public string rg;

        public void criaCliente(string cpf, string nome)
        {
            this.nome = nome;
            this.cpf = cpf;

            Console.WriteLine($"Cliente cadastrado\n\nNome: {this.nome}\nCPF: {this.cpf}");
        }

        public void setarDados()
        {

        }
    }
}
