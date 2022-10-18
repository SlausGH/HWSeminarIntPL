Console.WriteLine("Введите номер дня недели: ");
int n = new Random().Next(1, 8);
Console.WriteLine(n);

if (n <= 5)
{
    Console.WriteLine("Это будний день. Иди на работу, кожаный ХаХа.");
}
else
{
    Console.WriteLine("Это выходной день.");
}