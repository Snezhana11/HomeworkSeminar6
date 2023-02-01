// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1, y = k2 * x + b2;
// k1 * x + b1 = k2 * x + b2;
// x(k1 - k2) = b2 - b1;
// x = (b2 - b1) / (k1 - k2);

Console.WriteLine("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");
string result = "Найти точку пересечения двух прямых:";
Console.WriteLine(result);

String IntersectionPoint(int k1, int k2, int b1, int b2)
{
    if (k1 - k2 != 0)
    {
        double x = (double)(b2 - b1) / (double)(k1 - k2);
        double y = k1 * x + b1;

        return $"точка пересечения ({x:f1} ; {y:f1})";
    }
    else
    {
        return "прямые не пересекаются или совпадают";
    }
}

int b1 = 2, // y = k1 * x + b1
    k1 = 5,
    b2 = 4, // y = k2 * x + b2
    k2 = 9;
Console.WriteLine(IntersectionPoint(k1, k2, b1, b2));