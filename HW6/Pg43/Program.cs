﻿// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите k1, b1, k2, b2 попорядку через Entr");
double[] result = LineCross(EnterNums(), EnterNums(), EnterNums(), EnterNums());
PrintArray(result);

double[] LineCross(double num1, double num2, double num3, double num4)
{  
    double[] resXY = new double[2];
    resXY[0] = Math.Round((num4 - num2) / (num1 - num3), 2);
    resXY[1] = Math.Round(num1*resXY[0] + num2, 2);
    return resXY;
}

void PrintArray(double[] arrayPrint)
{
    Console.Write("(");
    for (int indexPA = 0; indexPA < arrayPrint.Length; indexPA++)
    {
        Console.Write(arrayPrint[indexPA]);
        if (indexPA < arrayPrint.Length - 1) Console.Write("; ");
    }
    Console.Write(")");
}

double EnterNums()
{
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}