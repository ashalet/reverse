using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str_2 = new string (str.ToCharArray().Reverse().ToArray());
            Console.WriteLine(str_2);
            Console.ReadLine();
        }
    }
}
