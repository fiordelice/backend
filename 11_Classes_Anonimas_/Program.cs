public class Program
{
    public static void Main()
    {
        var pessoa1 = new
        {
            nome = "Gabriella",
            idade = 20,
            data = 2027
        };
        var pessoa2 = new
        {
            nome = "Fiordelice",
            idade = 20,
            data = 2007
        };
        Console.WriteLine($"A Pessoa 1 tem {pessoa1.idade} anos e a pessoa 2 tem {pessoa2.idade} anos");
        Console.WriteLine($"A Pessoa 1 nasceu em {pessoa1.data} anos e a pessoa 2 nasceu em  {pessoa2.data}");

Console.WriteLine("Digite o nome do carro");
string nomeDigite = Console.ReadLine();
Console.WriteLine("Digite o modelo do carro");
string modeloDigite = Console.ReadLine();
Console.WriteLine("Digite o ano do carro");
string anoDigite = Console.ReadLine();
Console.WriteLine("Digite a cor do carro");
string corDigite = Console.ReadLine();
        var carro1 = new
        {
            nome = nomeDigite,
            modelo = modeloDigite,
            ano = anoDigite,
            cor = corDigite
        };
        Console.WriteLine($"Meu Carro da marca {carro1.nome} o modelo {carro1.modelo} foi fabricado em {carro1.ano} a cor dele é {carro1.cor}");
    }

} 