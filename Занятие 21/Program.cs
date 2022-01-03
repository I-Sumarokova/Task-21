using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Занятие_21
{
    class Program
    {
        public static int n;
        public static int m;
        public static int[,] array;
        public static void sadovnik1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] == 0)
                    {
                        array[i, j] = 1;
                        Thread.Sleep(1);
                    }
                }
            }
        }
        public static void sadovnik2()
        {
            for (int i = m-1; i > 0; i--)
            {
                for (int j = n-1; j > 0; j--)
                {
                    if (array[j, i] == 0)
                    {
                        array[j, i] = 2;
                        Thread.Sleep(1);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            array = new int[n, m];

            ThreadStart threadStart = new ThreadStart(sadovnik1);
            Thread myThread = new Thread(threadStart);
            myThread.Start();
            sadovnik2();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
