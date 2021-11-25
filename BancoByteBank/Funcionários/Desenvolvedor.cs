using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoByteBank.Funcionários
{
    public class Desenvolvedor : Funcionario
    {

        public Desenvolvedor(string cpf) : base(cpf, 4000)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }

 }

