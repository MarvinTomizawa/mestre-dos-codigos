using System;
using System.Collections.Generic;
using Abstracao;

namespace Exercicio2
{
    internal class Exercicio1 : ExercicioBase<int>
    {
        public Exercicio1()
        {
            Parametros.Add(new ParametroExercicio<int>
            {
                Mensagem = "Informe o número de funcionários a ser cadastrados",
                MensagemParametroInvalido = "O número informado deve ser inteiro"
            });
        }

        public override string GetTitulo()
            => "Maior salário";

        protected override string GetDescricao()
            => "Busca o menor salário da lisa de funcionários";

        protected override Action<IList<ParametroExercicio<int>>> Action()
            => parametros =>
            {
                var quantidadeFuncionariosInformado = parametros[0].Valor;
                
                if (quantidadeFuncionariosInformado < 1)
                {
                    Console.WriteLine("Informado número inválido de funcionários");
                    Console.ReadLine();
                    return;
                }
                
                var funcionarios = PreencheFuncionarios(quantidadeFuncionariosInformado);
                var funcionarioComMaiorSalario = BuscaFuncionarioComMaiorSalario(funcionarios);

                Console.WriteLine($"Funcionario com maior salário: {funcionarioComMaiorSalario.Nome}, Salario:{funcionarioComMaiorSalario.Salario}");
            };

        private static Funcionario BuscaFuncionarioComMaiorSalario(IList<Funcionario> funcionarios)
        {
            var funcionarioComMaiorSalario = funcionarios[0];

            for (var i = 1; i < funcionarios.Count; i++)
            {
                if (funcionarios[i].Salario > funcionarioComMaiorSalario.Salario)
                {
                    funcionarioComMaiorSalario = funcionarios[i];
                }
            }

            return funcionarioComMaiorSalario;
        }

        private static IList<Funcionario> PreencheFuncionarios(int quantidadeFuncionarios)
        {
            var funcionarios = new List<Funcionario>();
            
            for (var i = 0; i < quantidadeFuncionarios; i++)
            {
                var nomeFuncionario = ValidadorInput.BuscaInput<string>("Informe o nome do funcionário",
                    "O nome deve ser um string");

                var salarioFuncionario = ValidadorInput.BuscaInput<decimal>("Informe um salário para o funcionario",
                    "O salário deve ser double");

                funcionarios.Add(new Funcionario
                {
                    Nome = nomeFuncionario,
                    Salario = salarioFuncionario
                });
                
                Console.Clear();
            }

            return funcionarios;
        }
    }
}