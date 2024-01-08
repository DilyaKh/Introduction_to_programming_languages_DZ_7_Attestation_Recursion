// -----------------------------------------------------------------------
// ЗАДАЧА 1

// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Clear();


Console.WriteLine("Эта программа выводит все натуральные числа в промежутке от M до N.");
Console.Write("Введите числа M и N (два числа через пробел): ");
int[] borders = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine();
Console.WriteLine($"M = {borders[0]}; N = {borders[1]} -> " +
$"\"{PrintNumbersInInterval(borders[0], borders[1])}\"");


string PrintNumbersInInterval(int M, int N)
{
    if (M == N)
        return M.ToString();
    return $"{M}, {PrintNumbersInInterval(++M, N)}";
}

// -----------------------------------------------------------------------




// -----------------------------------------------------------------------
// ЗАДАЧА 2

// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();


Console.WriteLine("Эта программа вычисляет функцию Аккермана для чисел m и n.");
Console.Write("Введите неотрицательные целые числа m и n (два числа через пробел): ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine();
Console.WriteLine($"m = {numbers[0]}, n = {numbers[1]} -> " +
$"A({numbers[0]},{numbers[1]}) = {Ackermann(numbers[0], numbers[1])}");


int Ackermann(int m, int n)
{
  if (m == 0) 
    return n + 1;
  if (n == 0) 
    return Ackermann(m - 1, 1);
  else 
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

// -----------------------------------------------------------------------




// -----------------------------------------------------------------------
// ЗАДАЧА 3

// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();


Console.WriteLine("Эта программа выводит элементы массива, начиная с конца.");
Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}] =>");
ReverseArray(array);


// Функция заполняет массив случайными числами
// из промежутка от 0 до 100 включительно ([0;100])
// (с применением рекурсии):
void InputArray(int[] array, int i = 0)
{
    Random rand = new Random();
    if (i < array.Length)
    {
        array[i] = rand.Next(0, 101); //[0;100]
        InputArray(array, ++i);
    }
}


// Функция выводит элементы массива, начиная с конца
// (с применением рекурсии):
void ReverseArray(int[] array, int i = 0)
{
    if (i < array.Length)
    {   
        ReverseArray(array, ++i);
        Console.Write($"{array[i - 1]}");

        // Доп.проверка, чтобы избежать вывода лишнего пробела 
        // после вывода последнего числа:
        if (i != 1) 
         Console.Write(" ");
    }
}


// -----------------------------------------------------------------------
// -----------------------------------------------------------------------