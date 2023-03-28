// Mostramos cómo ejecutar múltiples hilos
public class EjemploHilos03
{
    private static bool ejecutar = true;

    public static void Main()
    {
        int conteo = 0;

        // Aquí estamos creando múltiples hilos
        for (int i = 0; i < 8; i++)
        {
            Thread th = new Thread(Mensaje);
            th.Start(i);
        }

        while(ejecutar)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Mensaje desde el Main {0}", conteo);
            conteo++;

            if(conteo == 2500)
                ejecutar = false;
        }
    }

    private static void Mensaje(object? obj)
    {
        int conteo = 0;
        while(ejecutar)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Mensaje desde el hilo {0} - {1}", obj, conteo);
            conteo++;
        }

    }
}