using System.Numerics;
using Poo;

Console.WriteLine($"Exemplo de herança");

// Criando uma instância
var cachorro = new Cachorro();
cachorro.Nome = "Rex";

// Criando uma instância
var gato = new Gato("Xaninha");

cachorro.Comer(); // Método herdado da classe Animal
cachorro.Latir(); // Método específico da classe Cachorro

gato.Comer(); // Método herdado da classe Animal
gato.Miar(); // Método específico da classe Gato

Console.WriteLine($"\n---------------------------------------------\n");
Console.WriteLine($"Exemplo classe abstrata:");

// var contaBancaria = new ContaBancaria(); // erro de compilação não consegue instanciar uma classe abstrata
var conta = new ContaCorrente();

conta.NumeroDaConta = "Teste 123456";
conta.Saldo = 1600;
// conta.SaldoChequeEspecial = 2000; //exemplo de encapsulamento aonde uma propriedade com  "set protected" não consigo instanciar

conta.Sacar(1500);
conta.Depositar(500);
conta.MostrarSaldo();

Console.WriteLine($"\n---------------------------------------------\n");
Console.WriteLine($"Exemplo encapsulamento:");

var funcionario = new Funcionario();
funcionario.Nome = "Alyson";
funcionario.SetCPF("12345678901");

// Não é possível acessar diretamente Idade (é protected)
// funcionario.Idade = 30; // Isso causaria um erro de compilação

funcionario.Aniversario();
funcionario.ExibirInformacoes();

Console.WriteLine($"\n---------------------------------------------\n");
Console.WriteLine("Exemplo polimorfismo:");

// Overload
var calc = new Calculadora();

Console.WriteLine(calc.Somar(2, 3)); // Chama Somar(int, int)
Console.WriteLine(calc.Somar(2, 3, 4)); // Chama Somar(int, int, int)
Console.WriteLine(calc.Somar(2.5, 3.7)); // Chama Somar(double, double)

// Override 
var caixa = new CaixaDeSom();
var fone = new Fone();
var jbl = new JBL();

caixa.EscutarMusica();
fone.EscutarMusica();
jbl.EscutarMusica();

Console.WriteLine($"\n---------------------------------------------\n");