using System.Diagnostics;

public class EjemploHilos07
{
    public static void Main()
    {
        var th = new Thread(ExecuteInForeground);
        th.Start();
        Thread.Sleep(1000);
        Console.WriteLine("Subproceso principal ({0}) saliendo... ",
            Thread.CurrentThread.ManagedThreadId);
    }

    private static void ExecuteInForeground(object? obj)
    {
        var sw = Stopwatch.StartNew();
        Console.WriteLine("Hilo {0}: {1}, Prioridad {2}",
            Thread.CurrentThread.ManagedThreadId,
            Thread.CurrentThread.ThreadState,
            Thread.CurrentThread.Priority);
        do
        {
            Console.WriteLine("Subproceso {0}: transcurrieron {1:N2} segundos",
                Thread.CurrentThread.ManagedThreadId,
                sw.ElapsedMilliseconds / 1000.0);
            Thread.Sleep(500);
        } while (sw.ElapsedMilliseconds <= 5000);
        sw.Stop();
    }
}