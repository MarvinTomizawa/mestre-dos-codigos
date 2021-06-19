using System.Collections.Generic;
using Abstracao;

namespace Exercicio5
{
    public class ListaExercicio5: Exercicios
    {
        private readonly List<ExercicioBase<long>> _exercicios;

        public ListaExercicio5()
        {
            _exercicios = new List<ExercicioBase<long>>
            {
                new Exercicio1()
            };;
        }

        public override int TamanhoDaLista()
            => _exercicios.Count;

        protected override void ExecutaExercicioNaLista(int opcao)
            => _exercicios[opcao].ExecutaExercicio();

        protected override string BuscaTituloNaLista(int opcao)
            => _exercicios[opcao].GetTitulo();
    }
}