// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void FillArray(int[] arrayFill)
{
    for (int fIndex = 0; fIndex < arrayFill.Length; fIndex++)
    {
        arrayFill[fIndex] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] arrayPrint)
{
    for (int pIndex = 0; pIndex < arrayPrint.Length; pIndex++)
    {
        Console.Write(arrayPrint[pIndex]);
        if (pIndex < arrayPrint.Length - 1) Console.Write(", ");
    }
    Console.Write(" -> [");
    for (int pIndex = 0; pIndex < arrayPrint.Length; pIndex++)
    {
        Console.Write(arrayPrint[pIndex]);
        if (pIndex < arrayPrint.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);