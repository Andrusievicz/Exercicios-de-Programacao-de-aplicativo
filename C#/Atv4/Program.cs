using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de notas: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] notas = new double[n];
            double soma = 0, media;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite a nota {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                soma += notas[i];
            }

            media = soma / n;

            Console.WriteLine($"Media: {media}");

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
