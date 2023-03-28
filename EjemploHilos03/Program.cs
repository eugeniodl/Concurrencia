// Mostramos cómo ejecutar múltiples hilos
public class EjemploHilos03
{
    private static bool ejecutar = true;
    private static int n;

    public static void Main()
    {
        int m = 0;

        // Aquí estamos creando múltiples hilos
        for(int i = 0; i < 8; i++)
        {
            Thread th = new Thread(Mensaje);
            th.Start(i);
        }

        while(ejecutar)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Mensaje desde el Main {0}", m);
            m++;

            if(m == 250)
                ejecutar = false;
        }
    }

    private static void Mensaje(object? obj)
    {
        while(ejecutar)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mensaje desde el hilo {0} - {1}", obj, n);
            n++;
        }
    }
}