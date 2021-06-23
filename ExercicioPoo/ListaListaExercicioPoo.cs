using System.Collections.Generic;
using Abstracao;
using ExercicioPoo.Exercicios;

namespace ExercicioPoo
{
    public class ListaListaExercicioPoo : ListaExercicio
    {
        private readonly List<ExercicioBase<int>> _exercicios;

        public ListaListaExercicioPoo()
        {
            _exercicios = new List<ExercicioBase<int>>
            {
                new Exercicio2(),
                new Exercicio3(),
                new Exercicio4()
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