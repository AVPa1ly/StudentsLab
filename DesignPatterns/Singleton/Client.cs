using System;

namespace DesignPatterns.Singleton
{
    class Client: IClient
    {
        public void ShowPattern()
        {
            Database adminConnection = Database.GetInstance("admin", "admin");

            string log, pass;
            adminConnection.GetCredentials(out log, out pass);
            Console.WriteLine("Login: {0}\nPassword: {1}", log, pass);
            adminConnection.Execute("INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode, Country)");

            Console.WriteLine();

            Database userConnection = Database.GetInstance("user", "user");
            userConnection.Execute("SELECT * FROM Customers");
            userConnection.Close();
        }
    }
}
