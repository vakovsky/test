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

            //Read Array
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = r.Next(-20,50);
                }
            }

            //Write Array
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0}   ", a[i,j]);
                }
                Console.WriteLine();
            }

            //Max value
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
            
            //Write b
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write("{0}, ", b[i]);
            }
            Console.WriteLine();

            //Write c
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write("{0}, ", c[i]);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
