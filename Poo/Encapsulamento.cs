using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Pessoa
    {
        // privado - só pode ser setado dentro da própria classe
        public string Cpf { get; private set; }

        // pública - pode ser setada de qualquer lugar
        public string Nome { get; set; }

        // protegida - pode ser setada na classe base e em classes derivadas
        public int Idade { get; protected set; }

        // Método público para definir o CPF (encapsula a lógica de validação)
        public void SetCPF(string cpf)
        {
            if (ValidarCPF(cpf))
                Cpf = cpf;
            else
                Console.WriteLine("CPF invalido!");
        }

        // Método privado - só pode ser acessado dentro da própria classe
        private bool ValidarCPF(string cpf) => cpf.Length == 11;
    }

    public class Funcionario : Pessoa
    {
        // Método público que acessa o campo protegido Idade
        public void Aniversario() => Idade++;

        // Método para exibir informações do funcionário
        public void ExibirInformacoes() => Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, CPF: {Cpf}");
    }
}
