using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            // conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "273.642.832-90";
            conta.titular.profissao = "Desenvolvedora C#";
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numeroConta = 563427;
            conta.Depositar(500);

            Console.WriteLine("Nome do titular: " + conta.titular.nome);
            Console.WriteLine("Saldo da conta: " + conta.saldo);

            Console.ReadLine();
        }
    }
}
