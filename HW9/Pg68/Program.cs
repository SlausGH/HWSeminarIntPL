// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int num1 = EntrNum();
Console.Write("Введите число n: ");
int num2 = EntrNum();

while(num1 < 0 || num2 < 0)
{
    Console.WriteLine("Введены не корректные данные");
    Console.WriteLine("Введите положительные целые чилсла");
    Console.Write("Введите число m: ");
    num1 = EntrNum();
    Console.Write("Введите число n: ");
    num2 = EntrNum();
}

int result = AckermanFunction(num1, num2);
Console.WriteLine(result);

int AckermanFunction(int number1, int number2)
{
    if (number1 == 0) return number2 + 1;
    if (number2 == 0) return AckermanFunction(number1 - 1, 1);
    return AckermanFunction(number1 - 1, AckermanFunction(number1, number2 - 1));
}


int EntrNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
