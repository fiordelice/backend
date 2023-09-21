public class Program
{
    public static void Main()
    {
        try{
        Console.WriteLine("Digite um número inteiro");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Voce digitou o nº {numero}");
        }
        catch(Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro:{erro.Message}");
        }
        finally{
            Console.WriteLine($"No bloco finally o programa entra independentemente de exceção");
        }
    }
}