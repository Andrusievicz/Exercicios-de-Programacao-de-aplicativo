using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a escala de origem da temperatura:");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");
            int escolha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor da temperatura:");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            double celsius, fahrenheit, kelvin;

            switch (escolha)
            {
                case 1:
                    // Celsius para Fahrenheit e Kelvin
                    celsius = temperatura;
                    fahrenheit = celsius * 1.8 + 32;
                    kelvin = celsius + 273.15;
                    break;
                case 2:
                    // Fahrenheit para Celsius e Kelvin
                    fahrenheit = temperatura;
                    celsius = (fahrenheit - 32) / 1.8;
                    kelvin = celsius + 273.15;
                    break;
                case 3:
                    // Kelvin para Celsius e Fahrenheit
                    kelvin = temperatura;
                    celsius = kelvin - 273.15;
                    fahrenheit = celsius * 1.8 + 32;
                    break;
                default:
                    Console.WriteLine("Escolha invalida.");
                    return;
            }

            Console.WriteLine($"Temperatura em Celsius: {celsius:F2} °C");
            Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"Temperatura em Kelvin: {kelvin:F2} K");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
