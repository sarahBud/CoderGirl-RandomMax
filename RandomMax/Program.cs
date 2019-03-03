using System;

namespace RandomMax
{
    public static class Program
    {
        public static void Main()
        {
            int[] numbers = new int[101];
            Random r = new Random();
            int max;
            

            for (int i = 0; i < 101; i++)
            {
                numbers[i] = r.Next(0, 1001);
                //Console.WriteLine(numbers[i]);
            }

            max = numbers[0];
            

            for (int i = 0; i < 101; i++)
            {
                if (max < numbers[i]) max = numbers[i];
                
                //if (max < i) max = i;
                
            }
            Console.WriteLine(max);

            //// TODO: Generate a list of 100 random integers between 0 and 1000 and ouput the maximum value.
            //for (int i = 0; i < 100; i++)
            //{
            //    Random r = new Random();
            //    Console.WriteLine(r.Next(1, 1000));
            //}
            

            Console.ReadLine();
        }
    }
}
