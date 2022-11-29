// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

int[] array = CreateArray(7, 100, 999);
int result = GetEvenNum(array);
PrintArray(array);
Console.Write($" -> {result}");

int GetEvenNum (int[]arrayMethod)
{
    int count = default;
    for (int index = 0; index < arrayMethod.Length; index++)
    {
        if (arrayMethod[index] % 2 == 0) count++;
    }
    return count;
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