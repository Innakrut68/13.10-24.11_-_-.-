// 23. Напишите программу ,которая пранимает на вход число (N)
//     и выдает таблицу кубов чисел от 1 до N.
//     5->
//     1 | 1
//    2 | 8

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

void CubeTable(int n)
{
    if (n > 0)
    {
        for (int i = 1; i <= n; i++ )
        {
            Console.WriteLine($"|{i} | {i * i * i}|");
        }
    }
    else
    {
        Console.WriteLine("Введите значение больше 0");
    }
}

CubeTable(n);

