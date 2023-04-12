﻿Task t = Task.Run(() =>
{
    //Thread.Sleep(5000);
    Task.Delay(5000);
    Console.WriteLine("Ejecutando task");
});
await t;

//double resultado = LeerDataDesdeBD();
double resultado = await LeerDataDesdeBDAsync();
Console.WriteLine(resultado);

async Task<double> LeerDataDesdeBDAsync()
{
    var t = new Task<double>(() => HacerCalculosIntensivos());
    t.Start();
    double resultado = await t;
    return resultado;
}


double LeerDataDesdeBD()
{
    Thread.Sleep(5000);
    double tarea = HacerCalculosIntensivos();
    return tarea;
}

double HacerCalculosIntensivos()
{
    double resultado = 1000000d;
    var valorMax = int.MaxValue;

    for (int i = 0; i < valorMax; i++)
    {
        resultado /= i;
    }

    return resultado;
}