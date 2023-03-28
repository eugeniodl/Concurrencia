public class EjemploHilos06
{
    // La prioridad del hilo determina cuánto tiempo de
    // ejecución va a recibir con relación a los otros hilos
    // Sólo es importante cuando tenemos múltiples hilos
    // activos. Puede tener los valores:
    // Lowest, BelowNormal, Normal, AboveNormal, Highest

    private static bool ejecutar1 = true;
    private static int conteo1 = 0;

    private static bool ejecutar2 = true;
    private static int conteo2 = 0;

    public static void Main()
    {
        Thread th1 = new Thread(Incremento1);
        th1.Priority = ThreadPriority.Lowest;
        th1.Start();

        Thread th2 = new Thread(Incremento2);
        th2.Priority = ThreadPriority.Highest;
        th2.Start();
    }

    private static void Incremento1(object? obj)
    {
        while(ejecutar1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            conteo1++;
            Console.WriteLine(" L- {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(" -> {0}", conteo1);

            if(conteo1 > 1000)
            {
                ejecutar1 = false;
                ejecutar2 = false;
            }
        }
    }

    private static void Incremento2(object? obj)
    {
        while (ejecutar2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            conteo2++;
            Console.WriteLine(" H- {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(" -> {0}", conteo2);

            if (conteo2 > 1000)
            {
                ejecutar1 = false;
                ejecutar2 = false;
            }
        }
    }
}