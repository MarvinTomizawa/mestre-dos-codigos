namespace PooModelos.Televisoes
{
    public class Controle
    {
        public Televisao Televisao { get; set; }

        public void AumentaVolume()
        {
            Televisao.AumentaVolume();
        }

        public void DiminuiVolume()
        {
            Televisao.DiminuiVolume();
        }

        public void MostraDados()
        {
            Televisao.MostraDados();
        }
    }
}