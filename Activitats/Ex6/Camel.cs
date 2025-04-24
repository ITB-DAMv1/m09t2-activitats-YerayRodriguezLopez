using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Camel
{
    int id;
    static object _lock = new object();
    static List<int> classificacio = new List<int>();
    static Random rnd = new Random();

    public Camel(int id)
    {
        this.id = id;
    }

    public void Correr()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine($"Camell {id} -> {i}");
            Thread.Sleep(rnd.Next(50, 150));
        }

        lock (_lock)
        {
            classificacio.Add(id);
        }

        Console.WriteLine($"Camell {id} ha arribat a la meta!");
    }

    public static void MostrarClassificacioFinal()
    {
        Console.WriteLine("\nClassificació final:");
        for (int i = 0; i < classificacio.Count; i++)
        {
            Console.WriteLine($"{i + 1}º lloc: Camell {classificacio[i]}");
        }
    }
}

