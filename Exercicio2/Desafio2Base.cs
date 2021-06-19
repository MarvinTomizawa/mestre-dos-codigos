using System.Collections.Generic;
using Abstracao;

namespace Exercicio2
{
    public abstract class Desafio2Base: DesafioCadastroEBusca<Funcionario>
    {
        protected  Desafio2Base() : base("Informe a quantidade de funcionarios para cadastrar")
        {
        }

        protected override void TrataEntidades(IList<Funcionario> entidades)
        {
            var funcionarioBuscado = BuscaFuncionario(entidades);

            MostraMensagem(funcionarioBuscado);
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
        
        protected abstract void MostraMensagem(Funcionario funcionario);

        protected abstract Funcionario BuscaFuncionario(IList<Funcionario> funcionarios);

    }
}