using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Escolha um programa:");
                Console.WriteLine("1) Calcular resistência de circuitos (3 resistências)");
                Console.WriteLine("2) Calcular resistência de circuitos (n resistências)");
                Console.WriteLine("3) Calcular média aritmética entre 4 notas");
                Console.WriteLine("4) Calcular média aritmética entre 'n' notas");
                Console.WriteLine("5) Calcular consumo de combustível");
                Console.WriteLine("6) Converter temperaturas");
                Console.WriteLine("7) Calcular IMC");
                Console.WriteLine("8) Calcular valor de produto com condições de pagamento");
                Console.WriteLine("9) Sair");
                Console.Write("Opção: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CalcularResistencia3();
                        break;
                    case 2:
                        CalcularResistenciaN();
                        break;
                    case 3:
                        CalcularMedia4Notas();
                        break;
                    case 4:
                        CalcularMediaNNotas();
                        break;
                    case 5:
                        CalcularConsumoCombustivel();
                        break;
                    case 6:
                        ConverterTemperaturas();
                        break;
                    case 7:
                        CalcularIMC();
                        break;
                    case 8:
                        CalcularValorProduto();
                        break;
                    case 9:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            }
        }

        static void CalcularResistencia3()
        {
            Console.Clear();
            Console.WriteLine("Calcular resistência de circuitos (3 resistências)");
            Console.Write("Digite R1: ");
            double R1 = double.Parse(Console.ReadLine());
            Console.Write("Digite R2: ");
            double R2 = double.Parse(Console.ReadLine());
            Console.Write("Digite R3: ");
            double R3 = double.Parse(Console.ReadLine());

            double RtSerie = R1 + R2 + R3;
            double RtParalelo = 1 / (1 / R1 + 1 / R2 + 1 / R3);

            Console.WriteLine($"Resistência em Série: {RtSerie} Ω");
            Console.WriteLine($"Resistência em Paralelo: {RtParalelo} Ω");
        }

        static void CalcularResistenciaN()
        {
            Console.Clear();
            Console.WriteLine("Calcular resistência de circuitos (n resistências)");
            Console.Write("Digite a quantidade de resistências: ");
            int n = int.Parse(Console.ReadLine());
            double[] resistencias = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite R{i + 1}: ");
                resistencias[i] = double.Parse(Console.ReadLine());
            }

            double RtSerie = resistencias.Sum();
            double RtParalelo = 1 / resistencias.Select(r => 1 / r).Sum();

            Console.WriteLine($"Resistência em Série: {RtSerie} Ω");
            Console.WriteLine($"Resistência em Paralelo: {RtParalelo} Ω");
        }

        static void CalcularMedia4Notas()
        {
            Console.Clear();
            Console.WriteLine("Calcular média aritmética entre 4 notas");
            double[] notas = new double[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            double media = notas.Average();
            Console.WriteLine($"Média: {media}");
            Console.WriteLine(media >= 7 ? "Aprovado" : "Reprovado");
        }

        static void CalcularMediaNNotas()
        {
            Console.Clear();
            Console.WriteLine("Calcular média aritmética entre 'n' notas");
            Console.Write("Digite a quantidade de notas: ");
            int n = int.Parse(Console.ReadLine());
            double[] notas = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            double media = notas.Average();
            Console.WriteLine($"Média: {media}");
            Console.WriteLine(media >= 7 ? "Aprovado" : "Reprovado");
        }

        static void CalcularConsumoCombustivel()
        {
            Console.Clear();
            Console.WriteLine("Calcular consumo de combustível");
            Console.Write("Digite a distância percorrida (km): ");
            double distancia = double.Parse(Console.ReadLine());
            Console.Write("Digite o consumo médio do veículo (km/l): ");
            double consumoMedio = double.Parse(Console.ReadLine());
            Console.Write("Digite o preço do combustível por litro (R$): ");
            double precoCombustivel = double.Parse(Console.ReadLine());
            Console.Write("Digite o tamanho do tanque de combustível (l): ");
            double tamanhoTanque = double.Parse(Console.ReadLine());

            double totalGasto = (distancia / consumoMedio) * precoCombustivel;
            double consumoPorLitro = totalGasto / precoCombustivel;
            double quantidadeTanques = totalGasto / (tamanhoTanque * precoCombustivel);

            Console.WriteLine($"Valor total gasto (R$): {totalGasto}");
            Console.WriteLine($"Consumo (R$/litro): {consumoPorLitro}");
            Console.WriteLine($"Quantidade de tanques utilizados: {quantidadeTanques}");
        }

        static void ConverterTemperaturas()
        {
            Console.Clear();
            Console.WriteLine("Converter temperaturas");
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"Celsius para Fahrenheit: {fahrenheit} °F");
            Console.WriteLine($"Celsius para Kelvin: {kelvin} K");
        }

        static void CalcularIMC()
        {
            Console.Clear();
            Console.WriteLine("Calcular IMC");
            Console.Write("Digite seu peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"IMC: {imc}");
            if (imc < 18.5) Console.WriteLine("Abaixo do peso");
            else if (imc < 24.9) Console.WriteLine("Peso ideal (parabéns)");
            else if (imc < 29.9) Console.WriteLine("Levemente acima do peso");
            else if (imc < 34.9) Console.WriteLine("Obesidade grau I");
            else if (imc < 39.9) Console.WriteLine("Obesidade grau II (severa)");
            else Console.WriteLine("Obesidade grau III (mórbida)");
        }

        static void CalcularValorProduto()
        {
            Console.Clear();
            Console.WriteLine("Calcular valor de produto com condições de pagamento");
            Console.Write("Digite o valor do produto (R$): ");
            double valorProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1 - À Vista em Dinheiro ou Pix (15% de desconto)");
            Console.WriteLine("2 - À Vista no cartão de crédito (10% de desconto)");
            Console.WriteLine("3 - Parcelado no cartão em duas vezes (sem juros)");
            Console.WriteLine("4 - Parcelado no cartão em três vezes ou mais (10% de juros)");
            int formaPagamento = int.Parse(Console.ReadLine());

            double valorFinal = valorProduto;
            switch (formaPagamento)
            {
                case 1:
                    valorFinal = valorProduto * 0.85;
                    break;
                case 2:
                    valorFinal = valorProduto * 0.90;
                    break;
                case 3:
                    valorFinal = valorProduto;
                    break;
                case 4:
                    valorFinal = valorProduto * 1.10;
                    break;
                default:
                    Console.WriteLine("Forma de pagamento inválida!");
                    return;
            }

            Console.WriteLine($"Valor final do produto (R$): {valorFinal}");

        }
    }
}
