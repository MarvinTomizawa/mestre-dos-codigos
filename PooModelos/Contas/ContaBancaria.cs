using System;
using PooModelos.Interfaces;

namespace PooModelos.Contas
{
    public abstract class ContaBancaria: Imprimivel
    {
        public long NumeroConta { get; set; }

        public double Saldo { get; set; }

        public abstract double Sacar(double quantidadeSacada);

        public abstract void Depositar(double quantidadeDepositada);
        
        public void MostraDados()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"NumeroConta: {NumeroConta}  Saldo: {Saldo}";
        }
    }
}