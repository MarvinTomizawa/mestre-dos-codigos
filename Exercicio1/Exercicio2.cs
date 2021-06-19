using System;
using System.Collections.Generic;
using Abstracao;

namespace Exercicio1
{
    internal class Exercicio2: ExercicioBase<decimal>
    {
        internal Exercicio2()
        {
            Parametros.Add(new ParametroExercicio<decimal>
            {
                Mensagem = "Informe o primeiro valor",
                MensagemParametroInvalido = "Informe um número para o parametro" 
            });    
            
            Parametros.Add(new ParametroExercicio<decimal>
            {
                Mensagem = "Informe o segundo valor",
                MensagemParametroInvalido = "Informe um número para o parametro" 
            });
        }
        
        public override string GetTitulo()
            => "Subtração";

        protected override string GetDescricao()
            => "Subtração de dois números";

        protected override Action<IList<ParametroExercicio<decimal>>> Action()
            => parametros =>
            {
                var parametro1 = parametros[0].Valor;
                var parametro2 = parametros[1].Valor;

                Console.WriteLine($"Subtração de {parametro1} - {parametro2} :  {parametro1 - parametro2}");
            };
    }
}