using System;

//method overriding :id superclass and sub class have same method(same name, same return type and same parameter) to all overridden
//method of superclass from subclass base keyword is used
// for mehtod overriding two keywords are used: virtual->represent overridden method in superclass, override-> represent overriden method in sub class
namespace firstTry
{
    class Calculations
    {
        public virtual void  calc1()
        {
            Console.WriteLine("Default method of calc");
        }
        public virtual void calc2(int x, int y) 
        {
            Console.WriteLine("sum is " + (x + y));
        }
    }
    class Solutions : Calculations
    {
        public override void calc1()
        {
            base.calc1();
            Console.WriteLine("Default method of solutions");
        }
        public override void calc2(int x, int y)
        {
            base.calc2(x, y);
            Console.WriteLine("difference is " + (x - y));
        }
    }
}
