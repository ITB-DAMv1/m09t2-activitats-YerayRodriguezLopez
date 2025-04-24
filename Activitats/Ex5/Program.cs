using System;
using System.Threading;

public class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            int num = i;
            Thread t = new Thread(() => {
                Console.WriteLine($"Hola! Soc el fil número {num}");
            });
            t.Start();
        }
        for (int i = 5; i >= 1; i--)
        {
            int num = i;
            Thread t = new Thread(() => {
                Thread.Sleep((6 - num) * 100);
                Console.WriteLine($"Hola! Soc el fil número {num}");
            });
            t.Start();
        }
    }
}
