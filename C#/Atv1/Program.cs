using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R1, R2, R3, RtSerie, RtParalelo;
            double V, I;

            Console.WriteLine("Digite a resistencia R1 (ou '0' se desconhecida): ");
            R1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a resistencia R2 (ou '0' se desconhecida): ");
            R2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a resistencia R3 (ou '0' se desconhecida): ");
            R3 = Convert.ToDouble(Console.ReadLine());

            if (R1 == 0 || R2 == 0 || R3 == 0)
            {
                Console.WriteLine("Digite a voltagem (V): ");
                V = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a corrente (I): ");
                I = Convert.ToDouble(Console.ReadLine());
                if (R1 == 0) R1 = V / I;
                if (R2 == 0) R2 = V / I;
                if (R3 == 0) R3 = V / I;
            }

            RtSerie = R1 + R2 + R3;
            RtParalelo = 1 / ((1 / R1) + (1 / R2) + (1 / R3));

            Console.WriteLine("Resistencia Total em Serie: " + RtSerie + " ohms");
            Console.WriteLine("Resistencia Total em Paralelo: " + RtParalelo + " ohms");
            Console.ReadKey();
        }
    }
}
