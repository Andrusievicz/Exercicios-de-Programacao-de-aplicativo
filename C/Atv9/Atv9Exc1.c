#include <stdio.h>
#include <math.h>

void calcularResistenciaSerieParalelo3() {
    float R1, R2, R3, RtSerie, RtParalelo;
    char R1_def = 'N', R2_def = 'N', R3_def = 'N';
    float V, I;

    printf("Digite a resistencia R1 (ou '0' se desconhecida): ");
    scanf("%f", &R1);
    printf("Digite a resistencia R2 (ou '0' se desconhecida): ");
    scanf("%f", &R2);
    printf("Digite a resistencia R3 (ou '0' se desconhecida): ");
    scanf("%f", &R3);

    if (R1 == 0 || R2 == 0 || R3 == 0) {
        printf("Digite a voltagem (V): ");
        scanf("%f", &V);
        printf("Digite a corrente (I): ");
        scanf("%f", &I);
        if (R1 == 0) R1 = V / I;
        if (R2 == 0) R2 = V / I;
        if (R3 == 0) R3 = V / I;
    }

    RtSerie = R1 + R2 + R3;
    RtParalelo = 1 / ((1/R1) + (1/R2) + (1/R3));

    printf("Resistencia Total em Serie: %.2f ohms\n", RtSerie);
    printf("Resistencia Total em Paralelo: %.2f ohms\n", RtParalelo);
}

void calcularResistenciaSerieParaleloN() {
    int n;
    float V, I, RtSerie = 0, RtParalelo = 0;

    printf("Digite o numero de resistencias: ");
    scanf("%d", &n);

    float resistencias[n];
    for (int i = 0; i < n; i++) {
        printf("Digite a resistencia R%d (ou '0' se desconhecida): ", i + 1);
        scanf("%f", &resistencias[i]);
    }

    for (int i = 0; i < n; i++) {
        if (resistencias[i] == 0) {
            printf("Digite a voltagem (V) para R%d: ", i + 1);
            scanf("%f", &V);
            printf("Digite a corrente (I) para R%d: ", i + 1);
            scanf("%f", &I);
            resistencias[i] = V / I;
        }
        RtSerie += resistencias[i];
        RtParalelo += 1 / resistencias[i];
    }

    RtParalelo = 1 / RtParalelo;

    printf("Resistencia Total em Serie: %.2f ohms\n", RtSerie);
    printf("Resistencia Total em Paralelo: %.2f ohms\n", RtParalelo);
}

void calcularMediaAritmetica4() {
    float notas[4], soma = 0, media;

    for (int i = 0; i < 4; i++) {
        printf("Digite a nota %d: ", i + 1);
        scanf("%f", &notas[i]);
        soma += notas[i];
    }

    media = soma / 4;
    printf("Media: %.2f\n", media);
    printf("%s\n", (media >= 7) ? "APROVADO" : "REPROVADO");
}

void calcularMediaAritmeticaN() {
    int n;
    float soma = 0, media;

    printf("Digite o numero de notas: ");
    scanf("%d", &n);

    float notas[n];
    for (int i = 0; i < n; i++) {
        printf("Digite a nota %d: ", i + 1);
        scanf("%f", &notas[i]);
        soma += notas[i];
    }

    media = soma / n;
    printf("Media: %.2f\n", media);
    printf("%s\n", (media >= 7) ? "APROVADO" : "REPROVADO");
}

void calcularCustoViagem() {
    float distancia, consumo, preco_etanol, preco_gasolina, preco_diesel, tanque;

    printf("Digite a distancia percorrida (km): ");
    scanf("%f", &distancia);
    printf("Digite o consumo medio do veiculo (km/l): ");
    scanf("%f", &consumo);
    printf("Digite o preco do etanol por litro (R$): ");
    scanf("%f", &preco_etanol);
    printf("Digite o preco da gasolina por litro (R$): ");
    scanf("%f", &preco_gasolina);
    printf("Digite o preco do diesel por litro (R$): ");
    scanf("%f", &preco_diesel);
    printf("Digite o tamanho do tanque de combustivel (l): ");
    scanf("%f", &tanque);

    float litros = distancia / consumo;
    float custo_etanol = litros * preco_etanol;
    float custo_gasolina = litros * preco_gasolina;
    float custo_diesel = litros * preco_diesel;

    printf("Valor total gasto com etanol: R$ %.2f\n", custo_etanol);
    printf("Valor total gasto com gasolina: R$ %.2f\n", custo_gasolina);
    printf("Valor total gasto com diesel: R$ %.2f\n", custo_diesel);

    printf("Quantidade de tanques de etanol utilizados: %.2f\n", custo_etanol / (tanque * preco_etanol));
    printf("Quantidade de tanques de gasolina utilizados: %.2f\n", custo_gasolina / (tanque * preco_gasolina));
    printf("Quantidade de tanques de diesel utilizados: %.2f\n", custo_diesel / (tanque * preco_diesel));
}

void converterTemperatura() {
    float temp, convertida;
    int opcao;

    printf("Digite a temperatura: ");
    scanf("%f", &temp);

    printf("Selecione a conversao:\n");
    printf("1 - Celsius para Fahrenheit\n");
    printf("2 - Fahrenheit para Celsius\n");
    printf("3 - Celsius para Kelvin\n");
    printf("4 - Kelvin para Celsius\n");
    scanf("%d", &opcao);

    switch (opcao) {
        case 1:
            convertida = temp * 1.8 + 32;
            printf("%.2f Celsius = %.2f Fahrenheit\n", temp, convertida);
            break;
        case 2:
            convertida = (temp - 32) / 1.8;
            printf("%.2f Fahrenheit = %.2f Celsius\n", temp, convertida);
            break;
        case 3:
            convertida = temp + 273.15;
            printf("%.2f Celsius = %.2f Kelvin\n", temp, convertida);
            break;
        case 4:
            convertida = temp - 273.15;
            printf("%.2f Kelvin = %.2f Celsius\n", temp, convertida);
            break;
        default:
            printf("Opcao invalida!\n");
    }
}

void calcularIMC() {
    float peso, altura, imc;

    printf("Digite o peso (kg): ");
    scanf("%f", &peso);
    printf("Digite a altura (m): ");
    scanf("%f", &altura);

    imc = peso / (altura * altura);

    printf("IMC: %.2f\n", imc);
    if (imc < 18.5) {
        printf("Abaixo do peso\n");
    } else if (imc < 25) {
        printf("Peso ideal (parabens)\n");
    } else if (imc < 30) {
        printf("Levemente acima do peso\n");
    } else if (imc < 35) {
        printf("Obesidade grau I\n");
    } else if (imc < 40) {
        printf("Obesidade grau II (severa)\n");
    } else {
        printf("Obesidade grau III (morbida)\n");
    }
}

void calcularPagamento() {
    float valor, valor_final;
    int opcao;

    printf("Digite o valor do produto (R$): ");
    scanf("%f", &valor);

    printf("Selecione a forma de pagamento:\n");
    printf("1 - A vista em dinheiro ou Pix (15%% de desconto)\n");
    printf("2 - A vista no cartao de credito (10%% de desconto)\n");
    printf("3 - Parcelado no cartao em duas vezes (preço normal)\n");
    printf("4 - Parcelado no cartao em tres vezes ou mais (10%% de juros)\n");
    scanf("%d", &opcao);

    switch (opcao) {
        case 1:
            valor_final = valor * 0.85;
            break;
        case 2:
            valor_final = valor * 0.90;
            break;
        case 3:
            valor_final = valor;
            break;
        case 4:
            valor_final = valor * 1.10;
            break;
        default:
            printf("Opcao invalida!\n");
            return;
    }

    printf("Valor final a ser pago: R$ %.2f\n", valor_final);
}

int main() {
    int escolha;

    while (1) {
        printf("Menu:\n");
        printf("1 - Calcular resistencia de circuitos (3 resistencias)\n");
        printf("2 - Calcular resistencia de circuitos (n resistencias)\n");
        printf("3 - Calcular media aritmetica (4 notas)\n");
        printf("4 - Calcular media aritmetica (n notas)\n");
        printf("5 - Calcular custo de viagem\n");
        printf("6 - Converter temperatura\n");
        printf("7 - Calcular IMC\n");
        printf("8 - Calcular pagamento\n");
        printf("0 - Sair\n");
        printf("Escolha uma opcao: ");
        scanf("%d", &escolha);

        switch (escolha) {
            case 1:
                calcularResistenciaSerieParalelo3();
                break;
            case 2:
                calcularResistenciaSerieParaleloN();
                break;
            case 3:
                calcularMediaAritmetica4();
                break;
            case 4:
                calcularMediaAritmeticaN();
                break;
            case 5:
                calcularCustoViagem();
                break;
            case 6:
                converterTemperatura();
                break;
            case 7:
                calcularIMC();
                break;
            case 8:
                calcularPagamento();
                break;
            case 0:
                return 0;
            default:
                printf("Opcao invalida!\n");
                break;
        }
    }

    return 0;
}
