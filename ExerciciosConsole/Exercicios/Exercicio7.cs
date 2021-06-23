using System;
using System.Collections.Generic;
using System.Linq;
using Abstracao;

namespace ExerciciosConsole.Exercicios
{
    internal class Exercicio7 : ExercicioBase<int>
    {
        internal Exercicio7()
        {
            const string mensagemErro = "O valor deve ser inteiro";

            Parametros.Add(new ParametroExercicio<int>
            {
                Mensagem = "Informe um valor para a",
                MensagemParametroInvalido = mensagemErro
            });

            Parametros.Add(new ParametroExercicio<int>
            {
                Mensagem = "Informe um valor para b",
                MensagemParametroInvalido = mensagemErro
            });

            Parametros.Add(new ParametroExercicio<int>
            {
                Mensagem = "Informe um valor para c",
                MensagemParametroInvalido = mensagemErro
            });
            Parametros.Add(new ParametroExercicio<int>
            {
                Mensagem = "Informe um valor para d",
                MensagemParametroInvalido = mensagemErro
            });
        }

        public override string GetTitulo()
            => "Soma Pares";

        protected override string GetDescricao()
            => "Lê quatro numeros inteiros e soma os pares";

        protected override Action<IList<ParametroExercicio<int>>> Action()
            => parametros =>
            {
                Console.WriteLine(
                    $"Soma dos pares: {parametros.Select(x => x.Valor).Where(x => x % 2 == 0).Sum()}");
            };
    }
}