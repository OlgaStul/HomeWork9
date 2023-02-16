/*   Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
 в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30   */

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

int sum = 0;

int SumNumberRec (int m, int n)
{
if (m <= n)
{
    sum = sum + m;
    m++;
    SumNumberRec (m,n);
} 
return sum;
}

int m = GetNumber("Задайте значение M: ");
int n = GetNumber("Задайте значение N: ");
Console.WriteLine (SumNumberRec(m, n)); 