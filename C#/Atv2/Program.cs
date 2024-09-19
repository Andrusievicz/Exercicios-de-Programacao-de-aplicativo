using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de resistencias: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] resistencias = new double[n];
            double RtSerie = 0, RtParalelo = 0;
            double V, I;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite a resistencia R{i + 1} (ou '0' se desconhecida): ");
                resistencias[i] = Convert.ToDouble(Console.ReadLine());

                if (resistencias[i] == 0)
                {
                    Console.WriteLine($"Digite a voltagem (V) para R{i + 1}: ");
                    V = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Digite a corrente (I) para R{i + 1}: ");
                    I = Convert.ToDouble(Console.ReadLine());
                    resistencias[i] = V / I;
                }
            }

            for (int i = 0; i < n; i++)
            {
                RtSerie += resistencias[i];
                RtParalelo += 1 / resistencias[i];
            }

            RtParalelo = 1 / RtParalelo;

            Console.WriteLine("Resistencia Total em Serie: " + RtSerie + " ohms");
            Console.WriteLine("Resistencia Total em Paralelo: " + RtParalelo + " ohms");
            Console.ReadKey();
        }
    }
}
