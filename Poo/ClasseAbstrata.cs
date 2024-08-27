using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public abstract class ContaBancaria
    {
        public string NumeroDaConta { get; set; }

        // exemplo de encapsulamento
        // protected: O membro pode ser acessado dentro da mesma classe e por classes derivadas. 
        public decimal SaldoChequeEspecial { get; protected set; } 
        public decimal Saldo { get; set; }

        public abstract void Sacar(decimal quantia);
        public abstract void Depositar(decimal quantia);
    }

    public class ContaCorrente : ContaBancaria // se não implementar os membros da classe pai "abstratos" da erro
    {
        public override void Sacar(decimal quantia) => Saldo -= quantia;

        public override void Depositar(decimal quantia) => Saldo += quantia;

        public void MostrarSaldo()
        {
            Console.WriteLine($"Sua conta: {NumeroDaConta}, esta com saldo de: {Saldo} e com valor de cheque especial de {SaldoChequeEspecial}");
        }
    }
}
