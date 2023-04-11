// La tarea anterior. También se puede crear con Task.Factory.StartNew
Task<DayOfWeek> taskA = new Task<DayOfWeek>(() => DateTime.Today.DayOfWeek);

// La continuación. El delegado toma la tarea anterior
// como argumento y puede devolver un tipo diferente
Task<string> continuation = taskA.ContinueWith((antecedent) =>
{
    return String.Format("Hoy es {0}.", antecedent.Result);
});

// Iniciar la tarea anterior
taskA.Start();

// Utilice el resultado de la continuación
Console.WriteLine(continuation.Result);
Console.ReadKey();