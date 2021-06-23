using System;
using NUnit.Framework;
using PooModelos.Pessoas;

namespace TestesNUnit.POOs
{
    [TestFixture]
    public class PessoaTest
    {
        [Test]
        public void DeveCalcularIdade()
        {
            var dataNascimento = DateTime.Now.AddYears(-20);

            var pessoa = new Pessoa
            {
                DataNascimento = dataNascimento,
                Altura = 1.71m,
                Nome = "Teste"
            };
            
            Assert.AreEqual(20, pessoa.GetIdade());
        }
        
    }
}