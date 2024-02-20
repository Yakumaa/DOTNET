using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static firstTry.lambdaExpresionDemo;

namespace firstTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation c1 = new Calculation();

            c1.calc();
            c1.calc(20, 30);
            c1.calc(20.5, 22.3);
            int mul = c1.calc(12, 23, 34);
            Console.WriteLine("multiplication is " + mul);
            //Console.ReadKey();

            Console.WriteLine("example of single level inheritance");
            Teacher t1 = new Teacher();
            //accessing parent property
            t1.setEmp(1, "ram", "ktm", "IT");
            t1.displayEmployee();

            //accessing own property
            t1.setTeacher("programming", "334343");
            t1.displayTeacher();

            //creating object of parent (EMployee)
            Employee e1 = new Employee();
            e1.setEmp(2, "hari", "PKR", "Management");
            e1.displayEmployee();
            //e1.setTeacher("finance", "234324"); //cannot access child

            Console.WriteLine("example of Multi level inheritance");

            //creating obect of electricbike
            ElectricBike eb = new ElectricBike();

            //using grandparent(twowheeler) property
            eb.Reg = 10;
            eb.Name = "ytri";
            eb.Brand = "tesla";

            //using parent property(bike)
            eb.Cc = "500";
            eb.FuelCapacity = "10";

            //suing own property
            eb.Range = "100";

            Console.WriteLine("reg is " + eb.Reg);
            Console.WriteLine("name is " + eb.Name);
            Console.WriteLine("brand is " + eb.Brand);
            Console.WriteLine("cc is " + eb.Cc);
            Console.WriteLine("fuel capacity is " + eb.FuelCapacity);
            Console.WriteLine("range is " + eb.Range);
            Console.WriteLine(" ");

            //creating object of bike
            Bike b1 = new Bike();

            //using parent property
            b1.Reg = 11;
            b1.Name = "Yamaha";
            b1.Brand = "Bajaj";

            //using own property
            b1.Cc = "200";
            b1.FuelCapacity = "11";

            Console.WriteLine("reg is " + b1.Reg);
            Console.WriteLine("name is " + b1.Name);
            Console.WriteLine("brand is " + b1.Brand);
            Console.WriteLine("cc is " + b1.Cc);
            Console.WriteLine("fuel capacity is " + b1.FuelCapacity); 

            //creating object of captain
            Console.WriteLine("CALLING SUPER CLASS CONSTRUCTOR");
            Captain cap1 = new Captain();
            Captain cap2 = new Captain("test", 1, "name", 301);

            cap1.displayCaptain();
            cap2.displayStudent();

            Console.ReadKey();

            //method overriding
            Console.WriteLine("EXAMPLE ON METHOD OVERRIDING");
            Solutions sol1 = new Solutions();
            sol1.calc1();
            sol1.calc2(30, 20);

            Console.WriteLine("--exception demo");
            ExceptionDemo ed = new ExceptionDemo();
            ed.setData();

            //Console.ReadKey();

            //custom exception
            Console.WriteLine("-- custom exception demo");
            CustomExceptionDemo cd = new CustomExceptionDemo();
            try
            {
                cd.setAge(19);
            }
            catch(AgeException a)
            {
                Console.WriteLine(a);
            }

            //Console.ReadKey();

            //Console.WriteLine("--file demo");
            //FileReadWriteDemo fd = new FileReadWriteDemo();
            //fd.writeFile();
            //fd.readFile();
            //Console.ReadKey();

            Console.WriteLine("--lambda demo");
            lambdaExpresionDemo l1 = new lambdaExpresionDemo();
            l1.setExpression();

            //creating list of objects  and arranging in ascending order by naem
            List<Employees> em = new List<Employees>()
            {
                new Employees {Id=1, Name="ram", Department="IT"},
                new Employees {Id=2, Name="sam", Department="Support"},
                new Employees {Id=3, Name="ham", Department="IT"},
            };

            var so1 = em.OrderBy(x => x.Name);
            foreach(var e in so1)
            {
                Console.WriteLine("id is " + e.Id + "name is " + e.Name);
            }
            Console.ReadKey();
        }
    }
}
