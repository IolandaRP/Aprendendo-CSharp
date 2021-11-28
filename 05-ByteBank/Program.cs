using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente1 = new Cliente();
            cliente1.nome = "Gabriela";
            cliente1.profissao = "Desenvolvedora C#";
            cliente1.cpf = "283.643.542-20";

            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = cliente1;
            conta1.saldo = 500;
            conta1.agencia = 563;
            conta1.numeroConta = 563427;

            Console.WriteLine("Nome titular: " + cliente1.nome);
            Console.WriteLine("Nome titular: " + conta1.titular.nome);

            Console.ReadLine();
        }
    }
}
