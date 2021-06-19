using System.Collections.Generic;
using Abstracao;

namespace Exercicio1
{
    public class ListaExercicio1: Exercicios
    {
        private readonly List<ExercicioBase<decimal>> _exercicios;
        
        public ListaExercicio1()
        {
            _exercicios = new List<ExercicioBase<decimal>>
            {
                new Exercicio1(),
                new Exercicio2(),
                new Exercicio3(),
                new Exercicio4(),
                new Exercicio5()
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