using System;
using System.Collections.Generic;
using System.Linq;
using Abstracao;

namespace Exercicio4
{
    internal class Exercicio1 : DesafioCadastroEBusca<Aluno>
    {
        internal Exercicio1() : base("Informe a quantidade de alunos para cadastro")
        {
        }

        public override string GetTitulo()
            => "Alunos com média acima de 7";

        protected override string GetDescricao()
            => "Mostra os alunos com média acima de 7";

        protected override void TrataEntidades(IList<Aluno> entidades)
        {
            foreach (var aluno in entidades.Where(x => x.Media > 7))
            {
                Console.WriteLine($"Aluno: {aluno.Nome} Media: {aluno.Media}");
            }
        }

        protected override Aluno MontaEntidadeCadastro()
        {
            Func<decimal, bool> validadorNota = nota => nota >= 0 && nota <= 10;
            const string mensagemErroNota = "A nota deve ser decimal e estar entre 0 e 10";

            var nomeAluno = ValidadorInput.BuscaInput<string>("Informe o nome do aluno", "O nome deve ser string",
                nome => !string.IsNullOrEmpty(nome));

            var nota1 = ValidadorInput.BuscaInput("Informe a nota 1 do aluno", mensagemErroNota, validadorNota);
            var nota2 = ValidadorInput.BuscaInput("Informe a nota 2 do aluno", mensagemErroNota, validadorNota);
            var nota3 = ValidadorInput.BuscaInput("Informe a nota 3 do aluno", mensagemErroNota, validadorNota);
            var nota4 = ValidadorInput.BuscaInput("Informe a nota 4 do aluno", mensagemErroNota, validadorNota);

            return new Aluno
            {
                Nome = nomeAluno,
                Notas = new List<decimal> {nota1, nota2, nota3, nota4}
            };
        }
    }
}