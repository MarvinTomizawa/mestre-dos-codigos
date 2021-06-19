using System;

namespace Abstracao
{
    public abstract class Exercicios
    {
        protected abstract void ExecutaExercicioNaLista(int opcao);
        
        protected abstract string BuscaTituloNaLista(int opcao);

        public abstract int TamanhoDaLista();
        
        public void MostraOpcoes(int inicioDeOpcao)
        {
            for (var i = inicioDeOpcao; i < TamanhoDaLista(); i++)
            {
                var valorOpcao = i - inicioDeOpcao;
                Console.WriteLine($"{i} - {BuscaTituloNaLista(valorOpcao)}");
            }
        }

        public void ExecutaExercicio(int opcao)
        {
            if (opcao >= TamanhoDaLista() || opcao < 0)
            {
                Console.WriteLine("\nValor inválido para exercicio");
                Console.ReadLine();
                return;
            }

            ExecutaExercicioNaLista(opcao);
        }
    }
}