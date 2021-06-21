using System.Collections.Generic;
using Abstracao;

namespace Exercicio9
{
    public class ListaExercicio9: Exercicios
    {
        private readonly List<DesafioCadastroEBusca<int>> _exercicios;

        public ListaExercicio9()
        {
            _exercicios = new List<DesafioCadastroEBusca<int>>
            {
                new Exercicio1()
            };
        }

        public override int TamanhoDaLista()
            => _exercicios.Count;

        protected override void ExecutaExercicioNaLista(int opcao)
            => _exercicios[opcao].ExecutaExercicio();

        protected override string BuscaTituloNaLista(int opcao)
            => _exercicios[opcao].GetTitulo();
    }
}