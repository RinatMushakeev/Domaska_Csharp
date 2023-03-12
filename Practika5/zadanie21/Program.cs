// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
int[] coordsA = new int[3];
int[] coordsB = new int[3];
System.Console.Write("Введите коордитинаты x точки A: ");
coordsA[0]  = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордитинаты y точки A: ");
coordsA[1]  = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордитинаты z точки A: ");
coordsA[2]  = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордитинаты x точки B: ");
coordsB[0]  = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордитинаты y точки B: ");
coordsB[1]  = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордитинаты z точки B: ");
coordsB[2]  = Convert.ToInt32(Console.ReadLine());

int distanceX = (int)Math.Pow(coordsB[0] - coordsA[0], 2);
int distanceY = (int)Math.Pow(coordsB[1] - coordsA[1], 2);
int distanceZ = (int)Math.Pow(coordsB[2] - coordsA[2], 2);
// double distanceY = Math.Pow(coordsB[1] - coordsA[1], 2);
double Result = Math.Round(Math.Sqrt(distanceX + distanceY + distanceZ), 2);

System.Console.WriteLine(Result);