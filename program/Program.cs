﻿// //Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] startArray = { "Sun", "Monday", "Tu",
      "Wednesday", "Thirsday", "Fri", "Sat" };
Console.WriteLine("Исходный массив:");
for (int i = 0; i < startArray.Length; i++)
    Console.Write(String.Join(" |", startArray[i], "| "));
Console.WriteLine();

int[] lengthArray = new int[7];
GetElementsLengthArray(startArray, lengthArray);

int len = FindFinishArrayLength(lengthArray, 3);

Console.WriteLine("Итоговый массив:");
string[] finishArray = new string[len];
GetFinishArray(startArray, finishArray, 3);

int[] GetElementsLengthArray(string[] array, int[] lengthArray)
{
    for (int i = 0; i < array.Length; i++) lengthArray[i] = array[i].Length;
    return lengthArray;
}

int FindFinishArrayLength(int[] array, int lengthСondition)
{
    int lengthFinishArray = 0;
    for (int i = 0; i < lengthArray.Length; i++)
        if (lengthArray[i] <= lengthСondition) lengthFinishArray++;
    return lengthFinishArray;
}

void GetFinishArray(string[] startArray, string[] finishArray, int lengthСondition)
{
    int m = 0;
    for (int i = 0; i < startArray.Length; i++)
        if (startArray[i].Length <= lengthСondition)
        {
            finishArray[m] = startArray[i];
            Console.Write(String.Join(" |", finishArray[m], "| "));
            m++;
        }
}