﻿using BancoByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoByteBank.Funcionários
{
    public class GerenteDeConta : Autenticavel
    {
   
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

    }
}
