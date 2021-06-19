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
            OrganizaOrdemCrescente(entidades);
            
            Console.WriteLine("Ordem Decrescente:");
            OrganizaOrdemDecrescente(entidades);
        }

        private static void OrganizaOrdemDecrescente(IList<decimal> entidades)
        {
            var entidadesDecrescente = new List<decimal>(entidades);

            for (var i = 0; i < entidades.Count; i++)
            {
                for (var j = i; j < entidadesDecrescente.Count; j++)
                {
                    if (entidadesDecrescente[i] < entidadesDecrescente[j])
                    {
                        var valorAntigo = entidadesDecrescente[i];
                        entidadesDecrescente[i] = entidadesDecrescente[j];
                        entidadesDecrescente[j] = valorAntigo;
                    }
                }
            }
            
            foreach (var valor in entidadesDecrescente)
            {
                Console.WriteLine(valor);
            }
        }

        private static void OrganizaOrdemCrescente(IList<decimal> entidades)
        {
            var entidadesCrescente = new List<decimal>(entidades);

            for (var i = 0; i < entidades.Count; i++)
            {
                for (var j = i; j < entidadesCrescente.Count; j++)
                {
                    if (entidadesCrescente[i] > entidadesCrescente[j])
                    {
                        var valorAntigo = entidadesCrescente[i];
                        entidadesCrescente[i] = entidadesCrescente[j];
                        entidadesCrescente[j] = valorAntigo;
                    }
                }
            }
            
            foreach (var valor in entidadesCrescente)
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