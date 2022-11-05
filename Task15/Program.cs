// 15. Напишите программу ,которая принимает на 
//     вход цифру ,обозначающую день недели,и 
//     проверяет.является ли этот днь выходным.

Console.WriteLine("Введите цифру от 1 до 7");                
 int number = Convert.ToInt32(Сonsole.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Выходные  дни");
}
else
{
    Console.WriteLine("Рабочие");
}