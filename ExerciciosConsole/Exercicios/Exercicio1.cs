using System;
using System.Collections.Generic;
using Abstracao;

namespace ExerciciosConsole.Exercicios
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
            => "Operações no console";

        protected override string GetDescricao()
            => "Operações no console utilizando dois numeros passados de parametro";

        protected override Action<IList<ParametroExercicio<decimal>>> Action()
            => parametros =>
            {
                var parametro1 = parametros[0].Valor;
                var parametro2 = parametros[1].Valor;
                
                Console.WriteLine($"Soma é: {parametro1 + parametro2}");
                Console.WriteLine($"Subtração de {parametro1} - {parametro2} :  {parametro1 - parametro2}");
                Console.WriteLine($"Divisão de {parametro1} por {parametro2} : {parametro1 / parametro2}");
                Console.WriteLine($"Multiplicação de {parametro1} por {parametro2} : {parametro1 * parametro2}");
                Console.WriteLine($"Primeiro valor {parametro1} é {(parametro1 % 2 == 0 ? "Par" : "Impar")}");
                Console.WriteLine($"Segundo valor {parametro2} é {(parametro2 % 2 == 0 ? "Par" : "Impar")}");
                
            };
    }
}