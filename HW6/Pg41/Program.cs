// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите кол-во чисел: ");
int amountNum = Convert.ToInt32(Console.ReadLine());
int[] enterNums = EnterNums(amountNum);
int result = SearchPositiveNums(enterNums);
PrintArray(enterNums);
Console.Write($" -> {result}");

int SearchPositiveNums(int[] arrayM)
{
    int count = default;
    for (int i = 0; i < arrayM.Length; i++)
    {
        if (arrayM[i] > 0) count++;
    }
    return count;
}

int[] EnterNums(int number)
{
    Console.WriteLine("Введите числа через Entr");
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arrayPrint)
{
    Console.Write("[");
    for (int indexPA = 0; indexPA < arrayPrint.Length; indexPA++)
    {
        Console.Write(arrayPrint[indexPA]);
        if (indexPA < arrayPrint.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}