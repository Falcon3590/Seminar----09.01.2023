// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите число N");

int n = int.Parse(Console.ReadLine());

int[] array = new int[n];

Console.Write($"Талица кубов чисел от 1 до {n}[");

for (int i = 0; i < n; i++)

{

    array[i] = Convert.ToInt32(Math.Pow(i + 1, 3));
    Console.Write($"{array[i]}, ");

}

Console.WriteLine("]");


