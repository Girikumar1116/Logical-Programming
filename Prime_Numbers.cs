using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Prime_Numbers
    {
        public  void numbers()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int i = 2; i <= (num / 2); i++)
            {
                if (num % i == 0)
                    flag = true;
                break;
            }
            if (flag == true)
                Console.WriteLine(num + "not a prime number");
            else
                Console.WriteLine(num + "is a prime number");
        }
        //static void main(string[] args) { Prime_Numbers prime = new Prime_Numbers();prime.numbers(); }
    }
}
