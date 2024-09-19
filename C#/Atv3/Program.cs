using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[4];
            double soma = 0, media;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Digite a nota {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                soma += notas[i];
            }

            media = soma / 4;

            Console.WriteLine($"Media: {media}");

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            Console.ReadKey();
        }
    }
}
