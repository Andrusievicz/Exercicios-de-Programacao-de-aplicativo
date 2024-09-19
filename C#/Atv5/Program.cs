using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita os dados do usuário
            Console.WriteLine("Informe a distancia percorrida (km): ");
            double distanciaPercorrida = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o consumo medio do veiculo (km/l): ");
            double consumoMedio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o preco do combustivel por litro (R$): ");
            double precoCombustivel = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o tamanho do tanque de combustivel (l): ");
            double tamanhoTanque = Convert.ToDouble(Console.ReadLine());

            // Calcula o valor total gasto
            double valorTotalGasto = (distanciaPercorrida / consumoMedio) * precoCombustivel;

            // Calcula o consumo por litro
            double consumoPorLitro = valorTotalGasto / precoCombustivel;

            // Calcula a quantidade de tanques de combustível utilizados
            double quantidadeTanquesUtilizados = valorTotalGasto / (tamanhoTanque * precoCombustivel);

            // Exibe os resultados
            Console.WriteLine($"Valor total gasto (R$): {valorTotalGasto:F2}");
            Console.WriteLine($"Consumo (R$)/Litro (l): {consumoPorLitro:F2}");
            Console.WriteLine($"Quantidade de tanques de combustivel utilizados: {quantidadeTanquesUtilizados:F2}");

            // Aguardando a tecla pressionada antes de sair
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
