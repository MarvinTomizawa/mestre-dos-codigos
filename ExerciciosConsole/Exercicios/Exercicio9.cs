using System;
using System.Collections.Generic;
using Abstracao;
using ExerciciosConsole.Servicos;

namespace ExerciciosConsole.Exercicios
{
    public class Exercicio9 : DesafioCadastroEBusca<int>
    {
        public Exercicio9() : base("Informe a quantidade de números para o desafio")
        {
        }

        public override string GetTitulo()
            => "Linq";

        protected override string GetDescricao()
            => "Desafios feitos com Linq";

        protected override void TrataEntidades(IList<int> entidades)
        {
            var numeroInicio = ValidadorInput.BuscaInput<int>("Insira um numero inteiro no inicio da lista",
                "O numero deve ser inteiro");

            var numeroFim = ValidadorInput.BuscaInput<int>("Informe um numero para inserir no fim da lista",
                "O numero deve ser inteiro");

            var numeroBusca =
                ValidadorInput.BuscaInput<int>("Informe um numero para busca na lista", "O numero deve ser inteiro");

            Console.WriteLine("Numeros da lista");
            MostraTodosNumerosNaLista(entidades);

            MostraNaOrdemCrescente(entidades);

            MostraOrdemDecrescente(entidades);

            MostraPrimeiroNumeroDaLista(entidades);

            MostraUltimoNumeroDaLista(entidades);

            InsereNumeroNoInicioDaLista(entidades, numeroInicio);

            InsereNumeroNoFimDaLista(entidades, numeroFim);

            RemovePrimeiroItemDaLista(entidades);

            RemoveOUltimoItemDaLista(entidades);

            MostraNumerosPares(entidades);

            RetornaApenasNumeroInformado(entidades, numeroBusca);

            TransformaItemsEmArray(entidades);
        }

        private static void TransformaItemsEmArray(IList<int> entidades)
        {
            Console.WriteLine("Transforme todos os numeros da lista em um array");
            var array = ListService.TransformaEmArray(entidades);

            Console.WriteLine($"Nova lista: {array}");
            Console.WriteLine("Items na lista");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        private static void RetornaApenasNumeroInformado(IList<int> entidades, int numeroInformado)
        {
            Console.WriteLine("Retorna apenas o numero informado");

            var listaParaBusca = ListService.BuscaItemNaLista(entidades, numeroInformado);

            MostraTodosNumerosNaLista(listaParaBusca);
        }

        private static void MostraNumerosPares(IList<int> entidades)
        {
            Console.WriteLine("Retorna apenas numeros pares");
            var novalista = ListService.BuscaItemsPares(entidades);
            MostraTodosNumerosNaLista(novalista);
        }

        private static void RemoveOUltimoItemDaLista(IList<int> entidades)
        {
            Console.WriteLine("Remove o ultimo elemento da lista");
            var lista = ListService.RemoveUltimoItemDaLista(entidades);

            MostraTodosNumerosNaLista(lista);
        }

        private static void RemovePrimeiroItemDaLista(IList<int> entidades)
        {
            Console.WriteLine("Remove o primeiro numero");
            var novaLista = ListService.RemovePrimeiroItemDaLista(entidades);
            MostraTodosNumerosNaLista(novaLista);
        }

        private static void InsereNumeroNoFimDaLista(IList<int> entidades, int novoNumero)
        {
            Console.WriteLine("Insere um numero no fim da lista");
            var novaLista = ListService.AdicionaItemNoFimDaLista(entidades, novoNumero);

            MostraTodosNumerosNaLista(novaLista);
        }

        private static void InsereNumeroNoInicioDaLista(IList<int> entidades, int numero)
        {
            Console.WriteLine("Insira um numero no inicio da lista");
            var novaLista = ListService.InsereNoInicioDaLista(entidades, numero);

            MostraTodosNumerosNaLista(novaLista);
        }

        private static void MostraUltimoNumeroDaLista(IList<int> entidades)
        {
            Console.WriteLine("Mostra o ultimo numero da lista");
            Console.WriteLine(ListService.BuscaUltimoItem(entidades));
        }

        private static void MostraPrimeiroNumeroDaLista(IList<int> entidades)
        {
            Console.WriteLine("Primeiro numero na lista");
            Console.WriteLine(ListService.BuscaPrimeiroItem(entidades));
        }
        
        private static void MostraOrdemDecrescente(IList<int> entidades)
        {
            Console.WriteLine("Mostra ordem decrescente");
            var listaDecrescente = ListService.OrganizaOrdemDecrescente(entidades);
            MostraTodosNumerosNaLista(listaDecrescente);
        }

        private static void MostraNaOrdemCrescente(IList<int> entidades)
        {
            Console.WriteLine("Numeros da lista na ordem crescente");
            var listaCrescente = ListService.OrganizaOrdemCrescente(entidades);
            MostraTodosNumerosNaLista(listaCrescente);
        }

        private static void MostraTodosNumerosNaLista(IList<int> entidades)
        {
            foreach (var numeros in entidades)
            {
                Console.Write($" {numeros}");
            }

            Console.WriteLine();
        }

        protected override int MontaEntidadeCadastro()
        {
            return ValidadorInput.BuscaInput<int>("Informe um numero inteiro", "O numero deve ser inteiro");
        }
    }
}