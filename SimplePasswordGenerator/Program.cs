using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Length of the password 
            int length = 8;

            string passWord = generator(length);
            Console.WriteLine(passWord);
        }

        private static string generator(int length)
        {
            // All characters used when generating password
            const string chars = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder result = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }
            
            return result.ToString();
        }
    }
}
