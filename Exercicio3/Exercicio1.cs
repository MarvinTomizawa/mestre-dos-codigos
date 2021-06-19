using System;
using System.Collections.Generic;
using Abstracao;

namespace Exercicio3
{
    internal class Exercicio1: ExercicioBase<int>
    {
        public override string GetTitulo()
            => "Multiplos de 3";

        protected override string GetDescricao()
            => "Imprime todos os multiplos de 3 de 1 a 100";

        protected override Action<IList<ParametroExercicio<int>>> Action()
            => parametros =>
            {
                var contador = 1;
                // var contador = 1; // Outra forma de fazer é iniciar em 3 e ir somando de 3 em 3
                
                while (contador <= 100)
                {
                    if (contador % 3 == 0)
                    {
                        Console.WriteLine(contador);
                    }
                    
                    contador++;
                    // contador+= 3; 
                }
            };
    }
}