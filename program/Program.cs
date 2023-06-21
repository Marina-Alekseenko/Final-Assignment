// //Задача: 
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

