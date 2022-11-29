// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateArray(7, -100, 100);
int result = GetSumOddPos(array);
PrintArray(array);
Console.Write($" -> {result}");

int GetSumOddPos(int [] arrayM)
{
    int sumOddPos = default;
    for (int index = 1; index < arrayM.Length; index+=2)
    {
        sumOddPos += arrayM[index];
    }
    return sumOddPos;
}

int[] CreateArray(int sizeArray, int minNumber, int maxNumber)
{
    int[] arrayCreate = new int[sizeArray];
    Random rnd = new Random();
    for (int indexCreate = 0; indexCreate < sizeArray; indexCreate++)
    {
        arrayCreate[indexCreate] = rnd.Next(minNumber, maxNumber + 1);
    }
    return arrayCreate;
}

void PrintArray(int[] arrayPrint)
{
    Console.Write("[");
    for (int indexPA = 0; indexPA < arrayPrint.Length; indexPA++)
    {
        Console.Write(arrayPrint[indexPA]);
        if (indexPA < arrayPrint.Length - 1) Console.Write(" ");
    }
    Console.Write("]");
}

