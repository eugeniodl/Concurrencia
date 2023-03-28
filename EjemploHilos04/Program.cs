// Foreground threads son hilos que siguen existiendo, aun si
// la aplicación termina de ejecutar el Main
// Pueden evitar que la aplicación termine

// Background threads son hilos que se finalizan si la aplicación
// termina al ejecutar el Main
public class EjemploHilos04
{
    private static bool ejecutar = true;

    public static void Main()
    {
        int m = 0;
        // De esta forma creamos un hilo que es
        // background thread
        Thread miHilo = new Thread(new ThreadStart(Mensaje));
        miHilo.IsBackground = true;
        miHilo.Start();

        while(ejecutar)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Mensaje desde el hilo principal {0}", m);
            m++;

            if(m == 25)
                ejecutar = false;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Salimos de Main");
    }

    private static void Mensaje()
    {
        int n = 0;
        bool ejecutarMensaje = true;

        while(ejecutarMensaje)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Mensaje desde el hilo {0}", n);
            n++;

            if(n > 2500)
                ejecutarMensaje = false;
        }
    }
}