using System;
using System.Threading;
using System.Threading.Tasks;

namespace JustTheApp
{
    public class Laba1
    {
        public void Run()
        {
            Task task1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("task 1 start ");
                Thread.Sleep(200 * Task.CurrentId.Value);
                Console.WriteLine("task 1 finish with id {0}", Task.CurrentId.Value);
            });

            Task task2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("task 2 start ");
                Thread.Sleep(200 * Task.CurrentId.Value);
                Console.WriteLine("task 2 finish with id {0}", Task.CurrentId.Value);
            });

            Task task1Another = Task.Factory.StartNew(TaskTest);
            Task task2Another = Task.Factory.StartNew(TaskTest);


            Task task4 = new Task(TaskTest);

            Task.WaitAll(task1, task2, task1Another, task2Another);

            task4.Start();
            task4.Wait();
            task4.Dispose();

            Task task3 = Task.Factory.StartNew(() => Console.WriteLine("one line task"));

            Parallel.Invoke(
                () => Console.WriteLine("task1 invoke "),
                () => Console.WriteLine("task2 invoke "),
                () => Console.WriteLine("task3 invoke ")
            );
        }

        static void TaskTest()
        {
            int t = Task.CurrentId.Value;
            Console.WriteLine("started task with Id {0} ", t);
            Thread.Sleep(200 * Task.CurrentId.Value);
            Console.WriteLine("finished task with Id {0} ", t);
        }
    }
}
