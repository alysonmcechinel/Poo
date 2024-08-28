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
        // Construtor padrão: permite criar uma instância de Animal sem passar nenhum parâmetro.
        // Exemplo: Classe Cachorro
        // var animal = new Animal();
        public Animal() { }

        // Construtor com parâmetro: exige que o nome seja fornecido ao criar uma instância.
        // Exemplo: var animal = new Animal("Rex");
        // Exemplo: Classe Gato
        public Animal(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        // Método que pode ser chamado por qualquer classe derivada
        public void Comer() => Console.WriteLine($"{Nome} está comendo");
        
    }

    // Classe derivada
    public class Cachorro : Animal
    {
        // Método específico da classe Cachorro
        public void Latir() => Console.WriteLine($"{Nome} está latindo");
    }

    // Classe derivada
    public class Gato : Animal
    {
        // Construtor que utiliza o construtor da classe base (Animal)
        public Gato(string nome) : base(nome)
        {
        }

        // Método específico da classe Gato
        public void Miar() => Console.WriteLine($"{Nome} está miando");
        
    }
}
