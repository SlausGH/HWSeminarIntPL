Console.Write("Ввожу число: ");
int n = new Random().Next(0, 1000000000);
Console.WriteLine(n);
// Ручной ввод
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

if (n > 99)
{
    while (n > 999)
    {
        n /=10;
    }
    Console.Write("Третья цифра слева: ");
    Console.WriteLine(n % 10);
}
else 
{
    Console.Write("Третьей цифры нет");
}

// if (n < 100)
//     {
//     Console.Write("Третьей цифры нет");
//     }
// else 
// {
// if (n < 1000)
//     {
//     find = n % 10;
//     }
// else if (n < 10000)
//     {
//     find = n % 100 / 10;
//     }
// else if (n < 100000)
//     {
//     find = n % 1000 / 100;
//     }
// else if (n < 1000000)
//     {
//     find = n % 10000 / 1000;
//     }
// else if (n < 10000000)
//     {
//     find = n % 100000 / 10000;
//     }
// else if (n < 100000000)
//     {
//     find = n % 1000000 / 100000;
//     }
// Console.Write("Третья цифра слева: ");
// Console.WriteLine(find);
// }