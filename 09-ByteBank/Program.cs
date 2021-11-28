using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        { 

            Metodo();

            Console.ReadLine();
        }


        //OUTROS MÉTODOS
        private static int Metodo()
        {
            int resultadoDivisao = TestaDivisao(0);

            if (resultadoDivisao == -2)
            {
                return -2;
            }
            return 0;
        }


        private static int TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            if(resultado == -2)
            {
                return -2;
            }

            if (resultado == -1)
            {
                Console.WriteLine("Não é possível fazer divisão por 0");
                return -1;
            }
            else
            {
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            return 0;
        }


        private static int Dividir(int numero, int divisor)
        {
            if (divisor == 0)
            {
                return -1;
            }
            if (divisor > numero)
            {
                return -2;
            } 
            return numero / divisor;
        }
    }
}
