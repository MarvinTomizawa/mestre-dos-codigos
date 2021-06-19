using System;
using System.Collections.Generic;
using Abstracao;
using Exercicio1;

namespace ConsoleApp
{
    public class MestreDosCodigos
    {
        private readonly List<Exercicios> _exercicios;
        private bool _programaRodando;
        
        public MestreDosCodigos()
        {
            _exercicios = new List<Exercicios>
            {
                new ListaExercicio1()
            };
        }

        public void Start()
        {
            _programaRodando = true;
            
            do
            {
                var inputUsuario = PegaInputUsuario();

                if (!int.TryParse(inputUsuario, out var opcao)) continue;
                
                if (opcao == -1)
                {
                    _programaRodando = false;
                }
                else
                {
                    ExecutaExercicio(opcao);
                }

            } while (_programaRodando);
            
            Console.WriteLine("Programa Finalizado");
        }

        private void ExecutaExercicio(int opcao)
        {
            var acumulado = 0;

            foreach (var listaExercicio in _exercicios)
            {
                if (opcao >= acumulado || opcao < acumulado + listaExercicio.TamanhoDaLista())
                {
                    listaExercicio.ExecutaExercicio(opcao - acumulado);
                    break;
                }
                    
                acumulado += listaExercicio.TamanhoDaLista();
            }
            
            Console.Clear();
        }

        private string PegaInputUsuario()
        {
            var acumulado = 0;
            
            foreach (var listaExercicio in _exercicios)
            {
                listaExercicio.MostraOpcoes(acumulado);
                acumulado += listaExercicio.TamanhoDaLista();
            }

            Console.WriteLine("-1 - Finalizar o programa");
            
            return Console.ReadLine();
        }
    }
}