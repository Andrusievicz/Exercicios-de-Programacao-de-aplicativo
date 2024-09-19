#include <stdio.h>

int main() {
    float temperatura, temperatura_convertida;
    int opcao;

    // Solicitar a temperatura inicial
    printf("Digite a temperatura inicial: ");
    scanf("%f", &temperatura);

    // Solicitar a op��o de convers�o
    printf("Selecione a opcao de conversao:\n");
    printf("1. Celsius para Fahrenheit\n");
    printf("2. Fahrenheit para Celsius\n");
    printf("3. Celsius para Kelvin\n");
    printf("4. Kelvin para Celsius\n");
    scanf("%d", &opcao);

    // Realizar a convers�o com base na op��o selecionada
    switch (opcao) {
        case 1:
            temperatura_convertida = temperatura * 1.8 + 32;
            printf("%.2f Celsius equivale a %.2f Fahrenheit\n", temperatura, temperatura_convertida);
            break;
        case 2:
            temperatura_convertida = (temperatura - 32) / 1.8;
            printf("%.2f Fahrenheit equivale a %.2f Celsius\n", temperatura, temperatura_convertida);
            break;
        case 3:
            temperatura_convertida = temperatura + 273.15;
            printf("%.2f Celsius equivale a %.2f Kelvin\n", temperatura, temperatura_convertida);
            break;
        case 4:
            temperatura_convertida = temperatura - 273.15;
            printf("%.2f Kelvin equivale a %.2f Celsius\n", temperatura, temperatura_convertida);
            break;
        default:
            printf("Op��o inv�lida!\n");
            break;
    }

    return 0;
}
