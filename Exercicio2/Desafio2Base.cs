using System;
using System.Collections.Generic;
using Abstracao;

namespace Exercicio2
{
    public abstract class Desafio2Base: ExercicioBase<int>
    {
        public Desafio2Base()
        {
            Parametros.Add(new ParametroExercicio<int>
            {
                Mensagem = "Informe o número de funcionários a ser cadastrados",
                MensagemParametroInvalido = "O número informado deve ser inteiro"
            });
        }
        
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
                var funcionarioBuscado = BuscaFuncionario(funcionarios);

                MostraMensagem(funcionarioBuscado);
            };

        protected abstract void MostraMensagem(Funcionario funcionario);

        protected abstract Funcionario BuscaFuncionario(IList<Funcionario> funcionarios);

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