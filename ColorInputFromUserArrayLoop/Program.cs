using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorInputFromUserArrayLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] color = new string[3];

            //Input color from User

            for (int i = 0; i < color.Length; i++)
            {
                Console.Write($"Type Your Favorite Color {i + 1} is :");

                color[i] = Console.ReadLine();
            }

            //Output User color. 

            for (int i = 0; i < color.Length; i++)
            {

                Console.WriteLine($"Your favorite color is:{color[i]} ");

            }


            Console.ReadKey();
        }
    }
}
