namespace SistemaBancario
{
    public class ContaCorrente
    {
        private string titular;
        private double saldo;



        public ContaCorrente(string titular)
        {
            this.titular = titular;
            this.saldo = 0.0;
        }
        public void ConsutarSaldo()
        {
            Console.WriteLine($"Saldo que voce tem é de {titular} : R${saldo}.");
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito de R$ {saldo}.");
            }
            else
            {
                Console.WriteLine("O valor tem que ser maior que 0.");
            }
        }
        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                if (valor <= saldo)
                {
                    saldo -= valor;
                    Console.WriteLine($"Saque foi relizado de R${saldo}");
                }
                else if (valor > saldo)
                {
                    Console.WriteLine($"Saldo insuficiente para sacar");
                }
                else
                {
                    Console.WriteLine("O valor tem que ser maior que 0");
                }
            }
        }


    }
}
