using System.Diagnostics;

public class Ejemplo08
{
    public static void Main()
    {
        var th = new Thread(ExecuteInForeground);
        th.Start(4500);
        Thread.Sleep(1000);
        Console.WriteLine("Subproceso principal ({0}) saliendo...",
            Thread.CurrentThread.ManagedThreadId);
    }

    private static void ExecuteInForeground(object? obj)
    {
        int interval;
        try
        {
            interval = (int)obj;
        }
        catch (InvalidCastException)
        {
            interval = 5000;
        }
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
        } while (sw.ElapsedMilliseconds <= interval);
        sw.Stop();
    }
}