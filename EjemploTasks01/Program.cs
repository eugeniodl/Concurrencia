var t = Task.Factory.StartNew(() => MetodoTask());

// Utilizando TaskFactory
TaskFactory tf = new TaskFactory();
Task t1 = tf.StartNew(MetodoTask);

// Utilizando un factor task vía task
Task t2 = Task.Factory.StartNew(MetodoTask);

// Utilizando un constructor Task
Task t3 = new Task(MetodoTask);
t3.Start();

Task t4 = Task.Run(() => MetodoTask());

Console.ReadKey();

static void MetodoTask()
{
    Console.WriteLine("Ejecutando una tarea => MetodoTask()");
    Console.WriteLine("Task id: {0}", Task.CurrentId);
}