using System;
using System.Collections.Generic;
using Abstracao;

namespace Exercicio1
{
    internal class Exercicio4:ExercicioBase<decimal>
    {
        internal Exercicio4()
        {
            Parametros.Add(new ParametroExercicio<decimal>
            {
                Mensagem = "Primeiro valor",
                MensagemParametroInvalido = "O valor deve ser um número"
            });
            
            Parametros.Add(new ParametroExercicio<decimal>
            {
                Mensagem = "Segundo valor",
                MensagemParametroInvalido = "O valor deve ser um número"
            });
        }

        public override string GetTitulo()
            => "Multiplicação";

        protected override string GetDescricao()
            => "Multiplicação de dois números";

        protected override Action<IList<ParametroExercicio<decimal>>> Action()
            => parametros =>
            {
                var parametro1 = parametros[0].Valor;
                var parametro2 = parametros[1].Valor;
                
                Console.WriteLine($"Multiplicação de {parametro1} por {parametro2} : {parametro1 * parametro2}");
            };
    }
}