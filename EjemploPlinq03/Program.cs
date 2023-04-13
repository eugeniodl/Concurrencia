string[] nombres = { "Alexandra", "Franshesco", "Odvin", "Ana", "Jared", "Manuel", "Jhon", "Hector"};

try
{
    var filtro = nombres.Where(a => a[0] == 'A');
    var par = nombres.AsParallel().Where(a => a[0] == 'J');
    Imprime(filtro);
    Imprime(par);
}
catch (AggregateException e)
{
    foreach(var t in e.InnerExceptions)
        Console.WriteLine(t.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Imprime(IEnumerable<string> filtro)
{
    Console.WriteLine("------------------");
    foreach(var item in filtro)
        Console.WriteLine(item);
}
