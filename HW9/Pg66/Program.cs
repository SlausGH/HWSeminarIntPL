// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = default;

if (number1 < number2) result = SumNumbersInterval(number1, number2);
else result = SumNumbersInterval(number2, number1);
Console.WriteLine($"M = {number1}; N = {number2} -> {result}");

int SumNumbersInterval(int num1, int num2)
{
    if (num1 == num2) return num2;
    return num1 + SumNumbersInterval(num1 + 1, num2);
}