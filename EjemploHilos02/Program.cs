public class EjemploHilos02
{

    public static void Main()
    {
        // Instanciamos el objeto thread / hilo y
        // colocamos el delegado que corresponde
        Thread miHilo = new Thread(Mensaje);
        miHilo.Start();

        Thread miHilo2 = new Thread(MensajeConParametro);
        miHilo2.Start(5);

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Mensaje desde Main");
    }

    // Creamos el método que se ejecutará en el segundo hilo
    // Debe coincidir con el delegado
    private static void Mensaje(object? obj)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Mensaje desde el segundo hilo");
    }

    // Este método se ejecuta en el segundo hilo
    // y recibe un parámetro del exterior
    private static void MensajeConParametro(object? obj)
    {
        int p = Convert.ToInt32(obj);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Mensaje con parámetro {0} {1}", p, p * 2);
    }
}