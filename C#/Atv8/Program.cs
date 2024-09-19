using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita o valor do produto
            Console.WriteLine("Informe o valor do produto (R$): ");
            double valorProduto = Convert.ToDouble(Console.ReadLine());

            // Solicita a forma de pagamento
            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1 - A Vista em Dinheiro ou Pix (15% de desconto)");
            Console.WriteLine("2 - A Vista no cartao de credito (10% de desconto)");
            Console.WriteLine("3 - Parcelado no cartao em duas vezes (preco normal do produto sem juros)");
            Console.WriteLine("4 - Parcelado no cartao em tres vezes ou mais (preco normal do produto mais juros de 10%)");
            int formaPagamento = Convert.ToInt32(Console.ReadLine());

            double valorFinal;

            // Calcula o valor final com base na forma de pagamento escolhida
            switch (formaPagamento)
            {
                case 1:
                    // 15% de desconto
                    valorFinal = valorProduto * 0.85;
                    break;
                case 2:
                    // 10% de desconto
                    valorFinal = valorProduto * 0.90;
                    break;
                case 3:
                    // Preço normal do produto sem juros
                    valorFinal = valorProduto;
                    break;
                case 4:
                    // Preço normal do produto mais juros de 10%
                    valorFinal = valorProduto * 1.10;
                    break;
                default:
                    Console.WriteLine("Forma de pagamento invalida.");
                    return;
            }

            // Exibe o valor final a ser pago
            Console.WriteLine($"Valor final a ser pago: R$ {valorFinal:F2}");

            // Aguardando a tecla pressionada antes de sair
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
