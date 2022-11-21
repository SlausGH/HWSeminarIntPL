// Является ли 5-ти значное число палиндромом.
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 9999 && n < 100000)
{
    int firN = n / 10000;
    int secN = n / 1000 % 10;
    int fouN = n / 10 % 10;
    int fifN = n % 10;
        if (firN == fifN)
        {
            if (secN == fouN)
            {
            Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }
    else Console.WriteLine("No");
}
else Console.WriteLine("It's not a five digit number");