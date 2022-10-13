Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
Console.Write("Четные числа диапозона от 1 до N: ");
while (count < N-1)
{
    Console.Write((count+2)+" ");
    count = count + 2;
}