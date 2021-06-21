using System;
using System.Collections.Generic;
using Abstracao;
using PooModelos.Contas;

namespace ExercicioPoo
{
    public class Exercicio3 : ExercicioBase<int>
    {
        public override string GetTitulo()
            => "Aplicação bancária";

        protected override string GetDescricao()
            => "Exercicios com as entidades de aplicação bancária";

        protected override Action<IList<ParametroExercicio<int>>> Action()
            => parameters =>
            {
                var contaCorrente = MontaContaCorrente();
                
                var contaEspecial = MontaContaEspecial();

                DepositaESaca(contaCorrente);
                
                DepositaESaca(contaEspecial);
            };

        private static void DepositaESaca(ContaBancaria conta)
        {
            conta.MostraDados();
            var valorParaDepositar = ValidadorInput.BuscaInput<double>("Informe um valor para depositar",
                "Valor deve ser positivo", valor => valor > 0);

            conta.Depositar(valorParaDepositar);
            conta.MostraDados();
            
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
            Console.Clear();;

            conta.MostraDados();
            var valorParaSacar = ValidadorInput.BuscaInput<double>("Informe um valor para sacar",
                "Valor deve ser positivo", valor => valor > 0);

            try
            {
                conta.Sacar(valorParaSacar);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Operação inválida: {e.Message}");
            }
            
            conta.MostraDados();
            
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        private static ContaEspecial MontaContaEspecial()
        {
            var numeroContaEspecial =
                ValidadorInput.BuscaInput<long>("Numero da conta especial", "O numero deve ser long");

            var saldoContaEspecial =
                ValidadorInput.BuscaInput<double>("Saldo da conta especial", "O saldo não pode ser negativo",
                    saldo => saldo > 0);

            var limiteContaEspecial =
                ValidadorInput.BuscaInput<double>("Limite da conta especial", "O limite não pode ser negativo",
                    saldo => saldo > 0);

            var contaEspecial = new ContaEspecial
            {
                Saldo = saldoContaEspecial,
                Limite = limiteContaEspecial,
                NumeroConta = numeroContaEspecial
            };

            contaEspecial.MostraDados();
            
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
            Console.Clear();
            return contaEspecial;
        }

        private static ContaCorrente MontaContaCorrente()
        {
            var numeroContaCorrente =
                ValidadorInput.BuscaInput<long>("Numero da conta corrente", "O numero deve ser long");

            var saldoContaCorrente =
                ValidadorInput.BuscaInput<double>("Saldo da conta corrente", "O saldo não pode ser negativo",
                    saldo => saldo > 0);

            var taxaContaCorrente =
                ValidadorInput.BuscaInput<double>("Taxa da conta corrente", "A taxa não pode ser negativa",
                    saldo => saldo > 0);

            var contaCorrente = new ContaCorrente
            {
                Saldo = saldoContaCorrente,
                NumeroConta = numeroContaCorrente,
                TaxaDeOperacao = taxaContaCorrente
            };

            contaCorrente.MostraDados();
            
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
            Console.Clear();
            
            return contaCorrente;
        }
    }
}