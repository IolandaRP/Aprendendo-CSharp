using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();
            c1.titular = "Gabriela";
            c1.agencia = 863;
            c1.numeroConta = 863145;
            c1.saldo = 100;

            Console.WriteLine("-------------Dados da conta 1-------------");
            Console.WriteLine("Titular: " + c1.titular 
                + "/ Agência: " + c1.agencia 
                +"/ Número da conta: " + c1.numeroConta 
                +"/ Saldo: " + c1.saldo);

            Console.ReadLine();
        }
    }
}
