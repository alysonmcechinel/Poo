using System.Numerics;

// CLASSE E OBJETOS

// var pessoa = new Pessoa()
// {
//     Nome = "Teste 1",
//     Profissao = "Dev Pleno",
//     Telefone = "8888-3333"
// };

var pessoa = new Pessoa();

// ??= é utilizado se o campo Nome estiver nulo ele seta esse novo valor, sem precisar de um if de verificação.
pessoa.Nome ??= "Alyson";
pessoa.Profissao = "Dev Pleno";
pessoa.Telefone = "9999-2222";

pessoa.Apresentar();
pessoa.Apresentar("Ciclano");

var pessoa2 = new Pessoa("Matias", "Dev Junior", "2222-4444");

pessoa2.Apresentar();


var funcionario = new Funcionario("Alyson Funcionario", "Dev Pleno", "3333-2222", 6500);

// funcionario.Nome = "Alyson Funcionario";
// funcionario.Profissao = "Dev Pleno";
// funcionario.Telefone = "9999-2222";
// funcionario.Salario = 15000;

// Abstração
funcionario.Apresentar();

// Polimorfismo

Pessoa[] pessoas = { pessoa, funcionario };

foreach (var p in pessoas)
{
    p.Apresentar();
}


public class Pessoa
{
    public Pessoa() { } // deixa inicializar var pessoa = new Pessoa();

    public Pessoa(string nome, string profissao, string telefone) // deixa inicializar apenas com o construtor passando os parametros
    {
        Nome = nome;
        Profissao = profissao;
        Telefone = telefone;
    }

    public string Nome { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }

    public virtual void Apresentar()
    {
        Console.WriteLine(FormatarMensagem());
    }

    // Overload
    public void Apresentar(string nome)
    {
        Console.Write($"Olá, {nome}: {FormatarMensagem()}");
    }

    // Encapsulamento 
    private string FormatarMensagem()
    {
        return $"{Nome}, {Profissao}, {Telefone}";
    }
}

// HERANÇA

public class Funcionario : Pessoa
{
    public Funcionario(string nome, string profissao, string telefone, int salario) : base(nome, profissao, telefone)
    {
        Salario = salario;
    }

    public int Salario { get; set; }

    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"Salario: {Salario}");
    }
}