using System;
using System.Collections.Generic;
using Abstracao;
using ExerciciosConsole.Modelos;

namespace ExerciciosConsole.Exercicios
{
    internal class Exercicio2: DesafioCadastroEBusca<Funcionario>
    {
        internal Exercicio2() : base("Informe a quantidade de funcionarios para cadastrar")
        {
        }
        
        public override string GetTitulo()
            => "Salário de funcionários";

        protected override string GetDescricao()
            => "Busca o menor e maior salário da lisa de funcionários";
        
        protected override void TrataEntidades(IList<Funcionario> entidades)
        {
            MostraFuncionarioComMenorSalario(entidades);

            MostraEntidadeComMaiorSalario(entidades);
        }

        private static void MostraEntidadeComMaiorSalario(IList<Funcionario> entidades)
        {
            var funcionarioComMaiorSalario = entidades[0];

            for (var i = 1; i < entidades.Count; i++)
            {
                if (entidades[i].Salario > funcionarioComMaiorSalario.Salario)
                {
                    funcionarioComMaiorSalario = entidades[i];
                }
            }

            Console.WriteLine($"Funcionario com maior salário: {funcionarioComMaiorSalario.Nome}," +
                              $" Salario:{funcionarioComMaiorSalario.Salario}");
        }

        protected override Funcionario MontaEntidadeCadastro()
        {
            var nomeFuncionario = ValidadorInput.BuscaInput<string>("Informe o nome do funcionário",
                "O nome deve ser um string");

            var salarioFuncionario = ValidadorInput.BuscaInput<decimal>("Informe um salário para o funcionario",
                "O salário deve ser double");

            return new Funcionario
            {
                Nome = nomeFuncionario,
                Salario = salarioFuncionario
            };
        }
        
        private static void MostraFuncionarioComMenorSalario(IList<Funcionario> entidades)
        {
            var funcionarioComMenorSalario = entidades[0];

            var indice = 1;
            while (indice < entidades.Count)
            {
                if (entidades[indice].Salario < funcionarioComMenorSalario.Salario)
                {
                    funcionarioComMenorSalario = entidades[indice];
                }

                indice++;
            }

            Console.WriteLine(
                $"Funcionario com menor salário: {funcionarioComMenorSalario.Nome}, Salario:{funcionarioComMenorSalario.Salario}");
        }
    }
}