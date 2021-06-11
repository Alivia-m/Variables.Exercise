using System;

namespace Variable.Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int catAge;
            string catName;
            bool isYellow;

            catAge = 5;
            catName = "lion";
            isYellow = true;

            Console.WriteLine($"The cats name is {catName}, he is {catAge} years old. Is he yellow? {isYellow}");

            decimal a;
            double b;
            char c;

            a = 7.9m;
            b = +10.5;
            c = '*';
            Console.WriteLine(7.9 * +10.5);
           
            
           
        }
    }
}
