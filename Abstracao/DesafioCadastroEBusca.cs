using System;
using System.Collections.Generic;

namespace Abstracao
{
    public abstract class DesafioCadastroEBusca<T>: ExercicioBase<int>
    {
        protected DesafioCadastroEBusca(string mensagemParametro)
        {
            Parametros.Add(new ParametroExercicio<int>
            {
                Mensagem = mensagemParametro,
                MensagemParametroInvalido = "O número informado deve ser inteiro"
            });
        }
        
        protected override Action<IList<ParametroExercicio<int>>> Action()
            => parametros =>
            {
                var quantidadeEntidadesInformadas = parametros[0].Valor;
                
                if (quantidadeEntidadesInformadas < 1)
                {
                    Console.WriteLine("Informado número inválido para cadastro");
                    Console.ReadLine();
                    return;
                }
                
                var entidades = PreencheEntidades(quantidadeEntidadesInformadas);
                TrataEntidades(entidades);
            };

        protected abstract void TrataEntidades(IList<T> entidades);

        private IList<T> PreencheEntidades(int quantidadeDeCadastros)
        {
            var entidades = new List<T>();
            
            for (var i = 0; i < quantidadeDeCadastros; i++)
            {
                entidades.Add(MontaEntidadeCadastro());

                Console.Clear();
            }

            return entidades;
        }

        protected abstract  T MontaEntidadeCadastro();
    }
}