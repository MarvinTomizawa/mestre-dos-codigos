using System.Collections.Generic;
using Abstracao;

namespace Exercicio2
{
    public class ListaExercicio2: Exercicios
    {
        private readonly List<ExercicioBase<int>> _exercicios;

        public ListaExercicio2()
        {
            _exercicios = new List<ExercicioBase<int>>
            {
                new Exercicio1()
            };
        }

        public override int TamanhoDaLista()
        {
            return _exercicios.Count;
        }
        
        protected override void ExecutaExercicioNaLista(int opcao)
        {
            _exercicios[opcao].ExecutaExercicio();
        }

        protected override string BuscaTituloNaLista(int opcao)
        {
            return _exercicios[opcao].GetTitulo();
        }
    }
}