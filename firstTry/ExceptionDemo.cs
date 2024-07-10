using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//exception is ay kind of errr that disturb the normal flow of program. if exception ccur then whole program is stopped to deal wiht such error exception handling mechanism is required it contains 4 keyword 
//1. try: use to surround a code that can cause error
//2. catch: use to handle a exception thrown from 
//3. throw : use to throw own exception
//4. finally: this block is always executed
//whether exception occur or not
namespace firstTry
{
     class ExceptionDemo
    {
        public void setData()
        {
            Console.WriteLine("enter first number");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int y = Int32.Parse(Console.ReadLine());
            try
            {
                int div = x / y;
                Console.WriteLine("div is " + div);
            }catch(DivideByZeroException d)
            {
                Console.WriteLine("cannot divide "+d);
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("always executed");
            }
            Console.WriteLine("out of try catch");
        }
    }
}
