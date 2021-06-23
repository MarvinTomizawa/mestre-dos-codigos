using System;
using PooModelos.Interfaces;

namespace PooModelos.Pessoas
{
    public class Pessoa: Imprimivel
    {
        public  string Nome { get; set; }

        public  DateTime DataNascimento { get; set; }

        public  decimal Altura { get; set; }

        public int GetIdade () => new DateTime(DateTime.Now.Subtract(DataNascimento).Ticks).Year;
        
        public override string ToString()
        {
            return $"Pessoa: Nome: {Nome}  DataNascimento: {DataNascimento} Idade: {GetIdade()}  Altura: {Altura}";
        }

        public void MostraDados()
        {
            Console.WriteLine(ToString());
        }
    }
}