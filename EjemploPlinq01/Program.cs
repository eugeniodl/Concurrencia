using System.Diagnostics;

var reloj = new Stopwatch();
reloj.Restart();
var numeros = Enumerable.Range(1, 10000);

var numerosFiltrados = (from num in numeros
                        .AsParallel()
                        .AsOrdered()
                        where num % 2 == 0
                        select num).ToList();

foreach (var item in numerosFiltrados)
{
    Console.WriteLine(item);
}
Console.WriteLine(reloj.ElapsedMilliseconds);