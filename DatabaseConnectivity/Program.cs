using System;
using System.Data.SqlClient;

//to connect with external data source system.data.sqlclient package is needed.
//to connect with sql serve SqlConnection class is used 
//to execute the query SqlCommand class is used
//step to perform database operation
//1. import package system,data.sqlclient
//2. create connection string that contain all the necessary parameter like server nae , database name, user name, password etc.
//3. create objects of sqlconnection cass t connect with server
//4. open the connection using open() method
//5. write proper sql query and handle sql exception
//6. execute the query using SQLcommand class
//7. close the connection using close() method

namespace DatabaseConnectivity
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Crud c = new Crud();
            //c.CreateTable();
            c.InsertData();
            //c.updateData();
            //c.deleteData();
            c.fetchData();
            Console.ReadKey();

        }
    }
}
