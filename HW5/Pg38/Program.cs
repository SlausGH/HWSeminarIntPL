// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArray(7, -30, 100);
double result = Math.Round(NumDiff(ArrayMax(array), ArrayMin(array)), 1);
PrintArray(array);
Console.Write($" -> {result}");

double NumDiff(double number1, double number2)
{
    double numDiff = default;
    if (number2 > number1) numDiff = number2 - number1;
    else numDiff = number1 - number2;
    return numDiff;
}

double ArrayMax(double[] arrayMethodMax)
{
    double maxElem = arrayMethodMax[0];
    for (int index = 1; index < arrayMethodMax.Length; index++)
    {
        if (arrayMethodMax[index] > maxElem) maxElem = arrayMethodMax[index];
    }
    return maxElem;
}

double ArrayMin(double[] arrayMethodMin)
{
    double minElem = arrayMethodMin[0];
    for (int index = 1; index < arrayMethodMin.Length; index++)
    {
        if (arrayMethodMin[index] < minElem) minElem = arrayMethodMin[index];
    }
    return minElem;
}

double[] CreateArray(int sizeArray, int minNumber, int maxNumber)
{
    double[] arrayCreate = new double[sizeArray];
    Random rnd = new Random();
    for (int indexCreate = 0; indexCreate < sizeArray; indexCreate++)
    {
        double number = rnd.NextDouble() * (maxNumber - minNumber) + minNumber;
        arrayCreate[indexCreate] = Math.Round(number, 1);
    }
    return arrayCreate;
}

void PrintArray(double[] arrayPrint)
{
    Console.Write("[");
    for (int indexPA = 0; indexPA < arrayPrint.Length; indexPA++)
    {
        Console.Write(arrayPrint[indexPA]);
        if (indexPA < arrayPrint.Length - 1) Console.Write(" ");
    }
    Console.Write("]");
}