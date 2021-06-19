using System;
using System.Collections.Generic;
using Abstracao;

namespace Exercicio1
{
    internal class Exercicio5: ExercicioBase<decimal>
    {
        internal Exercicio5()
        {
            Parametros.Add(new ParametroExercicio<decimal>
            {
                Mensagem = "Informe um valor",
                MensagemParametroInvalido = "O valor deve ser um número"
            });
        }
        
        public override string GetTitulo()
            => "Paridade";

        protected override string GetDescricao()
            => "Informe um valor para descobrir se é par ou impar";

        protected override Action<IList<ParametroExercicio<decimal>>> Action()
            => parametros =>
            {
                var valor = parametros[0].Valor;
                Console.WriteLine($"Parametro {valor} é {(valor % 2 == 0 ? "Par" : "Impar")}");
            };
    }
}