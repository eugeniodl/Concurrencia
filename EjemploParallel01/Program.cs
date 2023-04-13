int acumulador = 0;

//for (int i = 0; i < 100; i++)
//{
//    EjecutarTarea(i);
//    Console.WriteLine($"Acumulador: {acumulador}. " +
//        $"Tarea ejecutada por el hilo {Thread.CurrentThread.ManagedThreadId}");
//}

Parallel.For(0, 100, (dato) =>
{
    Console.WriteLine($"Acumulador: {acumulador}. " +
        $"Tarea ejecutada por el hilo {Thread.CurrentThread.ManagedThreadId}");
    if ((acumulador % 2) == 0)
    {
        acumulador += dato;
        Thread.Sleep(100);
    }
    else
    {
        acumulador -= dato;
        Thread.Sleep(100);
    }
});

void EjecutarTarea(int dato)
{
    if((acumulador % 2) == 0)
    {
        acumulador += dato;
        Thread.Sleep(100);
    }
    else
    {
        acumulador -= dato;
        Thread.Sleep(100);
    }
}