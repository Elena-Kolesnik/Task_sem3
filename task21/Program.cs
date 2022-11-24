// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Расстояние = $ \ sqrt {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}} $ 

using static System.Console;
Clear();


int x1 = int.Parse(ReadLine()); // координата X первой точки
int y1 = int.Parse(ReadLine()); // координата Y первой точки
int z1 = int.Parse(ReadLine()); // координата Z первой точки
int x2 = int.Parse(ReadLine()); // координата X второй точки
int y2 = int.Parse(ReadLine()); // координата Y второй точки
int z2 = int.Parse(ReadLine()); // координата Z второй точки

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double distance = Math.Sqrt(A * A + B * B + C * C);
double number = Math.Round (distance, 2);

WriteLine($"Расстояние между двумя точками равно {number}");
