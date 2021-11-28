using System;

namespace _08___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Iolanda";
            cliente.Cpf = "831.343.453-45";
            cliente.Profissao = "Desenvolvedora";

            conta.Titular = cliente;
            conta.Saldo = 5000;
            conta.Agencia = 564;

            Console.WriteLine("Titular: " + conta.Titular.Nome);
            Console.WriteLine("Saldo: " + conta.Saldo);

            Console.ReadLine();
        }
    }
}
