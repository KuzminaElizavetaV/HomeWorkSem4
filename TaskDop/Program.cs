/*Задача “со звездочкой”: (необязательное) Напишите функцию, которая принимает одно число - 
высоту елочки и рисует ее в консоли звездочками.
*/

void PrintSpruce(int h)
{
    if (h < 3 || h % 2 == 0)
        Console.WriteLine("Высота не соответсвует условию!");
    else
        for (int i = 0; i < h; i++)
        {
            for (int j = h - i; j >= 0; j--)
            {
                Console.Write(" ");
            }
            for (int k = 0; k <= i * 2; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();    
        }
}

Console.Write("Введите высоту ели (нечетное число, начиная с 3-х): ");
int spruceHeight = Convert.ToInt32(Console.ReadLine());
PrintSpruce(spruceHeight);


/*Console.WriteLine("Высота ели: ");
            int h = int.Parse(Console.ReadLine());
 
 
            for (int i = h; i > 0; i--)
            {
                for (int j = h - i; j <= h; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < h - i; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
 
            }
            //Console.ReadKey();*/