using System;

namespace SimpleIdGenerator
{
    class Program
    {
        static void Main(string[] args)
        {            
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(string.Format("{0}\t{1}", i, GeneratorId(10)));
            }

            Console.ReadLine();
        }


        static string GeneratorId(int length)
        {
            var result = string.Empty;
            var myRandom = new Random();

            var lookupstring = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+-";

            for (int i = 0; i < length; i++)
            {                
                result += lookupstring[myRandom.Next(0, 63)];
            }

            return result;
        }
    }
}
