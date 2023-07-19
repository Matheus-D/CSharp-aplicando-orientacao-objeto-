using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDoBruno = new ContaCorrente();
            ContaDoBruno.Titular = "Bruno";

            Console.WriteLine(ContaDoBruno.Saldo);
            bool resultadoSaque = ContaDoBruno.Sacar(500);

            Console.WriteLine(ContaDoBruno.Saldo);
            Console.WriteLine(resultadoSaque);

            ContaDoBruno.Depositar(500);
            Console.WriteLine(ContaDoBruno.Saldo);

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.Titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + ContaDoBruno.Saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaGabriela.Saldo);

            bool resultadoTransferencia = ContaDoBruno.Transferir(200, contaGabriela);
            Console.WriteLine("Saldo do Bruno: " + ContaDoBruno.Saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaGabriela.Saldo);

            Console.WriteLine("Resultado de Transferência: " + resultadoTransferencia);

            contaGabriela.Transferir(100, ContaDoBruno);
            Console.WriteLine("Saldo do Bruno: " + ContaDoBruno.Saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaGabriela.Saldo);

            Console.ReadLine();


        }
    }
}
