using System.Collections.Generic;
using Abstracao;
using ExerciciosConsole.Exercicios;

namespace ExerciciosConsole
{
    public class ListaListaExercicioConsole: ListaExercicio
    {
        private readonly List<IExercicioBase> _exercicios;

        public ListaListaExercicioConsole()
        {
            _exercicios = new List<IExercicioBase>
            {
                new Exercicio1(),
                new Exercicio2(),
                new Exercicio3(),
                new Exercicio4(),
                new Exercicio5(),
                new Exercicio6(),
                new Exercicio7(),
                new Exercicio8(),
                new Exercicio9()
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