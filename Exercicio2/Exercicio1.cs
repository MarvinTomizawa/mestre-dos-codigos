using System;
using System.Collections.Generic;

namespace Exercicio2
{
    internal class Exercicio1 : Desafio2Base
    {
        public override string GetTitulo()
            => "Maior salário";

        protected override string GetDescricao()
            => "Busca o menor salário da lisa de funcionários";

        protected override void MostraMensagem(Funcionario funcionario)
        {
            Console.WriteLine($"Funcionario com maior salário: {funcionario.Nome}," +
                              $" Salario:{funcionario.Salario}");
        }

        protected override Funcionario BuscaFuncionario(IList<Funcionario> funcionarios)
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
    }
}