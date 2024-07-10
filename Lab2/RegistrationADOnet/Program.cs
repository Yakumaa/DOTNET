using System;

class Program
{
    static void Main(string[] args)
    {
        Registration.CreateTable();

        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Insert data");
            Console.WriteLine("2. Display all records");
            Console.WriteLine("3. Update record");
            Console.WriteLine("4. Delete record");
            Console.WriteLine("5. Display male records from Nepal");
            Console.WriteLine("6. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Registration.InsertData();
                    break;
                case 2:
                    Registration.DisplayAllRecords();
                    break;
                case 3:
                    Registration.UpdateRecord();
                    break;
                case 4:
                    Registration.DeleteRecord();
                    break;
                case 5:
                    Registration.DisplayMaleNepalRecords();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}