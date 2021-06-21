using System;
using System.Collections.Generic;
using Abstracao;
using PooModelos.Televisoes;

namespace ExercicioPoo
{
    public class Exercicio4: ExercicioBase<int>
    {
        public override string GetTitulo()
            => "Televisão";

        protected override string GetDescricao()
            => "Exercicios com as entidades de televisão";

        protected override Action<IList<ParametroExercicio<int>>> Action()
            => parameters =>
            {
                var televisao = new Televisao();

                var controle = new Controle(televisao);
                
                AumentaVolume(controle);
                DiminuiVolume(controle);

                AumentaVolumeAteOMaximo(controle);
                DiminuiVolumeAteOMaximo(controle);
                
                controle.MudaParaOCanal(200);
                controle.MostraDados();
            };

        private static void DiminuiVolumeAteOMaximo(Controle controle)
        {
            Console.WriteLine("Diminuindo volume até o máximo");
            for (int i = 0; i < 10; i++)
            {
                controle.DiminuiVolume();
            }

            controle.MostraDados();
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
        }

        private static void AumentaVolumeAteOMaximo(Controle controle)
        {
            Console.WriteLine("Aumentando volume até o máximo");
            for (int i = 0; i < 10; i++)
            {
                controle.AumentaVolume();
            }

            controle.MostraDados();
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
        }

        private static void DiminuiVolume(Controle controle)
        {
            Console.WriteLine("Diminuindo volume 1 unidade");
            controle.DiminuiVolume();

            controle.MostraDados();
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
        }

        private static void AumentaVolume(Controle controle)
        {
            Console.WriteLine("Aumentando volume 1 unidade");
            controle.AumentaVolume();

            controle.MostraDados();

            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
        }
    }
}