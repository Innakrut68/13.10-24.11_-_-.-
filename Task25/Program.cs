// 25. Напишите цикл ,который принимает на вход два числа
//     (А и В) и возводит число А в натуральную степень В.
//     
//     3, 5 ->  243 
//     2, 4 ->  16

Console.WriteLine("Введите число А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int numB = Convert.ToInt32(Console.ReadLine());

int DegreeOfNumber(int numA, int numB)
{
    int count = 1;
    int numC = 1;
    if (numB > 0)
    {
        numC = numA * numA;
        count++;
    }
    return numC;
}

int numC = DegreeOfNumber(numA,numB);
Console.WriteLine($"Число {numA} в степени {numB}");



    

