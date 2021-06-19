﻿using System.Collections.Generic;
using System.Linq;

namespace Exercicio4
{
    public class Aluno
    {
        public Aluno()
        {
            Notas = new List<decimal>();
        }

        public string Nome { get; internal set; }

        public IList<decimal> Notas { get; internal set; }

        public decimal Media => Notas.Sum() / Notas.Count;
    }
}