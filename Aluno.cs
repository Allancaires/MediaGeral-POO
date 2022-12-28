using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    class Aluno
    {
        public string Nome { get; private set; }

        private double[] QuantidadeNotas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int QuantidadeProvas)
        {
            Nome = nome;
        QuantidadeNotas = new double[QuantidadeProvas];
        }

        public void InserirNotas()
        {
            for (int i = 0; i < QuantidadeNotas.Length; i++)
            {
                Console.Write("Nota #" + (i + 1) + ": ");
                QuantidadeNotas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;
            for (int i = 0; i < QuantidadeNotas.Length; i++)
            {
                total += QuantidadeNotas[i];
            }
            return total / QuantidadeNotas.Length;
        }
    }
}
