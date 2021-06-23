﻿using System;
using System.Collections.Generic;
using Abstracao;

namespace ExerciciosConsole.Exercicios
{
    internal class Exercicio5: ExercicioBase<long>
    {
        internal Exercicio5()
        {
            Parametros.Add(new ParametroExercicio<long>
            {
                Mensagem = "Informe um valor para a",
                MensagemParametroInvalido = "O valor deve ser long"
            });
            
            Parametros.Add(new ParametroExercicio<long>
            {
                Mensagem = "Informe um valor para b",
                MensagemParametroInvalido = "O valor deve ser long"
            });
            
            Parametros.Add(new ParametroExercicio<long>
            {
                Mensagem = "Informe um valor para c",
                MensagemParametroInvalido = "O valor deve ser long"
            });
        }
        
        public override string GetTitulo()
            => "Baskhara";

        protected override string GetDescricao()
            => "Calcula a formula de baskhara";

        protected override Action<IList<ParametroExercicio<long>>> Action()
            => parametros =>
            {
                var a = parametros[0].Valor;
                var b = parametros[1].Valor;
                var c = parametros[2].Valor;

                var quadradoB = Math.Pow(b, 2);
                var delta = Math.Sqrt(quadradoB - 4 * a * c);

                Console.WriteLine(delta);
                Console.WriteLine($"R1: {(-b + delta) / (2 * a)}");
                Console.WriteLine($"R2: {(-b - delta) / (2 * a)}");
            };
    }
}