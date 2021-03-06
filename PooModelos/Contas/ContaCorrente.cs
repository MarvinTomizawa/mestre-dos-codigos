using System;

namespace PooModelos.Contas
{
    public class ContaCorrente: ContaBancaria
    {
        public double TaxaDeOperacao { get; set; }
        
        public override double Sacar(double quantidadeSacada)
        {
            if (Saldo - quantidadeSacada - TaxaDeOperacao < 0)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            Saldo -= (quantidadeSacada + TaxaDeOperacao);

            return Saldo;
        }

        public override void Depositar(double quantidadeDepositada)
        {
            Saldo += quantidadeDepositada;

            Saldo -= TaxaDeOperacao;
        }

        public override string ToString()
        {
            return $"Conta corrente: {base.ToString()} TaxaOperacao:{TaxaDeOperacao}";
        }
    }
}