using System.Collections.Generic;
using System.Linq;

namespace ExerciciosConsole.Servicos
{
    public static class ListService
    {
        public static int[] TransformaEmArray(IList<int> entidades)
        {
            return entidades.ToArray();
        }

        public static List<int> BuscaItensNaLista(IList<int> entidades, int numeroInformado)
        {
            return entidades.Where(x => x == numeroInformado).ToList();
        }

        public static List<int> BuscaItemsPares(IList<int> entidades)
        {
            return entidades.Where(x => x % 2 == 0).ToList();
        }

        public static List<int> RemoveUltimoItemDaLista(IList<int> entidades)
        {
            var lista = entidades.ToList();

            lista.RemoveAt(lista.Count - 1);
            return lista;
        }

        public static List<int> RemovePrimeiroItemDaLista(IList<int> entidades)
        {
            var novaLista = entidades.ToList();
            novaLista.RemoveAt(0);
            return novaLista;
        }

        public static List<int> AdicionaItemNoFimDaLista(IList<int> entidades, int novoNumero)
        {
            var novaLista = entidades.ToList();
            novaLista.Add(novoNumero);
            return novaLista;
        }

        public static List<int> AdicionaNoInicioDaLista(IList<int> entidades, int numero)
        {
            var novaLista = entidades.ToList();
            novaLista.Insert(0, numero);
            return novaLista;
        }

        public static int BuscaUltimoItem(IList<int> entidades)
        {
            return entidades.LastOrDefault();
        }

        public static int BuscaPrimeiroItem(IList<int> entidades)
        {
            return entidades.FirstOrDefault();
        }

        public static List<int> OrganizaOrdemDecrescente(IList<int> entidades)
        {
            return entidades.OrderByDescending(x => x).ToList();
        }

        public static IList<int> OrganizaOrdemCrescente(IList<int> entidades)
        {
            return entidades.OrderBy(x => x).ToList();
        }
    }
}