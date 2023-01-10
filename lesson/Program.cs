// Задача №17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.


// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0) Console.WriteLine("Это четверть № 1");
// else if (x > 0 && y < 0) Console.WriteLine("Это четверть № 4");
// else if (x < 0 && y < 0) Console.WriteLine("Это четверть № 3");
// else if (x < 0 && y > 0) Console.WriteLine("Это четверть № 2");
// else Console.WriteLine("Точка лежит на оси");


// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x,y);
// Console.WriteLine( CheckKoord2(x,y));

// if (x > 0 && y > 0) Console.WriteLine("Это четверть № 1");
// else if (x > 0 && y < 0) Console.WriteLine("Это четверть № 4");
//делаем метод который ничего не возвращает, но что-то делает
// void CheckKoord(int x, int y)
// {
//     if (x > 0 && y > 0) Console.WriteLine("Это четверть № 1");
//     else if (x > 0 && y < 0) Console.WriteLine("Это четверть № 4");
//     else if (x < 0 && y < 0) Console.WriteLine("Это четверть № 3");
//     else if (x < 0 && y > 0) Console.WriteLine("Это четверть № 2");
//     else Console.WriteLine("Точка лежит на оси");
// }

//делаем метод который что-то возвращает
// string CheckKoord2(int x, int y)
// {
//     string res="";
//     if (x > 0 && y > 0) res = "Это четверть № 1";
//     else if (x > 0 && y < 0) res = "Это четверть № 4";
//     else if (x < 0 && y < 0) res = "Это четверть № 3";
//     else if (x < 0 && y > 0) res = "Это четверть № 2";
//     else res = "Точка лежит на оси";
//     return res;
// }


// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой 
// четверти (x и y).


// Напишите программу, которая по заданному номеру четверти, показывает  
// диапазон возможных координат точек в этой четверти (x и y). 
// try 
// { 
//     Console.WriteLine("введите четверть "); 
//     int q = Convert.ToInt32(Console.ReadLine()); 
//     if (q==1) Console.WriteLine("x>0, y>0"); 
//     else if (q==4) Console.WriteLine("x>0, y<0"); 
//     else if (q==3) Console.WriteLine("x<0, y<0"); 
//     else if (q==2) Console.WriteLine("x<0, y>0"); 
//     else Console.WriteLine("ошибка"); 
//     CheckKoord(q); 
//     Console.WriteLine(CheckKoord2(q)); 
// } 
// catch 
// { 
//     Console.WriteLine("вы ввели некоретные данные"); 
// } 
 
 
// void CheckKoord(int q) 
// { 
//     if (q==1) Console.WriteLine("x>0, y>0"); 
//     else if (q==4) Console.WriteLine("x>0, y<0"); 
//     else if (q==3) Console.WriteLine("x<0, y<0"); 
//     else if (q==2) Console.WriteLine("x<0, y>0"); 
//     else Console.WriteLine("ошибка"); 
// } 
 
 
// string CheckKoord2(int q) 
// { 
//     string res = ""; 
//     if (q==1) res = "x>0, y>0"; 
//     else if (q==4) res = "x>0, y<0"; 
//     else if (q==3) res = "x<0, y<0"; 
//     else if (q==2) res = "x<0, y>0"; 
//     else res = "ошибка"; 
//     return res; 
// }



// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// Напишите программу, которая принимает на вход координаты двух точек и  
// находит расстояние между ними в 2D пространстве. 
 
// A (3,6); B (2,1) -> 5,09  
// A (7,-5); B (1,-1) -> 7,21 
 
// A(xa, ya) и B(xb, yb)  AB = √((xb - xa)2 + (yb - ya)2). 
 
// 


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// Console.WriteLine("Введите целое число");
// int x = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i <= x; i++)
// {
//     Console.Write($"{Math.Pow(i, 2)} ");
// }

Console.WriteLine("Ввидите количество осей");
int len = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [len];

int [] arr2 = new int [len];




Console.WriteLine();

