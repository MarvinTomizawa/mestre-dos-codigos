using System.Collections.Generic;
using System.Linq;
using ExerciciosConsole.Servicos;
using Xunit;

namespace TestesXUnit.Consoles
{
    public class Exercicio9Test
    {
        [Fact]
        public void DeveTransformarEmArray()
        {
            var numeros = new List<int>() {1, 2, 3, 4};

            var array = ListService.TransformaEmArray(numeros);
            
            Assert.Equal(4, array.Length);
            Assert.IsType<int[]>(array);
        }

        [Fact]
        public void DeveBuscarItemNaLista()
        {
            var numeros = new List<int>() {1, 2, 3, 4, 2, 3, 4, 5, 2};

            var itens = ListService.BuscaItensNaLista(numeros, 2);
            
            Assert.Equal(3, itens.Count);
            Assert.All(itens, item => Assert.Equal(2, item));
        }

        [Fact]
        public void DeveBuscarItensPares()
        {
            var numeros = new List<int>() {1, 2, 3, 4, 2, 3, 4, 5, 2};

            var pares = ListService.BuscaItemsPares(numeros);
            
            Assert.Equal(5, pares.Count);
            Assert.Contains(pares, par => par == 2);
            Assert.Contains(pares, par => par == 4);
        }

        [Fact]
        public void DeveRemoverOUltimoItemDaLista()
        {
            var numeros = new List<int>() {1, 2, 3, 4};

            var semUltimo = ListService.RemoveUltimoItemDaLista(numeros);
            
            Assert.Equal(3, semUltimo.Count);
            Assert.DoesNotContain(semUltimo, numero => numero == 4);
        }

        [Fact]
        public void DeveRemoverPrimeiroItemDaLista()
        {
            var numeros = new List<int>() {1, 2, 3, 4};

            var semPrimeiro = ListService.RemovePrimeiroItemDaLista(numeros);
            
            Assert.Equal(3, semPrimeiro.Count);
            Assert.DoesNotContain(semPrimeiro, numero => numero == 1);
        }

        [Fact]
        public void DeveAdicionarItemNoInicioDaLista()
        {
            var numeros = new List<int>() {1, 2, 3, 4};

            var comZeroNoInicio = ListService.AdicionaNoInicioDaLista(numeros, 0);
            
            Assert.Equal(5, comZeroNoInicio.Count);
            Assert.Equal(0, comZeroNoInicio.First());
        }
        
        [Fact]
        public void DeveAdicionarItemNoFimDaLista()
        {
            var numeros = new List<int>() {1, 2, 3, 4};

            var listaComCincoNoFim = ListService.AdicionaItemNoFimDaLista(numeros, 5);
            
            Assert.Equal(5, listaComCincoNoFim.Count);
            Assert.Equal(5, listaComCincoNoFim.Last());
        }

        [Fact]
        public void DeveBuscarUltimoItem()
        {
            var numeros = new List<int>() {1, 2, 3, 4};

            var ultimo = ListService.BuscaUltimoItem(numeros);
        
            Assert.Equal(4, ultimo);
        }
        
        [Fact]
        public void DeveBuscarPrimeiroItem()
        {
            var numeros = new List<int>() {1, 2, 3, 4};

            var primeiro = ListService.BuscaPrimeiroItem(numeros);
        
            Assert.Equal(1, primeiro);
        }

        [Fact]
        public void DeveOrganizarOrdemCrescente()
        {
            var numeros = new List<int>() {2, 4, 1, 3};

            var ordemCrescente = ListService.OrganizaOrdemCrescente(numeros);
        
            Assert.Equal(1, ordemCrescente.First());
            Assert.Equal(4, ordemCrescente.Last());
        }
        
        [Fact]
        public void DeveOrganizarOrdemDecrescente()
        {
            var numeros = new List<int>() {2, 4, 1, 3};

            var ordemCrescente = ListService.OrganizaOrdemDecrescente(numeros);
        
            Assert.Equal(4, ordemCrescente.First());
            Assert.Equal(1, ordemCrescente.Last());
        }
    }
}