using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World";
            int columbus = 1492;
            bool dog = true;
            DateTime date = DateTime.Now;
            string dateWithFormat = date.ToLongDateString();
            decimal dec = 5.45m;
            char x = 'x';

            Console.WriteLine(helloWorld);
            Console.ReadLine();

            Console.WriteLine("Columbus sailed the world in " + columbus);
            Console.ReadLine();

            Console.WriteLine("It is {0} that I have dogs at home.", dog);
            Console.ReadLine();

            Console.WriteLine("Today is " + dateWithFormat);
            Console.ReadLine();

            Console.WriteLine("I spent " + dec + " on a cheeseburger.");
            Console.ReadLine();

            Console.WriteLine(x + " marks the spot");
            Console.ReadLine();

            Console.WriteLine("Please enter a number of your choosing.");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            Console.ReadLine();

            Console.WriteLine("Please enter another number of your choosing.");
            string num2 = Console.ReadLine();
            int ans = 0;
            bool num2ent = int.TryParse(num2, out ans);
            if (num2ent)
            {
                Console.WriteLine($"Your number is " + num2);
            }
            else
            {
                Console.WriteLine("Sorry, I said put in a number.");
                Console.ReadLine();
            }
            Console.ReadLine();
         
   
        }
    }
}
