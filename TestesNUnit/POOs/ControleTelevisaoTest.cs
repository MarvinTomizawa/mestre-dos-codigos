using NUnit.Framework;
using PooModelos.Televisoes;

namespace TestesNUnit.POOs
{
    [TestFixture]
    public class ControleTelevisaoTest
    {
        [Test]
        public void DeveAumentarVolumeTelevisao()
        {
            var televisao = new Televisao();
            var controle = new Controle(televisao);
            
            televisao.AumentaVolume();
            Assert.AreEqual(6, televisao.Volume);
            
            controle.AumentaVolume();
            Assert.AreEqual(7, televisao.Volume);
        }

        [Test]
        public void NaoDeveUltrapassarDoLimiteMaximoDoVolumeDaTelevisao()
        {
            var televisao = new Televisao();
            var controle = new Controle(televisao);
            
            televisao.AumentaVolume();
            televisao.AumentaVolume();
            televisao.AumentaVolume();
            televisao.AumentaVolume();
            televisao.AumentaVolume();
            Assert.AreEqual(10, televisao.Volume);
            
            televisao.AumentaVolume();
            Assert.AreEqual(10, televisao.Volume);
            
            controle.AumentaVolume();
            Assert.AreEqual(10, televisao.Volume);
        }
        
        [Test]
        public void DeveDiminuirVolumeTelevisao()
        {
            var televisao = new Televisao();
            var controle = new Controle(televisao);
            
            televisao.DiminuiVolume();
            Assert.AreEqual(4, televisao.Volume);
            
            controle.DiminuiVolume();
            Assert.AreEqual(3, televisao.Volume);
        }
        
        [Test]
        public void NaoDeveUltrapassarDoLimiteMinimoDoVolumeDaTelevisao()
        {
            var televisao = new Televisao();
            var controle = new Controle(televisao);
            
            televisao.DiminuiVolume();
            televisao.DiminuiVolume();
            televisao.DiminuiVolume();
            televisao.DiminuiVolume();
            televisao.DiminuiVolume();
            Assert.AreEqual(0, televisao.Volume);
            
            televisao.DiminuiVolume();
            Assert.AreEqual(0, televisao.Volume);
            
            controle.DiminuiVolume();
            Assert.AreEqual(0, televisao.Volume);   
        }

        [Test]
        public void DeveMudarDeCanal()
        {
            var televisao = new Televisao();
            var controle = new Controle(televisao);
            
            televisao.MudaParaOCanal(200);
            Assert.AreEqual(200, televisao.Canal);
            
            controle.MudaParaOCanal(300);
            Assert.AreEqual(300, televisao.Canal);
        }

        [Test]
        public void NaoDeveColocarCanaisNegativos()
        {
            var televisao = new Televisao();
            var controle = new Controle(televisao);
            
            televisao.MudaParaOCanal(200);
            Assert.AreEqual(200, televisao.Canal);
            
            televisao.MudaParaOCanal(-299);
            Assert.AreEqual(200, televisao.Canal);
            
            controle.MudaParaOCanal(-299);
            Assert.AreEqual(200, televisao.Canal);
        }
    }
}