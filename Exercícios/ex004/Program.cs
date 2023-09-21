class Metodo {
    public static void Main()
    {
        Console.WriteLine("Digite um número");
        int NrDigitado = int.Parse(Console.ReadLine());
        Dobro (NrDigitado);
        Metade(NrDigitado);
        Tabuada(NrDigitado);
    }

    public static void Dobro(int n)
    {
        Console.WriteLine(n * 2);
    }

    public static void Metade(int n) 
    {
        Console.WriteLine(n / 2);
    }
    
    public static void Tabuada(int num)
    {
        int cont = 1;

        while (cont <= 10)
        {
            Console.WriteLine($"{num} x {cont} = {cont * num}");
            cont++;
        }
    }
}
