using System;

namespace Abstracao
{
    public abstract class ListaExercicio
    {
        public abstract int TamanhoDaLista();
        
        protected abstract void ExecutaExercicioNaLista(int opcao);
        
        protected abstract string BuscaTituloNaLista(int opcao);
        
        public void MostraOpcoes(int inicioDeOpcao)
        {
            for (var i = 0; i < TamanhoDaLista(); i++)
            {
                Console.WriteLine($"{i + inicioDeOpcao} - {BuscaTituloNaLista(i)}");
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