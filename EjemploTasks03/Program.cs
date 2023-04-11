Task<int>[] tareas = new Task<int>[2];

tareas[0] = new Task<int>(() =>
{
    // hacer alguna cosa...
    return 34;
});

tareas[1] = new Task<int>(() =>
{
    // hacer alguna cosa...
    return 8;
});

var continuation = Task.Factory.ContinueWhenAll(tareas, (antecedents) =>
{
    int respuesta = tareas[0].Result + tareas[1].Result;
    Console.WriteLine("La respuesta es {0}", respuesta);
});

tareas[0].Start();
tareas[1].Start();
continuation.Wait();
Console.ReadKey();