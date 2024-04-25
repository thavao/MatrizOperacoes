int qtdLinhas = 4, qtdColunas = 4, opcao = 0;
float[,] matriz1 = new float[qtdLinhas, qtdColunas];
float[,] matriz2 = new float[qtdLinhas, qtdColunas];
float[,] matrizResultante = new float[qtdLinhas, qtdColunas];
int linhaAtual, colunaAtual;

void EscolherOperacao()
{
    Console.WriteLine();
    Console.WriteLine("[1] - Somar | [2] - Subtrair | [3] - Multiplicação | [4] - Divisão | [0] - Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Saindo...");
            break;
        case 1:
            SomarMatriz();
            break;
        case 2:
            SubtrairMatriz();
            break;
        case 3:
            MultiplicarMatriz();
            break;
        case 4:
            DividirMatriz();
            break;
        default:
            Console.WriteLine("Opção invalida, tente novamente.");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
            break;

    }
}

void ImprimirMatriz(float[,] matriz, string titulo)
{
    Console.WriteLine(titulo);
    for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
    {
        Console.WriteLine();
        for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
        {
            Console.Write($"{matrizResultante[linhaAtual, colunaAtual]: 0.00} ");
        }
    }
}

void SomarMatriz()
{
    for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
    {
        for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
        {
            matrizResultante[linhaAtual, colunaAtual] = matriz1[linhaAtual, colunaAtual] + matriz2[linhaAtual, colunaAtual];
        }
    }
    ImprimirMatriz(matrizResultante, "Soma da matriz: ");
}

void SubtrairMatriz()
{
    for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
    {
        for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
        {
            matrizResultante[linhaAtual, colunaAtual] = matriz1[linhaAtual, colunaAtual] - matriz2[linhaAtual, colunaAtual];
        }
    }
    ImprimirMatriz(matrizResultante, "Subtração da matriz: ");
}

void MultiplicarMatriz()
{
    for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
    {
        for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
        {
            matrizResultante[linhaAtual, colunaAtual] = matriz1[linhaAtual, colunaAtual] * matriz2[linhaAtual, colunaAtual];
        }
    }
    ImprimirMatriz(matrizResultante, "Multiplicação da matriz: ");
}

void DividirMatriz()
{
    for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
    {
        for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
        {
            if (matriz2[linhaAtual, colunaAtual] != 0)
                matrizResultante[linhaAtual, colunaAtual] = matriz1[linhaAtual, colunaAtual] / matriz2[linhaAtual, colunaAtual];
            else
                matrizResultante[linhaAtual, colunaAtual] = float.NaN;
        }
    }
    ImprimirMatriz(matrizResultante, "Divisão da matriz");
}

for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
{
    for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
    {
        matriz1[linhaAtual, colunaAtual] = new Random().Next(1, 50);
        matriz2[linhaAtual, colunaAtual] = new Random().Next(1, 50);
    }
}

Console.WriteLine("Matriz 1: ");
for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
{
    Console.WriteLine();
    for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
    {
        Console.Write(matriz1[linhaAtual, colunaAtual] + " ");
    }
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Matriz 2: ");

for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
{
    Console.WriteLine();
    for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
    {
        Console.Write(matriz2[linhaAtual, colunaAtual] + " ");
    }
}

Console.WriteLine();
do
{
    EscolherOperacao();
} while (opcao != 0);
