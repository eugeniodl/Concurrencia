
using System.Diagnostics;

var sw = new Stopwatch();
sw.Start();
var numeros = Enumerable.Range(1, 10000);

var numerosPares = (from num in numeros
                    .AsParallel()
                    .AsOrdered()
                     where num % 2 == 0
                     select num).ToList();

foreach (var item in numerosPares)
{
    Console.WriteLine(item);
}
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);