using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTry
{
    class Student
    {
        public int id;
        public string name;
        public int faculty;

        public Student() {
            Console.WriteLine("default constructor of student");
        }

        public Student(int id, string name, int faculty)
        {
            this.id = id;
            this.name = name;
            this.faculty = faculty;
        }

        public void displayStudent() {
            Console.WriteLine("id is " + id);
            Console.WriteLine("name is " + name);
            Console.WriteLine("faculty is "+  faculty);
        }
    }

    class Captain : Student
    {
        public string res;
        public Captain():base()
        {
            Console.WriteLine("default constructor of captain");
        }

        public Captain(string res, int id, string name, int faculty):base(id, name, faculty)
        {
            this.res = res;
        }

        public void displayCaptain() {
            Console.WriteLine("res is " + res);
        }
    }
}
