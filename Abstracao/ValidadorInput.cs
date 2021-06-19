using System;

namespace Abstracao
{
    public static class ValidadorInput
    {
        public static T BuscaInput<T>(string mensagem, string mensagemErro)
        {
            var parametroValido = false;
            T inputUsuario = default;
            
            do
            {
                Console.WriteLine($"\n{mensagem}");
                var input = Console.ReadLine();

                try
                {
                    inputUsuario = (T) Convert.ChangeType(input, typeof(T));
                    parametroValido = true;
                }
                catch
                {
                    Console.WriteLine($"\n{mensagemErro}");
                }
            } while (!parametroValido);

            return inputUsuario;
        }
    }
}