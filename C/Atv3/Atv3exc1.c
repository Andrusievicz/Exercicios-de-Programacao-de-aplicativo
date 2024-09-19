#include <stdio.h>

int main() {
    float nota1, nota2, nota3, nota4, media;

    printf("Digite as quatro notas separadas por espacos: ");
    scanf("%f %f %f %f", &nota1, &nota2, &nota3, &nota4);

    // Calcula a média aritmética
    media = (nota1 + nota2 + nota3 + nota4) / 4;

    printf("A media eh: %.2f\n", media);

    // Verifica se o aluno foi aprovado ou reprovado
    if (media >= 7.0) {
        printf("APROVADO\n");
    } else {
        printf("REPROVADO\n");
    }

    return 0;
}
