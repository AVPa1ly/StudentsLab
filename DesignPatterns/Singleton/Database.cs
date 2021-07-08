using System;

namespace DesignPatterns.Singleton
{
    class Database
    {
        private static Database database;
        private static string Login { get; set; }
        private static string Password { get; set; }

        private Database(string login, string password) 
        {
            Login = login;
            Password = password;
            Console.WriteLine("Database instance created.");
        }

        public static Database GetInstance(string login = null, string password = null)
        {
            if (database != null && (login != Login || password != Password))
            {
                database.Close();
            }

            if (database == null)
            {
                database = new Database(login, password);
            }

            Console.WriteLine("Database instance extracted.");
            return database;
        }

        public void Execute(string querry)
        {
            Console.WriteLine("\"{0}\" executed.", querry);
        }

        public void GetCredentials(out string login, out string password)
        {
            login = Login;
            password = Password;
        }

        public void Close()
        {
            Console.WriteLine("Connection closed");
            database = null;
            Login = Password = null;
        }
    }
}
