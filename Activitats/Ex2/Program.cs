using System;
using System.Diagnostics;
using System.IO;

public class Program
{
    public static void Main()
    {
        var processos = Process.GetProcesses();
        using StreamWriter writer = new StreamWriter("processos.txt");
        foreach (var proc in processos)
        {
            writer.WriteLine($"Nom: {proc.ProcessName}, PID: {proc.Id}");
            Console.WriteLine($"Nom: {proc.ProcessName}, PID: {proc.Id}");
        }
    }
}
