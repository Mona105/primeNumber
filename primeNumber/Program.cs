using System;
namespace Prime
{
    class Program
    {
        static void Main(String[] args)
        {
            int n, i, j;
            n = int.Parse(Console.ReadLine());
            for (i = 2; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    int m = i % j;

                    Console.WriteLine(m);


                }

            }
        }
    }
}
}