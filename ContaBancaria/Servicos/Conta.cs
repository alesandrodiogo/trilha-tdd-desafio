using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContaBancaria.Servicos
{
    public class Conta
    {
        public int Id { get; set; }
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public List<decimal> SaldoConta { get;}

        public Conta(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
            SaldoConta = new List<decimal>();
        }

        public decimal Depositar(int numeroConta, decimal valor)
        {
            var saldo = Saldo += valor;
            SaldoConta.Insert(0, Saldo);

            return saldo;
        }

        public decimal Sacar(int numeroConta, decimal valor)
        {
            var saldo = Saldo -= valor;
            SaldoConta.Insert(0, Saldo);

            return saldo;
        }

        public decimal ConsultarSaldo()
        {
            return SaldoConta.Count;
        }

    }
}