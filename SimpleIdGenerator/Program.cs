using System;

namespace SimpleIdGenerator
{
    class Program
    {
        static void Main(string[] args)        
        {            
            // Generate a 100 ids
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(string.Format("{0}.\t{1}", i, GeneratorId(10)));
            }

            Console.ReadLine();
        }


        /// <summary>
        /// Generates a mostly unique id
        /// </summary>
        /// <param name="length">Wanted length of id</param>
        /// <returns></returns>
        static string GeneratorId(int length)
        {
            var result = string.Empty;
            var myRandom = new Random();

            // Our simple base64 encoding lookup table
            var lookupstring = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+-";

            // loop for generating each of our characters until we reach the wanted length
            for (int i = 0; i < length; i++)
            {                
                // Get a random number between 0 and 63 and use it as a lookup index in our lookup string
                result += lookupstring[myRandom.Next(0, 63)];
            }

            return result;
        }
    }
}
