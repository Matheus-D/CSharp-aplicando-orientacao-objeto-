using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           // Cliente Gabriela = new Cliente();

            //Gabriela.Nome = "Gabriela";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = Gabriela;
            //conta.titular = new Cliente();
            
            //conta.titular.Nome = "Gabriela Costa";
            //conta.titular.Cpf = "434.562.878-20";
            //conta.titular.Profissao = "Desenvolvedora C#";

            conta.Saldo = 500;
            conta.Agencia = 563;
            conta.Numero = 5634527;

            if(conta.titular == null)
            {
                Console.WriteLine("Ops, a refência em conta.titular é NULL");
            }


            //Console.WriteLine(Gabriela.Nome);
            Console.WriteLine(conta.titular);
            //Console.WriteLine(conta.titular.Nome);
            //Console.WriteLine(conta.titular.Cpf);
            //Console.WriteLine(conta.titular.Profissao);

            Console.ReadLine();


        }
    }
}
