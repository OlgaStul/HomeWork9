/*   Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29   */

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0) break;
        else Console.WriteLine("Ввели не корректное число. Повторите ввод.");
    }
    return result;
}

int AckermanFunction(int m, int n)
{
    if (m == 0 && n > 0) return n + 1;
    if (m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    else return 0;
}

int m = GetNumber("Задайте значение M: ");
int n = GetNumber("Задайте значение N: ");
int AkkermanResult = AckermanFunction(m, n);
Console.Write($"Функция Аккермана для чисел m = {m} и n = {n} равна A(m,n) = {AkkermanResult}");