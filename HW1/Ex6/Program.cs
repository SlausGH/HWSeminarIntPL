Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int rem = num1%2;
if (rem == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число НЕ четное");
}