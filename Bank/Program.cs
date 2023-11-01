using System;

class ContaBancaria
{
    private double saldo;

    // construtor que inicializa o saldo da conta com um valor inicial
    public ContaBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    // propriedade para obter o saldo atual
    public double Saldo
    {
        get { return saldo; }
    }

    // método para depositar dinheiro na conta
    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"Deposito de R${valor} realizado com sucesso");
        }
        else
        {
            Console.WriteLine("Valor de deposito invalido");
        }
    }

    // método para sacar dinheiro na conta
    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"Saque de R${valor} realizado com sucesso");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente na conta");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Banco");
        Console.WriteLine("Digite o saldo inicial da conta: ");
        double saldoInicial = double.Parse(Console.ReadLine());

        // cria uma instância da classe ContaBancaria com o saldo inicial fornecido
        ContaBancaria conta = new ContaBancaria(saldoInicial);

        while (true)
        {
            Console.WriteLine("\nEscolha uma opcao: ");
            Console.WriteLine("1. Verificar Saldo");
            Console.WriteLine("2. Depositar Dinheiro");
            Console.WriteLine("3. Sacar Dinheiro");
            Console.WriteLine("4. Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Saldo Atual: R${conta.Saldo}");
                    break;
                case 2:
                    Console.WriteLine("Digite o valor a ser depositado");
                    double valorDepositado = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDepositado);
                    break;
                case 3:
                    Console.WriteLine("Digite o valor a ser sacado: ");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;
                case 4:
                    Console.WriteLine("Obrigado por usar o banco");
                    Environment.Exit(0);
                    break;
                case 5:
                    Console.WriteLine("Opcao Invalida. Tente Novamente");
                    break;
            }
        }
    }
}
