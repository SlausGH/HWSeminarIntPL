Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
Console.Write("Четные числа диапозона от 1 до N: ");
while (count < n-1)
{
    Console.Write(count+" ");
    count = count + 2;
}