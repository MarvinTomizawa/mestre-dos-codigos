using System;
using PooModelos.Contas;
using Xunit;

namespace TestesXUnit.POOs
{
    public class ContaCorrenteTest
    {
        [Fact]
        public void DeveDepositarDinheiroEAplicarTaxa()
        {
            var contaCorrente = new ContaCorrente
            {
                Saldo = 100,
                NumeroConta = 123,
                TaxaDeOperacao = 1
            };
            
            contaCorrente.Depositar(200);
            
            Assert.Equal(299, contaCorrente.Saldo);
            
            contaCorrente.Depositar(100);
            
            Assert.Equal(398, contaCorrente.Saldo);
        }

        [Fact]
        public void DeveSacarDinheiroEAplicarTaxa()
        {
            var contaCorrente = new ContaCorrente
            {
                Saldo = 500,
                NumeroConta = 123,
                TaxaDeOperacao = 1
            };
            
            contaCorrente.Sacar(200);
            
            Assert.Equal(299, contaCorrente.Saldo);
            
            contaCorrente.Sacar(100);
            
            Assert.Equal(198, contaCorrente.Saldo);
        }

        [Fact]
        public void NaoDevePermitirSacarDinheiroCasoNegativarConta()
        {
            var contaCorrente = new ContaCorrente
            {
                Saldo = 100,
                NumeroConta = 123,
                TaxaDeOperacao = 1
            };
            
            var exception = Assert.Throws<ArgumentException>(() => contaCorrente.Sacar(200));
            
            Assert.Equal(100, contaCorrente.Saldo);
            Assert.Equal("Saldo insuficiente", exception.Message);
        }
    }
}