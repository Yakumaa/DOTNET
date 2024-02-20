using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

//lambda expression is like a nonymouse function except that i doesnt have data type. it uses => symbol which has two part left side of
//symbol is expression or statement 
//symbol=>expression or statement

namespace firstTry
{
    class lambdaExpresionDemo
    {
        public void setExpression()
        {
            List<int> num1 = new List<int>() { 30, 40, 50, 60, 12 };

            //using lambda expression find out whether the number is even or not
            var result = num1.Select(x => (x % 2) == 0);
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
            List<int> l2 = num1.FindAll(x => (x % 2) == 0);
            foreach (var res1 in l2)
            {
                Console.WriteLine(res1);
            }
        }

        //lambda expression in class
        public class Employees
        {
            private int id;
            private string name;
            private string department;

            public int Id { get { return id; } set { id = value; } }

            public string Name { get { return name; } set { name = value; } }

            public string Department { get { return department; } set { department = value; } }
        }
    }
}
