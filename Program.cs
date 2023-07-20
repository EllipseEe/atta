// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);

// string PrintNumbers(int n, int end){
//     if (n == end) return n.ToString();
//     return (n +","+ PrintNumbers(n - 1, end));
// }
// Console.WriteLine($"{PrintNumbers(n, 1)}");

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите значение M: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.Write("Введите значение N:");
// int n = int.Parse(Console.ReadLine()!);

// int printNumbers(int m, int n)
// {
// if (m==n) return n;
// return m + printNumbers(m + 1, n);
// }
// Console.Writeline($"Сумма натуральных элементов в промежутке от M до N равна : {printNumbers(m,n)}");


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите значение M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение N: ");
// int n = int.Parse(Console.ReadLine()!);

// int akkerman(int m, int n)
// {
// if (m == 0) return n + 1;
// if (n == 0) return akkerman(m - 1, 1);
// return akkerman(m - 1, akkerman(m, n - 1));
// }

// Console.Writeline($"Функция Аккермана равна = {akkerman(m, n)} ");