// 21. Напишите программу,которая принимает на вход
//     координаты двух точек и находит расстояние между ними в 3D
//     пространстве.
//    A (3,6,8); B(2,1,-7), -> 15.84

Console.Write("Введите координаты точки x1 :");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки y1 :");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки с1 :");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки x2 :");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки y2 :");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кординаты точки c2 :");
int c2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11, int c11, int x21, int y21, int c21)
{
    int rangeX = x11 - x21;
    int rangeY = y11 - y21;
    int rangeC = c11 - c21;
    double rangeZ = Math.Sqrt(rangeX * rangeX + rangeY * rangeY + rangeC * rangeC );
    return rangeZ;
}

double result = Range(x1,y1,c1,x2,y2,c2);
Console.Write($"A ({x1},{y1},{c1}; B ({x2},{y2},{c2}) -> {Math.Round(result, 2,MidpointRounding.ToZero)}");