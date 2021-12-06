using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

            Console.ReadLine();
        }


        //OUTROS MÉTODOS

        private static void CarregarContas()
        {
            LeitorDeArquivos leitor = null;
            try
            {
                leitor = new LeitorDeArquivos("contas.txt");
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            catch (IOException)
            {
                Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            }
            finally //esse bloco SEMPRE é executado, ocorra ou não uma exceção.
            {
                if (leitor != null)
                {
                    leitor.Fechar();
                }
            }
            
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(123, 12345);
                ContaCorrente conta2 = new ContaCorrente(456, 56789);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                //Console.WriteLine("Informações da INNER EXCEPTION");
                // Console.WriteLine(e.InnerException.Message);
            }
        }

        private static void Metodo()
        {
             TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + "é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch(DivideByZeroException erro)
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
            }
            
        }
    }
}
