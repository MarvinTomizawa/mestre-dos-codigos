using System;
using System.Collections.Generic;

namespace Exercicio2
{
    public class Exercicio2: Desafio2Base
    {
        public override string GetTitulo()
            => "Menor salário";

        protected override string GetDescricao()
            => "Busca o maior salário da lisa de funcionários";

        protected override void MostraMensagem(Funcionario funcionario)
        {
            Console.WriteLine($"Funcionario com menor salário: {funcionario.Nome}, Salario:{funcionario.Salario}");
        }

        protected override Funcionario BuscaFuncionario(IList<Funcionario> funcionarios)
        {
            var funcionarioComMenorSalario = funcionarios[0];

            var indice = 1;
            while(indice < funcionarios.Count)
            {
                if (funcionarios[indice].Salario < funcionarioComMenorSalario.Salario)
                {
                    funcionarioComMenorSalario = funcionarios[indice];
                }

                indice++;
            }

            return funcionarioComMenorSalario;
        }
    }
}