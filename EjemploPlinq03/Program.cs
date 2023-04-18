string[] nombres = { "Jafet", "Axel", "Antony", "Alex", "Allan", "Davis", "Jean"};

try
{
    var filtro = nombres.Where(a => a[0] == 'A');
    var par = nombres.AsParallel().Where(a => a[0] == 'A');
    Imprime(filtro);
    Imprime(par);
}
catch (AggregateException e)
{
    foreach (var ex in e.InnerExceptions)
    {
        Console.WriteLine(ex.Message);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


void Imprime(IEnumerable<string> collection)
{
    Console.WriteLine("----------------");
    foreach (var item in collection)
    {
        Console.WriteLine(item);
    }
}

