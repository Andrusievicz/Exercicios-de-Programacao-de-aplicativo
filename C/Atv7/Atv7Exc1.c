#include <stdio.h>

int main() {
    float peso, altura, imc;

    // Solicitar o peso e a altura
    printf("Digite o peso (em kg): ");
    scanf("%f", &peso);

    printf("Digite a altura (em metros): ");
    scanf("%f", &altura);

    // Calcular o IMC
    imc = peso / (altura * altura);

    // Determinar a condição de acordo com o IMC
    printf("Seu IMC eh: %.2f\n", imc);
    if (imc < 18.5) {
        printf("Condicao: Abaixo do peso\n");
    } else if (imc >= 18.5 && imc <= 24.9) {
        printf("Condicao: Peso ideal (parabéns)\n");
    } else if (imc >= 25.0 && imc <= 29.9) {
        printf("Condicao: Levemente acima do peso\n");
    } else if (imc >= 30.0 && imc <= 34.9) {
        printf("Condicao: Obesidade grau I\n");
    } else if (imc >= 35.0 && imc <= 39.9) {
        printf("Condicao: Obesidade grau II (severa)\n");
    } else {
        printf("Condicao: Obesidade grau III (mórbida)\n");
    }

    return 0;
}
