using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    // Exemplo de Classe Abstrata
    public abstract class ContaBancaria
    {
        public string NumeroDaConta { get; set; }

        // Exemplo de encapsulamento
        // protected: O membro pode ser acessado dentro da própria classe e por classes derivadas.
        // O set de SaldoChequeEspecial é protegido, ou seja, ele só pode ser modificado dentro da classe base ou derivada.
        public decimal SaldoChequeEspecial { get; protected set; } 
        public decimal Saldo { get; set; }

        // Métodos abstratos que devem ser implementados pelas classes derivadas
        public abstract void Sacar(decimal quantia);
        public abstract void Depositar(decimal quantia);
    }

    // A classe derivada ContaCorrente herda de ContaBancaria
    // Ela deve implementar todos os métodos abstratos da classe base
    public class ContaCorrente : ContaBancaria
    {
        public override void Sacar(decimal quantia) => Saldo -= quantia;

        public override void Depositar(decimal quantia) => Saldo += quantia;

        public void MostrarSaldo() => Console.WriteLine($"Sua conta: {NumeroDaConta}, esta com saldo de: {Saldo} e com valor de cheque especial de {SaldoChequeEspecial}");
    }
}
