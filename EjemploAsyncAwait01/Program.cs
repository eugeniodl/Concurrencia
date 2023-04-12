Task tarea = Task.Run(() =>
{
    Thread.Sleep(5000);
    Console.WriteLine("Ejecutando una task");
});

double resultado = LeerDataDesdeBD();
Console.WriteLine(resultado);
Console.WriteLine("Ha terminado la tarea");
Console.ReadLine();

double LeerDataDesdeBD()
{
    double resultado = HacerCalculosIntensivos();
    return resultado;
}

double HacerCalculosIntensivos()
{
    double resultado = 1000000000000000000000d;
    var valorMax = int.MaxValue;

    for(int i = 0; i < valorMax; i++)
    {
        resultado /= i;
    }

    return resultado;
}