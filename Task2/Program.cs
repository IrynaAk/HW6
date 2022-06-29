// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


using System;
using static System.Console;

Clear();


WriteLine("Please add b1, k1, b2, k2 with a space");
double[] myArray =  GetArrayFromString(ReadLine());

double b1 = myArray[0];
double k1 = myArray[1];
double b2 = myArray[2];
double k2 = myArray[3];

WriteLine($"{b1}, {k1}, {b2}, {k2}");

double y = Math.Round((b1 - (k1*b2)/k2)/(1-k1/k2),2);
double x = Math.Round((y-b1)/k1,2);

WriteLine($"y = {y}, x = {x}");


double[] GetArrayFromString(string message)
{
    string[] numbers = message.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    double[] result= new double[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = Convert.ToDouble(numbers[i]);
    }
    return result;
}

