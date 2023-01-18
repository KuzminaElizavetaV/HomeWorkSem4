/*Задача 29: Напишите программу, которая задаёт массив из N элементов, 
заполненных случайными числами из [a, b] и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33]
*/

void SetArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    Console.WriteLine($"{N}, {a}, {b} -> [{String.Join(", ", arr)}]");
}

Console.Write("Введите число (N) элементов массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное значение элемента массива: ");
int beginNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное значение элемента массива: ");
int endNum = Convert.ToInt32(Console.ReadLine());

SetArray(sizeArr, beginNum, endNum);
