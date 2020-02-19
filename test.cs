using System;

namespace Array2dApplication
{

    class Array2d
    {

        static void Main(string[] args)
        {

            int[] b;
            b = new int[8];
            int[] c;
            c = new int[4];

            int[,] a;
            a = new int[8, 4];
            Random r = new Random();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = r.Next(-20,50);
                }
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0}   ", a[i,j]);
                }
                Console.WriteLine();
            }

            int max = a[0,0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                }
            }
            Console.WriteLine(max);

            for (int i = 0; i < b.Length; i++)
            {
                Console.Write("{0}, ", b[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < c.Length; i++)
            {
                Console.Write("{0}, ", c[i]);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
