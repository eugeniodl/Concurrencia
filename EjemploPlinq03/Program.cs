string[] nombres = { "Frederick", "Dylan", "Ervin", "Nelio", "Ernesto", "Paola", "Cinthia", "Erick" };

try
{
    var filtro = nombres.Where(a => a[0] == 'E');
    var par = nombres.AsParallel().Where(a => a[0] == 'E');
    Imprime(filtro);
    Imprime(par);
}
catch (AggregateException e)
{
    foreach(var ex in e.InnerExceptions)
        Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Imprime(IEnumerable<string> filtro)
{
    Console.WriteLine("-----------------");
    foreach(var item in filtro)
    {
        Console.WriteLine(item);
    }
}
