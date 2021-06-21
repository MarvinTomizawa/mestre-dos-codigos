using System;

namespace PooModelos.Contas
{
    public class ContaEspecial: ContaBancaria
    {
        public double Limite { get; set; }
        
        public override double Sacar(double quantidadeSacada)
        {
            if (Saldo - quantidadeSacada < -Limite)
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            
            Saldo -= quantidadeSacada;

            return quantidadeSacada;
        }

        public override void Depositar(double quantidadeDepositada)
        {
            Saldo += quantidadeDepositada;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Limite: {Limite}";
        }
    }
}