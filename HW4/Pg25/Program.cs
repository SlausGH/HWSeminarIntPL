// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double NumberPowerOf(double numberBase, int numberExp)
{
    double result = 1;
            for (int count = 1; count <= numberExp; count++)
            {
                result = result * numberBase;
            }
    return result;
}

Console.Write("Введите основание (число A): ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень (число В): ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB >= 0)
{
    double res = NumberPowerOf(numA, numB);
    Console.WriteLine($"| {numA}, {numB} -> {res} |");
}
else Console.WriteLine("Ошибка: Введена некорректная степень. Введите положительное число.");