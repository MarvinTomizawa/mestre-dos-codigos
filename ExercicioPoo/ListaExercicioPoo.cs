using System.Collections.Generic;
using Abstracao;

namespace ExercicioPoo
{
    public class ListaExercicioPoo : Exercicios
    {
        private readonly List<ExercicioBase<int>> _exercicios;

        public ListaExercicioPoo()
        {
            _exercicios = new List<ExercicioBase<int>>
            {
                new Exercicio2(),
                new Exercicio3()
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