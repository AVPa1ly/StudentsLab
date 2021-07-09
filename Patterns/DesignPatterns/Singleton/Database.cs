using System;

namespace DesignPatterns.Singleton
{
    public class Database
    {
        private static Database database;
        private static readonly object locker = new object();

        private Database() 
        {
            Console.WriteLine("Database instance created.");
        }

        public static Database GetInstance()
        {
            if (database == null)
            {
                lock (locker)
                {
                    if (database == null)
                    {
                        database = new Database();
                    }
                }

            }

            Console.WriteLine("Database instance extracted.");
            return database;
        }

        public void Execute(string querry)
        {
            Console.WriteLine("\"{0}\" executed.", querry);
        }
    }
}
