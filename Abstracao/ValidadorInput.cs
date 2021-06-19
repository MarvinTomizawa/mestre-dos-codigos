using System;

namespace Abstracao
{
    public static class ValidadorInput
    {
        public static T BuscaInput<T>(string mensagem, string mensagemErro, Func<T,bool> validador = null)
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
                    parametroValido = validador?.Invoke(inputUsuario) ?? true;
                }
                catch
                {
                    Console.WriteLine($"\n Houve um erro para processar sua entrada");
                }
                
                if(!parametroValido)
                {
                    Console.WriteLine(mensagemErro);
                }
                
            } while (!parametroValido);

            return inputUsuario;
        }
    }
}