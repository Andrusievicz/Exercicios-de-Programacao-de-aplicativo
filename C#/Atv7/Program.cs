using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita os dados do usuário
            Console.WriteLine("Informe o seu peso (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a sua altura (m): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            // Calcula o IMC
            double imc = peso / (altura * altura);

            // Determina a condição do IMC
            string condicao;
            if (imc < 18.5)
            {
                condicao = "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                condicao = "Peso ideal (parabéns)";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                condicao = "Levemente acima do peso";
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                condicao = "Obesidade grau I";
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                condicao = "Obesidade grau II (severa)";
            }
            else
            {
                condicao = "Obesidade grau III (mórbida)";
            }

            // Exibe o resultado
            Console.WriteLine($"IMC: {imc:F2}");
            Console.WriteLine($"Condicao: {condicao}");

            // Aguardando a tecla pressionada antes de sair
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
