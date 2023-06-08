/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 x = k1 * x + b1 y = k2 * x + b2 значения b1, k1, b2 и k2 задаются пользователем.
 */
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


double b1 = ReadInt("введите значение b1 ");
double k1 = ReadInt("введите число k1 ");
double b2 = ReadInt("введите значение b2 ");
double k2 = ReadInt("введите число k2 ");

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

