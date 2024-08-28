using System.Numerics;
using Poo;

Console.WriteLine($"Exemplo de herança");

// Criando uma instância de Cachorro usando o construtor padrão da classe base Animal
var cachorro = new Cachorro();
cachorro.Nome = "Rex";

// Criando uma instância de Gato usando o construtor que requer um nome
var gato = new Gato("Xaninha");

cachorro.Comer(); // Método herdado da classe base Animal
cachorro.Latir(); // Método específico da classe Cachorro

gato.Comer(); // Método herdado da classe base Animal
gato.Miar(); // Método específico da classe Gato

Console.WriteLine($"\n---------------------------------------------\n");
Console.WriteLine($"Exemplo classe abstrata:");

// var contaBancaria = new ContaBancaria(); // Erro de compilação, pois não é possível instanciar uma classe abstrata diretamente.
var conta = new ContaCorrente();

conta.NumeroDaConta = "Teste 123456";
conta.Saldo = 1600;
// conta.SaldoChequeEspecial = 2000; // Exemplo de encapsulamento. Não é possível definir SaldoChequeEspecial diretamente porque o set é protegido (protected).

conta.Sacar(1500);
conta.Depositar(500);
conta.MostrarSaldo();

Console.WriteLine($"\n---------------------------------------------\n");
Console.WriteLine($"Exemplo encapsulamento:");

var funcionario = new Funcionario();
funcionario.Nome = "Alyson";
funcionario.SetCPF("12345678901");

// Não é possível acessar diretamente Idade (é protected)
// funcionario.Idade = 30; // Isso causaria um erro de compilação.

funcionario.Aniversario();
funcionario.ExibirInformacoes();

Console.WriteLine($"\n---------------------------------------------\n");
Console.WriteLine("Exemplo polimorfismo:");

// Exemplo de sobrecarga de métodos (Overload)
var calc = new Calculadora();

Console.WriteLine(calc.Somar(2, 3)); // Chama Somar(int, int)
Console.WriteLine(calc.Somar(2, 3, 4)); // Chama Somar(int, int, int)
Console.WriteLine(calc.Somar(2.5, 3.7)); // Chama Somar(double, double)

// Exemplo de sobrescrita de métodos (Override)
var caixa = new CaixaDeSom();
var fone = new Fone();
var jbl = new JBL();

// Cada objeto usa a implementação apropriada de EscutarMusica
caixa.EscutarMusica(); // Chama o método da classe base CaixaDeSom
fone.EscutarMusica(); // Chama o método sobrescrito em Fone
jbl.EscutarMusica(); // Chama o método sobrescrito em JBL

Console.WriteLine($"\n---------------------------------------------\n");