using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Reverse_Number
    {
        public void reverse()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int result = 0;
            int rem = 0;
            while (num > 0)
            {
                rem = (num % 10);
                num = num / 10;
                result = result * 10 + rem;
            }
            if (result == temp)
                Console.WriteLine("Reverse number" + temp);
            else
                Console.WriteLine("Not reverse" + temp);
        }
       // public static void main(string[] args) { Reverse_Number reverse_number = new Reverse_Number(); reverse_number.reverse(); }  
    }
}
