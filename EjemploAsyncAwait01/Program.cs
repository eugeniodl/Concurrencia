Task t = Task.Run(() =>
{
    Thread.Sleep(5000);
    Console.WriteLine("Ejecutando task");
});

double resultado = LeerDataDesdeBD();

Console.WriteLine(resultado);

double LeerDataDesdeBD()
{
    Thread.Sleep(5000);
    double resultado = HacerCalculosIntensivos();
    return resultado;
}

double HacerCalculosIntensivos()
{
    double resultado = 100000000;
    var valorMax = int.MaxValue;

    for (int i = 0; i < valorMax; i++)
    {
        resultado /= i;
    }
    return resultado;
}