using System;
using PooModelos.Contas;
using Xunit;

namespace TestesXUnit.POOs
{
    public class ContaEspecialTest
    {
        [Theory]
        [InlineData(100, 200, 300)]
        [InlineData(0, 500, 500)]
        [InlineData(500, 0, 500)]
        [InlineData(100, 100, 200)]
        [InlineData(999, 999, 1998)]
        [InlineData(0, 0, 0)]
        public void DeveDepositarDinheiro(long saldo, long depositado, long esperado)
        {
            var contaCorrente = new ContaEspecial
            {
                Saldo = saldo,
                NumeroConta = 123,
                Limite = 100
            };
            
            contaCorrente.Depositar(depositado);
            
            Assert.Equal(esperado, contaCorrente.Saldo);
        }

        [Theory]
        [InlineData(100, 0, 100)]
        [InlineData(100, 50, 50)]
        [InlineData(100, 100, 0)]
        [InlineData(100, 150, -50)]
        [InlineData(100, 200, -100)]
        public void DeveSacarDinheiroEPermitirNegativarContaAteLimite(long saldo, long sacado, long esperado)
        {
            var contaCorrente = new ContaEspecial
            {
                Saldo = saldo,
                NumeroConta = 123,
                Limite = 100
            };
            
            contaCorrente.Sacar(sacado);
            
            Assert.Equal(esperado, contaCorrente.Saldo);
        }

        [Fact]
        public void NaoDevePermitirSacarDinheiroCasoNegativarContaAlemDoLimite()
        {
            var contaCorrente = new ContaEspecial
            {
                Saldo = 100,
                NumeroConta = 123,
                Limite = 100
            };
            
            var exception = Assert.Throws<ArgumentException>(() => contaCorrente.Sacar(201));
            
            Assert.Equal(100, contaCorrente.Saldo);
            Assert.Equal("Saldo insuficiente", exception.Message);
        }
    }
}