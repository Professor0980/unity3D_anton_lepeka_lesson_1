using System;
using System.Globalization;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 16;
            /*Console.WriteLine($"{x} {y}");
            Console.WriteLine(x + " " + y);
            Console.WriteLine("{x} ");
            Console.WriteLine(y + x);

            /*
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            float[] arr2;
            arr2 = new float[10];
            for (int i = 0; i < 10; i++)
                arr2[i] = i;

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(arr2[j]);
                j++;
            }
            */
            x = 2;
            //int[] arr = new int[] { 2, 48, 6, 32, 64 };
            double[] arr2;
            arr2 = new double[6];
            for (int i = 0; i < 6; i++)
            {
                arr2[i] = Math.Pow(2,1+i);

                Console.WriteLine(arr2[i]);
               
            }
        }
    }
}
