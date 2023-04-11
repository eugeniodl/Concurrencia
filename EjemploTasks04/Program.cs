

int acumulador = 0;
CancellationTokenSource miToken = new CancellationTokenSource();
CancellationToken cancelaToken = miToken.Token;

Task t = Task.Run(() => MetodoTask(cancelaToken));
for (int i = 0; i < 100; i++)
{
    acumulador += 30;
    Thread.Sleep(1000);
    if(acumulador > 100)
    {
        miToken.Cancel();
        break;
    }
}
Thread.Sleep(1000);
Console.WriteLine("Valor del acumulador " + acumulador);
Console.ReadLine();

void MetodoTask(CancellationToken cancelaToken)
{
    for (int i = 0; i < 10; i++)
    {
        acumulador++;
        var miThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(1000);
        Console.WriteLine("Ejecutando tarea el thread: " + miThread);
        Console.WriteLine(acumulador);
        if(cancelaToken.IsCancellationRequested)
        {
            acumulador = 0;
            return;
        }
    }
}