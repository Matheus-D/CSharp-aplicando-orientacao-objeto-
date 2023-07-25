﻿using Bytebank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");

        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
       
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
