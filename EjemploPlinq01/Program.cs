using System.Diagnostics;

var numeros = Enumerable.Range(1, 10000);
var sw = new Stopwatch();
sw.Start();

var numerosFiltrados = (from num in numeros
                        .AsParallel()
                        .AsOrdered()
                        where num % 2 == 0
                        select num).ToList();

Console.WriteLine("{0} even numbers out of {1} total",
                  numerosFiltrados.Count(), numeros.Count());

sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);