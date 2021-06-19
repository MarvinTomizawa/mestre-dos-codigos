using System;
using System.Collections.Generic;
using Abstracao;

namespace Exercicio1
{
    internal class Exercicio3: ExercicioBase<decimal>
    {
        internal Exercicio3()
        {
            Parametros.Add(new ParametroExercicio<decimal>
            {
                Mensagem = "Informe o valor a ser dividido",
                MensagemParametroInvalido = "O valor deve ser um número"
            });
            
            Parametros.Add(new ParametroExercicio<decimal>
            {
                Mensagem = "Informe o valor que vai divir",
                MensagemParametroInvalido = "O valor deve ser um número" 
            });
        }

        public override string GetTitulo()
            => "Divisão";

        protected override string GetDescricao()
            => "Divisão de dois números";

        protected override Action<IList<ParametroExercicio<decimal>>> Action()
            => parametros =>
            {
                var parametro1 = parametros[0].Valor;
                var parametro2 = parametros[1].Valor;
                Console.WriteLine($"Divisão de {parametro1} por {parametro2} : {parametro1 / parametro2}");
            };
    }
}