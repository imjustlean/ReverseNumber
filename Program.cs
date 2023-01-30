using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number="", numbers="";
            Console.WriteLine("Enter number: ");
            number = Console.ReadLine();
            int z = number.Length-1;

            for(int i =z; i>=0; i--)
            {
                numbers = numbers + number[i];
            }
            Console.WriteLine("Output : {0}", numbers);
            Console.Write("\n");
            Console.ReadLine();
           
        }
    }
}
