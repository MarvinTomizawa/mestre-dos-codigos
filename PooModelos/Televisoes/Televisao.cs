using System;
using PooModelos.Interfaces;

namespace PooModelos.Televisoes
{
    public class Televisao: Imprimivel
    {
        public Televisao()
        {
            Volume = 5;
            Canal = 0;
        }

        public int Volume { get; private set; }

        public int Canal { get; private set; }

        public void AumentaVolume()
        {
            if (Volume == 10)
            {
                return;
            }
            
            Volume++;
        }

        public void DiminuiVolume()
        {
            if (Volume == 0)
            {
                return;
            }
            
            Volume--;
        }

        public void MostraDados()
        {
            Console.WriteLine($"Televisao: Volume: {Volume} Canal: {Canal}");
        }

        public void MudaParaOCanal(int canal)
        {
            if (canal < 1)
            {
                return;
            }
            
            Canal = canal;
        }
    }
}