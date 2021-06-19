using System;
using System.Collections.Generic;
using System.Linq;
using Abstracao;

namespace Exercicio8
{
    public class Exercicio1: DesafioCadastroEBusca<decimal>
    {
        public Exercicio1() : base("Informe a quantidade de decimais a ser inserido")
        {
        }

        public override string GetTitulo()
            => "Valores decimais crescente e decrescente";

        protected override string GetDescricao()
            => "Imprime os valores decimais em ordem crescente e decrescente";

        protected override void TrataEntidades(IList<decimal> entidades)
        {
            Console.WriteLine("Ordem original:");
            foreach (var valor in entidades)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("Ordem Crescente:");
            foreach (var valor in entidades.OrderBy(x => x))
            {
                Console.WriteLine(valor);
            }
            
            Console.WriteLine("Ordem Decrescente:");
            foreach (var valor in entidades.OrderByDescending(x => x))
            {
                Console.WriteLine(valor);
            }
        }

        protected override decimal MontaEntidadeCadastro()
        {
            return ValidadorInput.BuscaInput<decimal>("Informe um valor decimal", "O valor deve ser decimal");
        }
    }
}