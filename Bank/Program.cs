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
}
