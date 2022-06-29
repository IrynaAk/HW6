// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

using System;
using static System.Console;

Clear();


WriteLine("Please add numbers with a space");


int[] myArray = GetArrayFromString(ReadLine());

WriteLine($"Number of positive elements: {PositiveNumbersCount(myArray)}");


int[] GetArrayFromString(string message)
{
    string[] numbers = message.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    int[] result= new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}

int PositiveNumbersCount (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count = count+1;
    }
    return count;

}

