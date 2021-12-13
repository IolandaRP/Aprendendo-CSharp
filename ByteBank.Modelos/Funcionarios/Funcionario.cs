using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class Funcionario
    {
        public String Nome { get; set; }
        public String CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int totalFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
            totalFuncionarios++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

    }
}
