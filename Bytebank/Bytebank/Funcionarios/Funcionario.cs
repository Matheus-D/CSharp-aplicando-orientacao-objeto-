using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get;  private set; }

        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public Funcionario(double salario , string cpf) 
        {
            Console.WriteLine("Criando Funcionários");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
      
    }
}
