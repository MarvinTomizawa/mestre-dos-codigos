using System;

namespace Abstracao
{
    public abstract class Exercicios
    {
        public abstract int TamanhoDaLista();
        
        protected abstract void ExecutaExercicioNaLista(int opcao);
        
        protected abstract string BuscaTituloNaLista(int opcao);
        
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