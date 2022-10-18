Console.Write("Ввожу трехзначное число: ");
int n = new Random().Next(100, 1000);
Console.WriteLine(n);
    // Ручной ввод
    // Сonsole.Write("Введите трехзначное число: ");
    // int n = Convert.ToInt32(Console.ReadLine());
int res1 = n % 100;
int res2 = res1 / 10;
Console.Write("Вторая цифра этого числа: ");
Console.WriteLine(res2);