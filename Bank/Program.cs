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

    }
}
