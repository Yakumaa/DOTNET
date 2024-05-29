using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamQuestions
{
    class Customer
    {
        private string name;

        //properties
        public int CustomerID { get; set; }
        //this will encapsulate the private field name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Indexers
        private string[] purchasedItem = new string[10];
        public string this[int i]
        {
            get { return purchasedItem[i]; }
            set { purchasedItem[i] = value; }
        }

        public int Length { 
            get { return purchasedItem.Length; }
        }

        //Constructor
        public Customer(int ID, string name)
        {
            Name = name;
            CustomerID = ID;
        }
    }
}
