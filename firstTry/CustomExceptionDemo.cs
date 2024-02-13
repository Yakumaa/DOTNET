using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//to create own kind of exceptiion:
//1. create a error class by inheriting superclass Exception and call the constructor with error message
//2. use throw keyword to throw particulat exception
namespace firstTry
{
    class AgeException: Exception
    {
        public AgeException(string msg): base(msg)
        {

        }
    }
    class CustomExceptionDemo
    {
        public void setAge(int age)
        {
            if(age < 16)
            {
                throw new AgeException("Age should be greater than 16");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
