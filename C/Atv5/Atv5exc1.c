#include <stdio.h>

int main() {
    float distancia, consumo_medio, preco_combustivel_etanol, preco_combustivel_gasolina, preco_combustivel_diesel;
    float tamanho_tanque, valor_total_gasto, consumo_litro, tanques_utilizados_etanol, tanques_utilizados_gasolina, tanques_utilizados_diesel;

    // Informar dados
    printf("Informe a distancia percorrida (em Km): ");
    scanf("%f", &distancia);

    printf("Informe o consumo medio do veiculo (Km/l): ");
    scanf("%f", &consumo_medio);

    printf("Informe o preco do combustivel por litro de Etanol (R$): ");
    scanf("%f", &preco_combustivel_etanol);

    printf("Informe o preco do combustivel por litro de Gasolina (R$): ");
    scanf("%f", &preco_combustivel_gasolina);

    printf("Informe o preco do combustivel por litro de Diesel (R$): ");
    scanf("%f", &preco_combustivel_diesel);

    printf("Informe o tamanho do tanque de combustivel (em litros): ");
    scanf("%f", &tamanho_tanque);

    // Cálculos
    valor_total_gasto = (distancia / consumo_medio);
    consumo_litro = valor_total_gasto / preco_combustivel_etanol;
    tanques_utilizados_etanol = valor_total_gasto / (tamanho_tanque * preco_combustivel_etanol);
    tanques_utilizados_gasolina = valor_total_gasto / (tamanho_tanque * preco_combustivel_gasolina);
    tanques_utilizados_diesel = valor_total_gasto / (tamanho_tanque * preco_combustivel_diesel);

    // Exibição dos resultados
    printf("\nRESULTADOS:\n");
    printf("Valor total gasto com Etanol (R$): %.2f\n", valor_total_gasto * preco_combustivel_etanol);
    printf("Consumo de Etanol (litros): %.2f\n", consumo_litro * preco_combustivel_etanol);
    printf("Quantidade de tanques de Etanol utilizados: %.2f\n", tanques_utilizados_etanol);

    printf("\n");

    printf("Valor total gasto com Gasolina (R$): %.2f\n", valor_total_gasto * preco_combustivel_gasolina);
    printf("Consumo de Gasolina (litros): %.2f\n", consumo_litro * preco_combustivel_gasolina);
    printf("Quantidade de tanques de Gasolina utilizados: %.2f\n", tanques_utilizados_gasolina);

    printf("\n");

    printf("Valor total gasto com Diesel (R$): %.2f\n", valor_total_gasto * preco_combustivel_diesel);
    printf("Consumo de Diesel (litros): %.2f\n", consumo_litro * preco_combustivel_diesel);
    printf("Quantidade de tanques de Diesel utilizados: %.2f\n", tanques_utilizados_diesel);

    return 0;
}
