using System.Collections.Generic;
using Abstracao;

namespace Exercicio8
{
    public class ListaExercicio8: Exercicios
    {
        private readonly List<DesafioCadastroEBusca<decimal>> _exercicios;

        public ListaExercicio8()
        {
            _exercicios = new List<DesafioCadastroEBusca<decimal>>
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