using System.Collections.Generic;
using Abstracao;

namespace Exercicio3
{
    public class ListaExercicio3: Exercicios
    {
        private readonly List<ExercicioBase<int>> _exercicios;

        public ListaExercicio3()
        {
            _exercicios = new List<ExercicioBase<int>>
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