using System;

namespace IngloriousLab2._3
{
    public class Program
    {
        static public void Main()
        {
            int n;
            Console.WriteLine("Введіть кількість елементів масиву");
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            Console.WriteLine("Елементи масиву:");

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("Введіть елемент №" + i);
                a[i] = int.Parse(Console.ReadLine());
            }

            Product(n, a);

            ElementsSum(n, a);
            
            }

        static public int Product(int n, int[] a)
        {
            int p = 1;

            for (int i = 1; i < n; i += 2)
            {
                p *= a[i];
            }

            Console.WriteLine("Добуток парних елементів масиву = " + p);

            return p;
        }

        static public int ElementsSum(int n, int[] a)
        {
            int max = a[0];
            int j = 0;

            for (int i = 0; i < n; ++i)
            {
                if (Math.Abs(a[i]) > max)
                {
                    max = a[i];
                    j = i;
                }
            }

            int sum = 0;

            for (int i = 0; i < j; ++i)
            {
                sum += a[i];
            }

            Console.WriteLine("Сума елементів масиву до максимального = " + sum);

            return sum;
        }
    }
}
