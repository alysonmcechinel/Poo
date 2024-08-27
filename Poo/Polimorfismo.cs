using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    // Sobrecarga de métodos (Overload)
    public class Calculadora
    {
        // Método que soma dois inteiros
        public int Somar(int a, int b) => a + b;

        // Método que soma três inteiros
        public int Somar(int a, int b, int c) => a + b + c;

        // Método que soma dois números double
        public double Somar(double a, double b) => a + b;
    }

    // Sobrescrita de Métodos (Override)
    // Classe base
    public class CaixaDeSom
    {
        // Método virtual permite que seja sobrescrito em uma classe derivada
        public virtual void EscutarMusica() => Console.WriteLine("A caixa de som toca a musica");
    }

    // Classe derivada
    public class JBL : CaixaDeSom
    {
        // Sobrescrevendo o método EscutarMusica da classe base
        public override void EscutarMusica() => Console.WriteLine("JBL toca a musica");
    }

    // Classe derivada
    public class Fone : CaixaDeSom
    {
        // Sobrescrevendo o método EscutarMusica da classe base
        public override void EscutarMusica() => Console.WriteLine("Fone toca a musica");
    }
}
