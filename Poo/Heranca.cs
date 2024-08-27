using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    // Classe base
    public class Animal
    {
        public Animal() { } // construtor 1: deixa inicializar var animal = new Animal();

        public Animal(string nome) // construtor 2: tera que inicializar passando o parametro var animal = new Animal("Rex"); exemplo gato.
        {
            Nome = nome;
        }

        public string Nome { get; set; }


        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo");
        }
    }

    // Classe derivada
    public class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine($"{Nome} está latindo");
        }
    }

    // Classe derivada
    public class Gato : Animal
    {
        public Gato(string nome) : base(nome)
        {
        }

        public void Miar()
        {
            Console.WriteLine($"{Nome} está miando");
        }
    }
}
