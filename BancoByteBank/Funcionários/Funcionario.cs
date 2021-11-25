using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoByteBank.Funcionários
{
    public abstract class Funcionario
    {
        public String Nome { get; set; }
        public String CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int totalFuncionarios { get; private set;}
        public string Senha { get; set; }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
            totalFuncionarios++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

        public bool Autenticar(string senha)
        {
            if (Senha == senha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /* método virtual pq permite que seja sobrescrito
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }*/

    }
}
