Task t = Task.Run(() =>
{
    //Thread.Sleep(5000);
    Console.WriteLine("Ejecutando task");
});
await t;

//double resultado = LeerDataBD();
double resultado = await LeerDataBDAsync();
Console.WriteLine(resultado);
Console.WriteLine("Se ha completado la tarea");
Console.ReadLine();

async Task<double> LeerDataBDAsync()
{
    //Thread.Sleep(5000);
    var t = new Task<double>(() => HacerCalculosIntensivos());
    t.Start();
    double resultado = await t;
    return resultado;
}

double LeerDataBD()
{
    Thread.Sleep(5000);
    double resultado = HacerCalculosIntensivos();
    return resultado;
}

double HacerCalculosIntensivos()
{
    double resultado = 1000000000000d;
    var valorMax = int.MaxValue;

    for (int i = 0; i < valorMax; i++)
    {
        resultado /= i;
    }
    return resultado;
}