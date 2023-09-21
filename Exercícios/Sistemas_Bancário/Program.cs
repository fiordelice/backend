using SistemaBancario;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Seja bem-vindo!");
        Console.WriteLine("Digite o nome da sua conta bancaria");
        string nomeTitular = Console.ReadLine();
        ContaCorrente conta = new ContaCorrente(nomeTitular);

        int opções = 0;

        do
        {
            Console.WriteLine("Escolha umas das opções");
            Console.WriteLine("1- Consultar saldo");
            Console.WriteLine("2- Depositar");
            Console.WriteLine("3- Sacar");
            Console.WriteLine("4- sair");

            opções = int.Parse(Console.ReadLine());

            switch (opções)
            {
                case 1:
                    conta.ConsutarSaldo();
                    break;

                case 2:
                    Console.WriteLine("Digite o valor que foi depositado:");
                    double valorDep = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDep);
                    break;

                case 3:
                    Console.WriteLine("Digite o valor que vai ser sacado");
                    double valorSaldo = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSaldo);
                    break;

            }
        } while (opções != 4);
    }
}

