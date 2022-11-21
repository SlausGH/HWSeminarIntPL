// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int numberMethod)
{
    int sumDigitsMethod = default;
    for (int digit = default; numberMethod > 0; numberMethod /= 10)
    {
        digit = numberMethod % 10;
        sumDigitsMethod = sumDigitsMethod + digit;
    }
    return sumDigitsMethod;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine($"{number} -> {sumDigits}");
// int sumDigits = default;
// int digit = default;

// while (number > 0)
// {
//     digit = number % 10;
//     number = number / 10;
//     sumDigits = sumDigits + digit;
// }

// Console.WriteLine(sumDigits);