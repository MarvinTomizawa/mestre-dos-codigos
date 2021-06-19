using System;
using System.Collections.Generic;
using Abstracao;

namespace Exercicio1
{
    internal class Exercicio1 : ExercicioBase<decimal>
    {
        internal Exercicio1()
        {
            Parametros.Add(new ParametroExercicio<decimal>
            {
                Mensagem = "Primeiro número",
                MensagemParametroInvalido = "Informe um número inteiro"
            });
            
            Parametros.Add(new ParametroExercicio<decimal>
            {
                Mensagem = "Segundo número",
                MensagemParametroInvalido = "Informe um número inteiro"
            });
        }

        public override string GetTitulo()
            => "Soma";

        protected override string GetDescricao()
            => "Soma de dois números";

        protected override Action<IList<ParametroExercicio<decimal>>> Action()
            => parametros =>
            {
                Console.WriteLine($"Soma é: {parametros[0].Valor + parametros[1].Valor}");
            };
    }
}