// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.



int GetLength(int num) // функция определяет длину числа и передает в функцию выше
{
    int n = 0;
    while (num > 0)
    {
        num /= 10;
        n++;
    }
    return n;
}

bool СheckingPalindrome(int num) // Функция проверки числа на палиндром возвращает занчение правда / лож
{
    if (num >= 0 && num < 10)
        return true; // возвращает положительное значение
    int numLength = GetLength(num);
    int[] digits = new int[numLength]; // Создаю массив и заполняю его цифрами числа
    for (int i = numLength - 1; i >= 0; i--)
    {
        digits[i] = num % 10;
        num /= 10;
    }
    for (int i = 0; i < numLength / 2; i++) // Сравниваю числа по парно с начала и конца до середины массива
    {
        if (digits[i] != digits[numLength - i - 1])
            return false; // возвращает отрицательное значение
    }
    return true; // возвращает положительное значение
}

void PrintResult(bool t, int n) // Еше одна функция =) чтобы красиво вывести ответ на консоль, вместо true/false
{
    if (t == true)
    {
        Console.WriteLine($"Число {n} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {n} не является палиндромом");
    }
}

try // вывод в случае нормальной работы программы
{
    int num = int.Parse(Console.ReadLine());
    int n = num;
    PrintResult(СheckingPalindrome(num), n);
}
catch // вывод в случае ошибки
{
    Console.WriteLine("Вы ввели некоретные данные");
}








