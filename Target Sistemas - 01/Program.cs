//int INDICE = 13, SOMA = 0, K = 0;
//Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
//Imprimir(SOMA);

//Declara variáveis
int indice = 13, soma = 0, k = 0;

//Enquanto k < indice
while (k < indice)
{
    //realiza somas
    k = k + 1;
    soma = soma + k;
    //Imprime resultado da iteração
    Console.WriteLine($"Resultado da iteração: {soma}");
}

//Imprime resultado final
Console.WriteLine($"Soma total: {soma}");