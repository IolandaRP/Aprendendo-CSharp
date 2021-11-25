using BancoByteBank.Funcionários;
using BancoByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor diretor = new Diretor("832.434.754-43", 5000);
            diretor.Nome = "Roberta";
            diretor.Senha = "123";
            sistema.Logar(diretor, "123");
            sistema.Logar(diretor, "abc");


            GerenteDeConta gerente = new GerenteDeConta("646.345.645-89");
            gerente.Nome = "Camila";
            gerente.Senha = "456";
            sistema.Logar(gerente, "123");


        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer designer = new Designer("877.323.531-39");
            designer.Nome = "Pedro";

            Diretor diretor = new Diretor("832.434.754-43", 5000);
            diretor.Nome = "Roberta";

            Auxiliar auxiliar = new Auxiliar("374.324.242-90");
            auxiliar.Nome = "Igor";

            GerenteDeConta gerente = new GerenteDeConta("646.345.645-89");
            gerente.Nome = "Camila";

            gerenciador.Registrar(designer);
            gerenciador.Registrar(diretor);
            gerenciador.Registrar(auxiliar);
            gerenciador.Registrar(gerente);

            Console.WriteLine("Total de bonificações do mês: "+ gerenciador.getTotalBonificacao());
        }
    }
}
