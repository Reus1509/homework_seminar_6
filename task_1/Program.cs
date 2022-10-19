// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
void Main()
{
    Console.Clear();
    int[] array = NewArray();
    int count = Count(array);
    Console.WriteLine($"Кол-во элементов больше 0: {count}.");
}

int[] NewArray()
{
    Console.Write("Введите числа через пробел: ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return arr;
}

int Count(int[] arr)
{
    int count = 0;
 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Main();