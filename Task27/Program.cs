/*Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
//Данную функцию я решила реализовать с помощью рекурсии
int SumNum(int num)
{
    if (num <= 0)
    {
        return 0;
    }
    return num % 10 + SumNum(num / 10);
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} равна {SumNum(number)}");
