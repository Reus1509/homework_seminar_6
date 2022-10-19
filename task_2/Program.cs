// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Main()
{
    Console.Clear();
    Console.Write("Введите k1: ");
    double k1 = double.Parse(Console.ReadLine());
    Console.Write("Введите b1: ");
    double b1 = double.Parse(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = double.Parse(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = double.Parse(Console.ReadLine());
    double x = FindX(k1, k2, b1, b2);
    double y = FindY(k1, k2, b1, b2, x);
    Console.WriteLine($"Пересечение в точке: ({x}; {y}).");
}


double FindX(double k1, double k2, double b1, double b2){
    double x = Math.Round(-(b1 - b2) / (k1 - k2), 3);
    return x;
}
double FindY(double k1, double k2, double b1, double b2, double x){
    double y = Math.Round(k1 * x + b1, 3);
    return y;
}

Main();