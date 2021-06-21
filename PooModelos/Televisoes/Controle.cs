namespace PooModelos.Televisoes
{
    public class Controle
    {
        public Controle(Televisao televisao)
        {
            Televisao = televisao;
        }

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

        public void MudaParaOCanal(int canal)
        {
            Televisao.MudaParaOCanal(canal);
        }
    }
}