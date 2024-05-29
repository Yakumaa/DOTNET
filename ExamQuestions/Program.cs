using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(1, "bruh");

            //adding purchased item to demonstrate the indexer
            //for(int i = 0; i<10; i++)
            //{
                //c[i] = "Item " + i;
            //}

            Console.WriteLine("The customer name is: " + c.Name + " And ID is: " + c.CustomerID);
            Console.WriteLine(c.Name + " has purchased " + c.Length + " items");
            for(int j = 0; j<c.Length; j++)
            {
                Console.WriteLine(c[j]);
            }
            Console.ReadLine();
        }
    }
}
