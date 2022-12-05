// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] mtrx = CreateMatrixRnd(RndNum(), RndNum(), -99, 99);
PrintIntMatrix(mtrx);
double[] result = AverageColumns(mtrx);
Console.Write("Average of each columns: ");
PrintDoubleArray(result);

double[] AverageColumns(int[,] matrix)
{
    double[] averageColumns = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averageColumns[j] += matrix[i, j];
        }
        averageColumns[j] /= matrix.GetLength(0);
        averageColumns[j] = Math.Round(averageColumns[j], 2);
    }
    return averageColumns;
}

int RndNum()
{
    int numberRnd = new Random().Next(2, 10);
    return numberRnd;
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

void PrintIntMatrix(int[,] matrixPrint)
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

void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i == array.Length-1) Console.WriteLine(".");
        else Console.Write("; ");
    }
}