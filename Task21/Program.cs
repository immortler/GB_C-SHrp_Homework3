/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double GetNumber(string message)
{
    bool isCorrect = false;
    double result = 0;
    while (!isCorrect) 
    {
        Console.WriteLine(message);        
        if (double.TryParse(Console.ReadLine(), out result))
        {
        isCorrect = true;
        }        
        else
        {
        Console.WriteLine("Error. Enter correct data.");
        }        
    }
    return result;
}

double GetDistanceInSpace(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

double x1 = GetNumber("Enter x of point A:");
double y1 = GetNumber("Enter y of point A:");
double z1 = GetNumber("Enter z of point A:");
double x2 = GetNumber("Enter x of point B:");
double y2 = GetNumber("Enter y of point B:");
double z2 = GetNumber("Enter z of point B:");

double distance = Math.Round(GetDistanceInSpace(x1, y1, z1, x2, y2, z2), 2);

Console.WriteLine($"Distanse between A ({x1}, {y1}, {z1}) and B ({x2}, {y2}, {z2}) is {distance}.");