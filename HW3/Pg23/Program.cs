// Кубы чиисел от 1 до N

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= n)
{
    double coub = Math.Pow(count, 3);
    Console.WriteLine($"{count}^3 = {coub}");
    count++;
}