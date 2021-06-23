using System;
using System.Collections.Generic;
using Abstracao;

namespace ExerciciosConsole.Exercicios
{
    public class Exercicio6 : ExercicioBase<int>
    {
        public override string GetTitulo()
            => "Ref e Out";

        protected override string GetDescricao()
            => "Exemplificação de ref e out";

        protected override Action<IList<ParametroExercicio<int>>> Action()
            => parametros =>
            {
                TesteRef();
                TesteOut();
            };

        private void TesteOut()
        {
            Console.WriteLine("Teste Out");
            var valor = 10; // Valor será alterado dentro da função

            Console.WriteLine($"Valor original atribuido, antes da função: {valor}");
            var valor2 = Adiciona10FuncaoOutRetorna30(out valor);

            Console.WriteLine($"Valor alterado, já fora da função: {valor}");
            Console.WriteLine($"Valor retornado  : {valor2}");
        }

        private void TesteRef()
        {
            Console.WriteLine("Teste Ref");
            int valor = 10;
            Console.WriteLine($"Valor original antes da chamada da função: {valor}");
            var valor2 = Adiciona10FuncaoRefRetorna30(ref valor);

            Console.WriteLine($"Valor alterado por referencia, já fora da função: {valor}");
            Console.WriteLine($"Valor retornado  : {valor2}");
            Console.WriteLine();
        }

        private int Adiciona10FuncaoOutRetorna30(out int valor)
        {
            //valor += 10; Não da para utilizar pq n foi atribuido ainda, é apenas utilizado para retornar um valor
            Console.WriteLine($"Não é possivel utilizar antes de alterar o valor");
            valor = 10;
            Console.WriteLine($"Valor dentro da função após alterações: {valor}");
            return valor + 20;
        }

        private int Adiciona10FuncaoRefRetorna30(ref int valor)
        {
            Console.WriteLine($"Valor dentro da função antes de alterações: {valor}");
            valor += 10;
            Console.WriteLine($"Valor dentro da função após alterações: {valor}");
            return valor + 10;
        }
    }
}