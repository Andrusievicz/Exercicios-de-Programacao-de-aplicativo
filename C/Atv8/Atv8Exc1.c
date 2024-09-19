#include <stdio.h>

int main() {
    float valor_produto, valor_final;
    int forma_pagamento;

    // Solicitar o valor do produto
    printf("Digite o valor do produto: R$ ");
    scanf("%f", &valor_produto);

    // Solicitar a forma de pagamento
    printf("Escolha a forma de pagamento:\n");
    printf("1 - A vista em dinheiro ou Pix (recebe 15%% de desconto)\n");
    printf("2 - A vista no cartao de credito (recebe 10%% de desconto)\n");
    printf("3 - Parcelado no cartao em duas vezes (preco normal do produto sem juros)\n");
    printf("4 - Parcelado no cartao em tres vezes ou mais (preco normal do produto mais juros de 10%%)\n");
    scanf("%d", &forma_pagamento);

    // Calcular o valor final de acordo com a forma de pagamento
    switch (forma_pagamento) {
        case 1:
            valor_final = valor_produto - (valor_produto * 0.15);
            printf("Valor final a ser pago: R$ %.2f\n", valor_final);
            break;
        case 2:
            valor_final = valor_produto - (valor_produto * 0.10);
            printf("Valor final a ser pago: R$ %.2f\n", valor_final);
            break;
        case 3:
            valor_final = valor_produto;
            printf("Valor final a ser pago: R$ %.2f\n", valor_final);
            break;
        case 4:
            valor_final = valor_produto + (valor_produto * 0.10);
            printf("Valor final a ser pago: R$ %.2f\n", valor_final);
            break;
        default:
            printf("Opcao de pagamento invalida!\n");
            break;
    }

    return 0;
}
