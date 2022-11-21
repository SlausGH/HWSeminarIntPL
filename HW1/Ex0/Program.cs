// Степени 2
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (count <= n)
{
    Console.WriteLine($"2^{count}={Math.Pow(2, count)}");
    count++;
}