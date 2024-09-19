#include <stdio.h>

// Fun��o para calcular resist�ncia em s�rie
float resistencia_serie(float resistencias[], int tamanho) {
    float total = 0;
    for (int i = 0; i < tamanho; i++) {
        total += resistencias[i];
    }
    return total;
}

// Fun��o para calcular resist�ncia em paralelo
float resistencia_paralelo(float resistencias[], int tamanho) {
    float total = 0;
    for (int i = 0; i < tamanho; i++) {
        total += 1 / resistencias[i];
    }
    return 1 / total;
}

int main() {
    int num_resistencias;
    printf("Digite o numero de resistencias: ");
    scanf("%d", &num_resistencias);

    float resistencias[num_resistencias];
    printf("Digite os valores das resistencias separados por espaco: ");
    for (int i = 0; i < num_resistencias; i++) {
        scanf("%f", &resistencias[i]);
    }

    // Calcula resist�ncia em s�rie
    float resistencia_total_serie = resistencia_serie(resistencias, num_resistencias);
    printf("A resistencia total em serie eh: %.2f\n", resistencia_total_serie);

    // Calcula resist�ncia em paralelo
    float resistencia_total_paralelo = resistencia_paralelo(resistencias, num_resistencias);
    printf("A resistencia total em paralelo eh: %.2f\n", resistencia_total_paralelo);

    return 0;
}
