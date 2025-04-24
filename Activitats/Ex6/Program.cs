using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main()
    {
        int numCamells = 5;
        Thread[] fils = new Thread[numCamells];

        for (int i = 0; i < numCamells; i++)
        {
            int id = i + 1;
            Camel c = new Camel(id);
            fils[i] = new Thread(new ThreadStart(c.Correr));
            fils[i].Start();
        }

        foreach (var t in fils)
        {
            t.Join();
        }

        Camel.MostrarClassificacioFinal();
    }
}
