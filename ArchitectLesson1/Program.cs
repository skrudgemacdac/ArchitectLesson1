using System;

namespace ArchitectLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            int sum = 0;
            int max = 0;

            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            Console.WriteLine("пажалуйста введите число. ");

            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
                sum = sum + i;
                if (i % 2 == 0)
                {
                    max = i;
                }
            }
            Console.WriteLine("Факториал равен " + fact); Console.WriteLine("Сума от 1 до N равна: " + sum);

            Console.WriteLine("максимальное четное число меньше N равно: " + max);
            Console.ReadLine();
        }
    }
}
