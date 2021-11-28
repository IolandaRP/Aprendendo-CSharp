using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            conta.Saldo = -10;
            Console.WriteLine(conta.Saldo);

            Cliente cliente = new Cliente();
            cliente.nome = "Iolanda";
            cliente.cpf = "742.399.398-39";
            cliente.profissao = "Desenvolvedora";

            conta.Titular = cliente;
            Console.WriteLine("Titular da conta: " + conta.Titular.nome);

            Console.ReadLine();
        }
    }
}
