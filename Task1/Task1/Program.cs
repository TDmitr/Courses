using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            int num = int.Parse(user);
            for (int i = 1; i < num+1; i++)
            {
                if (num%i == 0)
                {
                    Console.WriteLine(i.ToString());
                }
                
            }
            Console.ReadLine();
        }
    }
}
