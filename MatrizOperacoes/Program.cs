int qtdLinhas = 4, qtdColunas = 4, opcao = 0;

int linhaAtual, colunaAtual;
int minimo = 1, maximo = 50;

void DefinirTamanhoDaMatriz()
{
    Console.Write("Digite a quantidade de linhas: ");
    qtdLinhas = int.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade de colunas: ");
    qtdColunas = int.Parse(Console.ReadLine());
}

DefinirTamanhoDaMatriz();
float[,] matriz1 = new float[qtdLinhas, qtdColunas];
float[,] matriz2 = new float[qtdLinhas, qtdColunas];
float[,] matrizResultante = new float[qtdLinhas, qtdColunas];

void SortearMatriz()
{
    for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
    {
        for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
        {
            matriz1[linhaAtual, colunaAtual] = new Random().Next(minimo, maximo + 1);
            matriz2[linhaAtual, colunaAtual] = new Random().Next(minimo, maximo + 1);
        }
    }
}
int EscolherOperacao()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("[1] - Somar | [2] - Subtrair | [3] - Multiplicar | [4] - Dividir | [0] - Sair");
    return opcao = int.Parse(Console.ReadLine());
}

void ImprimirMatriz(float[,] matriz, string titulo)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(titulo);
    for (linhaAtual = 0; linhaAtual < qtdLinhas; linhaAtual++)
    {
        Console.WriteLine();
        for (colunaAtual = 0; colunaAtual < qtdColunas; colunaAtual++)
        {
            Console.Write($"{matriz[linhaAtual, colunaAtual]: 0.00} ");
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


Console.WriteLine();


SortearMatriz();
ImprimirMatriz(matriz1, "Matriz 1");
ImprimirMatriz(matriz2, "Matriz 2");

do
{
    switch (EscolherOperacao())
    {
        case 0:
            Console.WriteLine("Saindo...");
            Console.WriteLine("Pressione Enter para encerrar...");
            Console.ReadLine();
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

} while (opcao != 0);
