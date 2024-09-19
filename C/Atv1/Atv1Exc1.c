#include<stdio.h>
#include<stdlib.h>
#include<math.h>

// Fun��o para calcular resist�ncia em s�rie
float resistencia_serie(float R1, float R2, float R3) {
    return R1 + R2 + R3;
}

// Fun��o para calcular resist�ncia em paralelo
float resistencia_paralelo(float R1, float R2, float R3) {
    return 1 / ((1/R1) + (1/R2) + (1/R3));
}

int main() {
    float R1, R2, R3;
    printf("Digite os valores das tres resistencias separadas por espaco: ");
    scanf("%f %f %f", &R1, &R2, &R3);

    // Calcula resist�ncia em s�rie
    float resistencia_total_serie = resistencia_serie(R1, R2, R3);
    printf("A resistencia total em serie eh: %.2f\n", resistencia_total_serie);

    // Calcula resist�ncia em paralelo
    float resistencia_total_paralelo = resistencia_paralelo(R1, R2, R3);
    printf("A resist�ncia total em paralelo eh: %.2f\n", resistencia_total_paralelo);

    return 0;
}
