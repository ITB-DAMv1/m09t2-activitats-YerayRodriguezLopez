using System;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        Console.Write("Introdueix el nom del navegador (ex: chrome): ");
        string nom = Console.ReadLine();
        var processos = Process.GetProcessesByName(nom);

        if (processos.Length == 0)
        {
            Console.WriteLine("No s'ha trobat el navegador.");
            return;
        }

        foreach (var fil in processos[0].Threads.Cast<ProcessThread>())
        {
            Console.WriteLine($"ID: {fil.Id}, Inici: {fil.StartTime}, Prioritat: {fil.PriorityLevel}");
        }
    }
}
