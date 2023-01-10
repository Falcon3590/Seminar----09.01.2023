// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в
// N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

// Использую для вычесления формулу: Расстояние =  Корень из (x2-x1)^{2} + (y2-y1)^{2} + (z2-z1)^{2}




double[] Coordinates(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)

    {
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

void distance(double[] First, double[] Second, int len)
{
    double temp = 0;
    for (int i = 0; i < len; i++)
    {
        temp += (Math.Pow(Second[i] - First[i], 2));
    }

    Console.WriteLine ($"Расстояние между точками = {Math.Sqrt(temp)}");    
}

Console.WriteLine("Введите количество измерений пространства: ");

int len = Convert.ToInt32(Console.ReadLine());

double[] FirstPoint = new double[len];
Console.WriteLine("Введите координаты 1ой точки: ");
FirstPoint = Coordinates(FirstPoint);

double[] SecondPoint = new double[len];
Console.WriteLine("Введите координаты 2ой точки: ");
SecondPoint = Coordinates(SecondPoint);

distance(FirstPoint, SecondPoint, len);




// void distance(Double x1, Double y1,
//                      Double z1, Double x2,
//                      Double y2, Double z2)
// {
//     double temp = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
//     Console.WriteLine("Расстояние между точками 1 и 2 = " + temp);
//     return;

// }

// Console.WriteLine("Введите координаты х1=");
// Double x1 = Double.Parse(Console.ReadLine());

// Console.WriteLine("Введите координаты у1=");
// Double y1 = Double.Parse(Console.ReadLine());

// Console.WriteLine("Введите координаты z1=");
// Double z1 = Double.Parse(Console.ReadLine());

// Console.WriteLine("Введите координаты х2=");
// Double x2 = Double.Parse(Console.ReadLine());

// Console.WriteLine("Введите координаты у2=");
// Double y2 = Double.Parse(Console.ReadLine());

// Console.WriteLine("Введите координаты z2=");
// Double z2 = Double.Parse(Console.ReadLine());

// distance(x1, y1, z1, x2, y2, z2);


