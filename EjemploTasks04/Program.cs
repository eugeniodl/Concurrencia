int acumulador = 0;

CancellationTokenSource miToken = new CancellationTokenSource();
CancellationToken cancelaToken = miToken.Token;

Task tarea = Task.Run(() => MetodoTask(cancelaToken));
for (int i = 0; i < 100; i++)
{
    acumulador += 30;
}


void MetodoTask(CancellationToken token)
{
    for (int i = 0; i < 10; i++)
    {
        acumulador++;
        var miThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(1000);
        Console.WriteLine("Ejecutando tarea el thread: " + miThread);
    }
}