// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] mtrx = CreateMatrixRnd(RndNum(), RndNum(), -99, 99);
Console.WriteLine("Введите индексы элемента в массиве через Entr");
int i = EnterNums();
int j = EnterNums();
PrintMatrix(mtrx);
Console.Write($"[{i}, {j}] -> ");
Console.WriteLine(SearchIndexElem(i, j, mtrx) ? mtrx[i, j]: "такого элемента в массиве нет");

bool SearchIndexElem(int k, int l, int[,] matrix)
{
    return k < matrix.GetLength(0) && l < matrix.GetLength(1);
}

int RndNum()
{
    int numberRnd = new Random().Next(2, 10);
    return numberRnd;
}

int EnterNums()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] CreateMatrixRnd(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrixPrint)
{
    for (int i = 0; i < matrixPrint.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrixPrint.GetLength(1); j++)
        {
            Console.Write($" {matrixPrint[i, j],3}");
            if (j < matrixPrint.GetLength(1) - 1) Console.Write(" |");
        }
        Console.WriteLine(" |");
    }
}