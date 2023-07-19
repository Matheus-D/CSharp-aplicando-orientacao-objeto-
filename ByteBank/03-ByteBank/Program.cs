using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.Titular = "Gabriela";
            contaDaGabriela.Agencia = 863;
            contaDaGabriela.Numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.Titular = "Gabriela";
            contaDaGabrielaCosta.Agencia = 863;
            contaDaGabrielaCosta.Numero = 863452;

            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);
            Console.ReadLine();

            contaDaGabriela.Saldo = 300;
            Console.WriteLine(contaDaGabriela.Saldo);
            Console.WriteLine(contaDaGabrielaCosta.Saldo);

            if (contaDaGabriela.Saldo >= 100)
            {
                contaDaGabriela.Saldo -= 100;
            }

            Console.ReadLine();

        }
    }
}
