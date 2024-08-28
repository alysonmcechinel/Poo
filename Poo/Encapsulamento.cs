using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Pessoa
    {
        // Propriedade privada: só pode ser setada (atribuida) dentro da própria classe.
        public string Cpf { get; private set; }

        // Propriedade pública: pode ser setada (atribuida) de qualquer lugar.
        public string Nome { get; set; }

        // Propriedade protegida: pode ser setada (atribuida) na classe base e em classes derivadas.
        public int Idade { get; protected set; }

        // Método público para definir o CPF (encapsula a lógica de validação)
        public void SetCPF(string cpf)
        {
            if (ValidarCPF(cpf))
                Cpf = cpf;
            else
                Console.WriteLine("CPF invalido!");
        }

        // Método privado: só pode ser acessado dentro da própria classe.
        private bool ValidarCPF(string cpf) => cpf.Length == 11;
    }

    public class Funcionario : Pessoa
    {
        // Método público que acessa e modifica o campo protegido Idade.
        public void Aniversario() => Idade++;

        // Método para exibir informações do funcionário
        public void ExibirInformacoes() => Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, CPF: {Cpf}");
    }
}
