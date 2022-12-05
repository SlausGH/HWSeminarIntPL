//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] mtrx = CreateMatrixRnd(3, 4, -100, 100);
PrintMatrix(mtrx);

double[,] CreateMatrixRnd(int rows, int columns, int min, int max)
{
    double[,] matrixCreate = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrixCreate.GetLength(0); i++)
    {
        for (int j = 0; j < matrixCreate.GetLength(1); j++)
        {
            double number = rnd.NextDouble() * (max - min) + min;
            matrixCreate[i, j] = Math.Round(number, 2);
        }
    }
    return matrixCreate;
}

void PrintMatrix(double[,] matrixPrint)
{
    for (int i = 0; i < matrixPrint.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrixPrint.GetLength(1); j++)
        {
            Console.Write($" {matrixPrint[i, j],6}");
            if (j < matrixPrint.GetLength(1) - 1) Console.Write(" |");
        }
        Console.WriteLine(" |");
    }
}
