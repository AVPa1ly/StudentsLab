using System.Threading;

namespace DesignPatterns.Singleton
{
    public class Client: IClient
    {
        public void ShowPattern()
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(ThreadFunc));
            Thread t2 = new Thread(new ParameterizedThreadStart(ThreadFunc));

            t1.Start("SELECT THREAD1 FROM Customers");
            t2.Start("SELECT THREAD2 FROM Customers");
            Thread.Sleep(50);
        }

        public void ThreadFunc(object querry)
        {
            Database connection = Database.GetInstance();
            connection.Execute((string)querry);
        }
    }
}
