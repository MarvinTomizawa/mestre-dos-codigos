namespace Abstracao
{
    public class ParametroExercicio<T>
    {
        public string Mensagem { get; set; }

        public string MensagemParametroInvalido { get; set; }

        public T Valor { get; set; }
    }
}