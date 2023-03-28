public class EjemploHilos02
{
    public static void Main()
    {
        // Instanciamos el objeto thread / hilo y
        // colocamos el delegado que corresponde
        Thread hilo1 = new Thread(Mensaje);
        hilo1.Start();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Mensaje desde Main");

        // Forma de pasar datos al hilo
        Thread hilo2 = new Thread(MensajeConParametro);
        // Al iniciar el hilo mandamos el mensaje
        hilo2.Start(7);
    }
    // Este método se ejecuta en el segundo hilo
    // y recibe un parámetro del exterior
    private static void MensajeConParametro(object? obj)
    {
        int p = Convert.ToInt32(obj);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Mensaje con parámetro {0}, {1}", p, p * 5);
    }

    // Creamos el método que se ejecutará en el segundo hilo
    // Debe coincidir con el delegado
    private static void Mensaje(object? obj)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Mensaje desde el hilo");
    }
}