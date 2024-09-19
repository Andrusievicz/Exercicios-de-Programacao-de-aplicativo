#include <stdio.h>

int main() {
    int num_notas;
    float nota, soma = 0, media;

    printf("Digite o numero de notas: ");
    scanf("%d", &num_notas);

    printf("Digite as notas separadas por espacos:\n");
    for (int i = 0; i < num_notas; i++) {
        scanf("%f", &nota);
        soma += nota;
    }

    // Calcula a média aritmética
    media = soma / num_notas;

    printf("A media eh: %.2f\n", media);

    // Verifica se o aluno foi aprovado ou reprovado
    if (media >= 7.0) {
        printf("APROVADO\n");
    } else {
        printf("REPROVADO\n");
    }

    return 0;
}
