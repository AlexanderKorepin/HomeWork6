// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int OutNumber( int number)
{
    int result = 0;
    for(int i = 0; i < number; i++)
    {
        Console.Write($"Enter #{i + 1}: ");
        if(Convert.ToInt32(Console.ReadLine()) > 0)
            result++;
    }
    return result;
}

Console.Write("Enter the number of numbers: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" {OutNumber(number)} positive numbers");
*/
//===================================================================================================================
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; //значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
const double PARALLEL = 1;
const double HAS_INTERSECTION = 2;
const double OVERLAYLINES = 3;
double[] IntersectionPoint (double k1, double b1, double k2, double b2)
{
    double[] result = new double[3];
    if(k1 == k2 && b1 != b2)
        result[2] = PARALLEL;
    else if (k1 == k2 && b1 == b2)
        result[2] = OVERLAYLINES;
    else
    {
        result[2] = HAS_INTERSECTION;
        result[0] = (b2 - b1) / (k1 - k2); 
        result[1] = k1 * result[0] + b1; 
    }
    return result;  
}
Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double[] intersection = IntersectionPoint(k1, b1, k2, b2);
if(intersection[2] == HAS_INTERSECTION)
    Console.WriteLine($"Line y = {k1} * x + {b1} and y = {k2} * x + {b2} are intersected in the point: ({intersection[0]}; {intersection[1]})");
else if(intersection[2] == PARALLEL)
    Console.WriteLine("The lines are parallel!");
else if(intersection[2] == OVERLAYLINES)
    Console.WriteLine("Overlay lines");
*/