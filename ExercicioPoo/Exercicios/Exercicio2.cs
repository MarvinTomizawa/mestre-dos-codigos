using System;
using System.Collections.Generic;
using Abstracao;
using PooModelos.Pessoas;

namespace ExercicioPoo.Exercicios
{
    internal class Exercicio2 : ExercicioBase<int>
    {
        public override string GetTitulo()
            => "POO Pessoa";

        protected override string GetDescricao()
            => "Exercicios com a entidade de Pessoa";

        protected override Action<IList<ParametroExercicio<int>>> Action()
            => parameters =>
            {
                var nome = ValidadorInput.BuscaInput<string>("Informe o nome do usuário", "O nome é obrigatório",
                    input => !string.IsNullOrEmpty(input));

                var altura = ValidadorInput.BuscaInput<decimal>("Informe a altura do usuário",
                    "A altura deve ser válida (0 - 3) metros", x => x > 0 && x < 3);

                var diaNascimento = ValidadorInput.BuscaInput<int>("Informe o dia de nascimento",
                    "O dia deve ser entre 1 e 31", dia => dia > 0 && dia < 32);

                var mesNascimento = ValidadorInput.BuscaInput<int>("Informe o mes de nascimento",
                    "O mes deve ser entre 1 e 12", mes => mes > 0 && mes < 13);

                var anoNascimento =
                    ValidadorInput.BuscaInput<int>("Informe o ano de nascimento", "O ano deve ser inteiro");

                var pessoa = new Pessoa
                {
                    Nome = nome,
                    Altura = altura,
                    DataNascimento = new DateTime(anoNascimento, mesNascimento, diaNascimento)
                };

                Console.WriteLine("Dados da pessoa:");
                pessoa.MostraDados();
            };
    }
}