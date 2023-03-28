public class EjemploHilos05
{
    private static int conteo = 0;
    private static bool ejecutar = true;

    // Usamos este objeto para crear el lock
    private static object control = new object();
    private static int id1 = 0;
    private static int id2 = 0;

    public static void Main()
    {
        Thread hilo1 = new Thread(Incremento);
        hilo1.Start();

        // Obtenemos el ID del hilo
        id1 = hilo1.ManagedThreadId;

        Thread hilo2 = new Thread(Incremento);
        hilo2.Start();
        id2 = hilo2.ManagedThreadId;

        while(ejecutar)
        {
            if(conteo > 100)
                ejecutar = false;
        }
    }

    private static void Incremento(object? obj)
    {
        while(ejecutar)
        {
            // Aquí creamos una sección crítica
            // lock asegura que solo un hilo puede estar en la sección crítica a la vez
            lock(control)
            {
                if(Thread.CurrentThread.ManagedThreadId == id1)
                    Console.ForegroundColor = ConsoleColor.White;
                if(Thread.CurrentThread.ManagedThreadId == id2)
                    Console.ForegroundColor = ConsoleColor.Green;

                conteo++;
                Console.WriteLine("---");
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine(" -> {0}", conteo);

                // Suspendemos el hilo 1000 milisengundos
                Thread.Sleep(1000);
            }
        }
    }
}