// 34. Задайте массив,заполненный случайными положительными трехзначными числами.
//     Напишите программу,которя покажет количество четных чисел в массиве.

void NameArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] =  new Random().Next(100, 999);
    }
    Console.Write("]");
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ ",");
    }
    Console.Write("]");
}



void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0);
    }
    return result;
}


int[] arr = NameArray(arr);
PrintArray(arr);
Console.Write($"Количество четных чисел в массиве = {result}" );


