using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//inheritance is a process of acquiring properties of one class by another class. it is used to resuse code and to reduce code redundancy
//its types are:
//single level: if one or more child class inherits one parent
//multilevel: if first class gets inherited by second and second class interns gets inherited third and so on. It is like grandparent , parent  and child relation
//Multiple: If one child class can inherit more than one parent then such condition is multipe inheritance 
//those class tha inherits other class is sub class, derive
//thse class that gets inherited by ither class is super class

namespace firstTry
{
    class Employee
    {
        private int eid;
        private string name;
        private string address;
        private string department;

        //method to set initialize instamce variable
        public void setEmp(int eid, string name, string address, string department)
        {
            this.eid = eid;
            this.name = name;
            this.address = address;
            this.department = department;

        }
        public void displayEmployee()
        {
            Console.WriteLine("id is " + this.eid);
            Console.WriteLine("name is " + this.name);
            Console.WriteLine("address is " + this.address);
            Console.WriteLine("department is " + this.department);
        }
    }

    //creating hcild class that will inherit Employee class
    class Teacher : Employee        //teacher is child
    {
        private string specialization;
        private string salary;
        public void setTeacher(string specialization, string salary)
        {
            this.specialization = specialization;
            this.salary = salary;
        }
        public void displayTeacher()
        {
            Console.WriteLine("specialization is " + this.specialization);
            Console.WriteLine("salary is " + this.salary);

        }
    }

}

    
