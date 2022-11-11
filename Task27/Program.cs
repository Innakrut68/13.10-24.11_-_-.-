// 27. Напишите программу.которая принимает на вход число
//     и выдает сумму цифр в числе.
//    452 -> 11
//    82 -> 10

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

     int sum = 0;
     while (number > 0)
     {
        int i = number % 10;
        number = number / 10;
        sum = sum + i;
        i++;
     }
     


Console.WriteLine($"сумма всех цифр в числе равна {sum} ");