using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTry
{
    class FileReadWriteDemo
    {
        public void writeFile()
        {
            //to create a file for writing StreamWriter is used
            StreamWriter sw = new StreamWriter("C://Users//Shrijala Maharjan//Desktop//New folder//.NET//firstTry");
            Console.WriteLine("enter text to insert");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Flush(); //
            sw.Close();

        }
        public void readFile()
        {
            StreamReader sr = new StreamReader("C://Users//Shrijala Maharjan//Desktop//New folder//.NET//firstTry");
            string data1 = sr.ReadLine();
            while (data1 != null) { 
                Console.WriteLine(data1 + "\n");
            }
            sr.Close();
        }
    }
}
