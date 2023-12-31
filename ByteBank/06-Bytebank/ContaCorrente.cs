﻿using _06_ByteBank;


namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int Agencia;
        public int Numero;
        private double Saldo = 100;

         public void DefinirSaldo(double Saldo)
        {
            if(Saldo < 0)
            {
                return;
            }
            else
            {
                this.Saldo = Saldo;
            }
        }
        public double ObterSaldo()
        {
            return Saldo;
        }

        public bool Sacar(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }
            else
            {
                Saldo = valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Saldo < valor)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}
