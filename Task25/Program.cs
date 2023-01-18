/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
Реализовать функцию возведения в степень самостоятельно!
*/

Console.Write("Введите онование А для возведения в степень, не равное нулю: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == 0 || b <= 0)
{
    Console.WriteLine("Введенные значения A и B не удовлетворяют условию!");
}
else
    Console.WriteLine($"{a}, {b} -> {Exponentiation(a, b)}");

int Exponentiation(int x, int y)
{
    int result = 1;

    for (int i = 0; i < y; i++)
    {
        result *= x;
    }
    return result;
}
