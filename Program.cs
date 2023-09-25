
namespace Multithreads
{
    class Program
    {
        static void Main(string [] args){

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Naa thread";
            System.Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(() => CountUp("Timer1"));
            Thread thread2 = new Thread(() => CountDown("Timer2"));

            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " is complete!");



            Console.Read();
        }

        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer1 is complete!");

        }

        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer2 is complete!");
        }

    }
}

