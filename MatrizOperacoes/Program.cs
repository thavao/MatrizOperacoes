int qtdLinhas = 4, qtdColunas = 4;
int[,] matriz1 = new int[qtdLinhas, qtdColunas];
int[,] matriz2 = new int[qtdLinhas, qtdColunas];
int[,] matrizResultante = new int[qtdLinhas, qtdColunas];
int linhaAtual, colunaAtual;
for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
{
    for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
    {
        matriz1[linhaAtual, colunaAtual] = new Random().Next(1,50);
        matriz2[linhaAtual, colunaAtual] = new Random().Next(1,50);
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
Console.WriteLine();
Console.WriteLine("Soma:");
for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
{
    Console.WriteLine();
    for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
    {
        matrizResultante[linhaAtual, colunaAtual] = matriz1[linhaAtual, colunaAtual] + matriz2[linhaAtual, colunaAtual]; 
        Console.Write(matrizResultante[linhaAtual, colunaAtual] + " ");
    }
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Subtração:");
for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
{
    Console.WriteLine();
    for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
    {
        matrizResultante[linhaAtual, colunaAtual] = matriz1[linhaAtual, colunaAtual] - matriz2[linhaAtual, colunaAtual];
        Console.Write(matrizResultante[linhaAtual, colunaAtual] + " ");
    }
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Multiplicação:");
for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
{
    Console.WriteLine();
    for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
    {
        matrizResultante[linhaAtual, colunaAtual] = matriz1[linhaAtual, colunaAtual] * matriz2[linhaAtual, colunaAtual];
        Console.Write(matrizResultante[linhaAtual, colunaAtual] + " ");
    }
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Divisão:");
for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
{
    Console.WriteLine();
    for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
    {
        matrizResultante[linhaAtual, colunaAtual] = matriz1[linhaAtual, colunaAtual] / matriz2[linhaAtual, colunaAtual];
        Console.Write(matrizResultante[linhaAtual, colunaAtual] + " ");
    }
}
Console.WriteLine();
Console.WriteLine();
