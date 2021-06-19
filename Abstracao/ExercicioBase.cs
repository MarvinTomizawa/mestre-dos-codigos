using System;
using System.Collections.Generic;

namespace Abstracao
{
    public abstract class ExercicioBase<TIpoParametro>
    {
        protected readonly IList<ParametroExercicio<TIpoParametro>> Parametros =
            new List<ParametroExercicio<TIpoParametro>>();

        public abstract string GetTitulo();

        protected abstract string GetDescricao();

        public void ExecutaExercicio()
        {
            Console.Clear();

            Console.WriteLine(GetDescricao());

            Action().Invoke(GetParametros());

            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();
        }

        private IList<ParametroExercicio<TIpoParametro>> GetParametros()
        {
            foreach (var parametro in Parametros)
            {
                var parametroValido = false;

                do
                {
                    Console.WriteLine($"\n{parametro.Mensagem}");
                    var mensagem = Console.ReadLine();

                    try
                    {
                        parametro.Valor = (TIpoParametro) Convert.ChangeType(mensagem, typeof(TIpoParametro));
                        parametroValido = true;
                    }
                    catch
                    {
                        Console.WriteLine($"\n{parametro.MensagemParametroInvalido}");
                    }
                } while (!parametroValido);
            }

            return Parametros;
        }

        protected abstract Action<IList<ParametroExercicio<TIpoParametro>>> Action();
    }
}